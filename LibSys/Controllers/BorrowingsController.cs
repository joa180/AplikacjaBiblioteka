using System;
using System.Linq;
using System.Threading.Tasks;
using LibSys.Data;
using LibSys.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace LibSys.Controllers
{
    [Authorize(Roles = "User,Admin")]
    public class BorrowingsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public BorrowingsController(
            ApplicationDbContext context,
            UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Borrowings
        public async Task<IActionResult> Index()
        {
            var query = _context.Borrowings
                .Include(b => b.Book).ThenInclude(bk => bk.BookDefinition)
                .Include(b => b.Reader)
                .AsQueryable();

            if (!User.IsInRole("Admin"))
            {
                var aspUserId = _userManager.GetUserId(User);
                var reader = await _context.Readers
                                   .SingleOrDefaultAsync(r => r.UserId == aspUserId);
                query = reader == null
                    ? query.Where(b => false)
                    : query.Where(b => b.ReaderId == reader.Id);
            }

            return View(await query.ToListAsync());
        }

        // GET: Borrowings/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null) return NotFound();

            var borrowing = await _context.Borrowings
                .Include(b => b.Book).ThenInclude(bk => bk.BookDefinition)
                .Include(b => b.Reader)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (borrowing == null) return NotFound();

            return View(borrowing);
        }

        // GET: Borrowings/Create
        public async Task<IActionResult> Create(Guid? itemId)
        {
            ViewData["BookId"] = new SelectList(
                await _context.Books
                    .Include(b => b.BookDefinition)
                    .Select(b => new { b.Id, Title = b.BookDefinition.Title })
                    .ToListAsync(),
                "Id", "Title", itemId);

            if (User.IsInRole("Admin"))
            {
                ViewData["ReaderId"] = new SelectList(
                    await _context.Readers
                        .Select(r => new { r.Id, r.Name })
                        .ToListAsync(),
                    "Id", "Name");
            }
            else
            {
                var aspUserId = _userManager.GetUserId(User);
                var reader = await _context.Readers
                                   .SingleOrDefaultAsync(r => r.UserId == aspUserId);
                if (reader != null)
                    ViewData["ReaderId"] = reader.Id;
                else
                    ModelState.AddModelError("", "Brak przypisanego profilu czytelnika.");
            }

            return View();
        }

        // POST: Borrowings/Create
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookId,BorrowDate,ReturnDate,ReaderId")] Borrowing borrowing)
        {
            if (!ModelState.IsValid)
            {
                await PopulateCreateViewData(borrowing.ReaderId);
                return View(borrowing);
            }

            borrowing.Id = Guid.NewGuid();

            if (!User.IsInRole("Admin"))
            {
                var aspUserId = _userManager.GetUserId(User);
                var reader = await _context.Readers
                                   .SingleOrDefaultAsync(r => r.UserId == aspUserId);
                if (reader == null)
                {
                    ModelState.AddModelError("", "Brak profilu czytelnika, nie można dodać wypożyczenia.");
                    await PopulateCreateViewData(null);
                    return View(borrowing);
                }
                borrowing.ReaderId = reader.Id;
            }

            // 1) dodajemy wypożyczenie
            _context.Add(borrowing);
            // 2) ustawiamy status książki na Borrowed
            var book = await _context.Books.FindAsync(borrowing.BookId);
            if (book != null)
            {
                book.Status = BookStatus.Borrowed;
                _context.Books.Update(book);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Return(Guid id)
        {
            var borrowing = await _context.Borrowings.FindAsync(id);
            if (borrowing == null || borrowing.IsReturned)
                return NotFound();

            // 1) oznacz wypożyczenie jako zwrócone
            borrowing.IsReturned = true;
            _context.Borrowings.Update(borrowing);

            // 2) przywróć status książki
            var book = await _context.Books.FindAsync(borrowing.BookId);
            if (book != null)
            {
                book.Status = BookStatus.Available;
                _context.Books.Update(book);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Borrowings/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null) return NotFound();
            var borrowing = await _context.Borrowings.FindAsync(id);
            if (borrowing == null) return NotFound();

            await PopulateEditViewData(borrowing);
            return View(borrowing);
        }

        // POST: Borrowings/Edit/5
        [HttpPost, ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,BookId,BorrowDate,ReturnDate,ReaderId")] Borrowing borrowing)
        {
            if (id != borrowing.Id) return NotFound();
            if (!ModelState.IsValid)
            {
                await PopulateEditViewData(borrowing);
                return View(borrowing);
            }

            try
            {
                _context.Update(borrowing);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await _context.Borrowings.AnyAsync(e => e.Id == borrowing.Id))
                    return NotFound();
                throw;
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Borrowings/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null) return NotFound();
            var borrowing = await _context.Borrowings
                .Include(b => b.Book).ThenInclude(bk => bk.BookDefinition)
                .Include(b => b.Reader)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (borrowing == null) return NotFound();
            return View(borrowing);
        }

        // POST: Borrowings/Delete/5
        [HttpPost, ActionName("Delete"), ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var borrowing = await _context.Borrowings.FindAsync(id);
            if (borrowing != null)
            {
                // przywracamy status książki
                var book = await _context.Books.FindAsync(borrowing.BookId);
                if (book != null)
                {
                    book.Status = BookStatus.Available;
                    _context.Books.Update(book);
                }
                _context.Borrowings.Remove(borrowing);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private async Task PopulateCreateViewData(Guid? selectedReaderId)
        {
            ViewData["BookId"] = new SelectList(
                await _context.Books
                    .Include(b => b.BookDefinition)
                    .Select(b => new { b.Id, Title = b.BookDefinition.Title })
                    .ToListAsync(),
                "Id", "Title");

            if (User.IsInRole("Admin"))
            {
                ViewData["ReaderId"] = new SelectList(
                    await _context.Readers
                        .Select(r => new { r.Id, r.Name })
                        .ToListAsync(),
                    "Id", "Name", selectedReaderId);
            }
            else
            {
                ViewData["ReaderId"] = selectedReaderId;
            }
        }

        private async Task PopulateEditViewData(Borrowing borrowing)
        {
            ViewData["BookId"] = new SelectList(
                await _context.Books.Include(b => b.BookDefinition)
                    .Select(b => new { b.Id, Title = b.BookDefinition.Title })
                    .ToListAsync(),
                "Id", "Title", borrowing.BookId);

            ViewData["ReaderId"] = new SelectList(
                await _context.Readers
                    .Select(r => new { r.Id, r.Name })
                    .ToListAsync(),
                "Id", "Name", borrowing.ReaderId);
        }
    }
}
