using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LibSys.Data;
using LibSys.Models.Entities;
using LibSys.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace LibSys.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IBookService _bookService;
        private readonly IWebHostEnvironment _env;

        public BooksController(
            ApplicationDbContext context,
            IBookService bookService,
            IWebHostEnvironment env)
        {
            _context = context;
            _bookService = bookService;
            _env = env;
        }

        // GET: Books/AvailableBooks
        [AllowAnonymous]
        public IActionResult AvailableBooks()
        {
            var available = _bookService.GetAvailableBooksForGuests();
            return View(available);
        }

        // GET: Books
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var books = await _context.Books
                .Include(b => b.BookDefinition)
                .ToListAsync();
            return View(books);
        }

        // GET: Books/Details/5
        [Authorize]
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null) return NotFound();

            var book = await _context.Books
                .Include(b => b.BookDefinition)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (book == null) return NotFound();

            return View(book);
        }

        // GET: Books/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            ViewData["BookDefinitionId"] = new SelectList(
                _context.BookDefinitions.Select(d => new { d.Id, Display = d.Title }),
                "Id", "Display");
            return View();
        }

        // POST: Books/Create
        [HttpPost, ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(
            [Bind("Id,BookDefinitionId,Comment,Status")] Book book,
            IFormFile coverImage)
        {
            if (!ModelState.IsValid)
            {
                ViewData["BookDefinitionId"] = new SelectList(
                    _context.BookDefinitions.Select(d => new { d.Id, Display = d.Title }),
                    "Id", "Display", book.BookDefinitionId);
                return View(book);
            }

            book.Id = Guid.NewGuid();

            if (coverImage != null && coverImage.Length > 0)
            {
                var coversFolder = Path.Combine(_env.WebRootPath, "images", "covers");
                Directory.CreateDirectory(coversFolder);

                var ext = Path.GetExtension(coverImage.FileName);
                var fileName = $"{book.BookDefinitionId}{ext}";
                var filePath = Path.Combine(coversFolder, fileName);

                using (var stream = System.IO.File.Create(filePath))
                    await coverImage.CopyToAsync(stream);

                var def = await _context.BookDefinitions.FindAsync(book.BookDefinitionId);
                if (def != null)
                {
                    def.CoverImagePath = $"/images/covers/{fileName}";
                    _context.BookDefinitions.Update(def);
                }
            }

            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Books/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null) return NotFound();

            var book = await _context.Books.FindAsync(id);
            if (book == null) return NotFound();

            ViewData["BookDefinitionId"] = new SelectList(
                _context.BookDefinitions.Select(d => new { d.Id, Display = d.Title }),
                "Id", "Display", book.BookDefinitionId);
            return View(book);
        }

        // POST: Books/Edit/5
        [HttpPost, ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(
            Guid id,
            [Bind("Id,BookDefinitionId,Comment,Status")] Book book,
            IFormFile coverImage)
        {
            if (id != book.Id) return NotFound();

            if (!ModelState.IsValid)
            {
                ViewData["BookDefinitionId"] = new SelectList(
                    _context.BookDefinitions.Select(d => new { d.Id, Display = d.Title }),
                    "Id", "Display", book.BookDefinitionId);
                return View(book);
            }

            try
            {
                if (coverImage != null && coverImage.Length > 0)
                {
                    var coversFolder = Path.Combine(_env.WebRootPath, "images", "covers");
                    Directory.CreateDirectory(coversFolder);

                    var ext = Path.GetExtension(coverImage.FileName);
                    var fileName = $"{book.BookDefinitionId}{ext}";
                    var filePath = Path.Combine(coversFolder, fileName);

                    using (var stream = System.IO.File.Create(filePath))
                        await coverImage.CopyToAsync(stream);

                    var def = await _context.BookDefinitions.FindAsync(book.BookDefinitionId);
                    if (def != null)
                    {
                        def.CoverImagePath = $"/images/covers/{fileName}";
                        _context.BookDefinitions.Update(def);
                    }
                }

                _context.Books.Update(book);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_bookService.BookExists(book.Id))
                    return NotFound();
                throw;
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: Books/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null) return NotFound();

            var book = await _context.Books
                .Include(b => b.BookDefinition)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (book == null) return NotFound();

            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete"), ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book != null)
                _context.Books.Remove(book);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
