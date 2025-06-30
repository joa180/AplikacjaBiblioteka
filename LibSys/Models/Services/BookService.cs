using System;
using System.Collections.Generic;
using System.Linq;
using LibSys.Data;
using LibSys.Models.Dto;
using LibSys.Models.Entities;
using LibSys.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibSys.Models.Services
{
    public class BookService : IBookService
    {
        private readonly ApplicationDbContext _context;

        public BookService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<AvailableBookDto> GetAvailableBooksForGuests()
        {
            // Pobierz wszystkie dostępne egzemplarze wraz z definicjami
            var books = _context.Books
                .Include(b => b.BookDefinition)
                .Where(b => b.Status == BookStatus.Available)
                .ToList();

            // Zgrupuj po definicji i zmapuj na DTO
            var grouped = books
                .GroupBy(b => b.BookDefinitionId)
                .Select(g => new AvailableBookDto
                {
                    Id = g.Key,
                    Title = g.First().BookDefinition.Title,
                    Author = g.First().BookDefinition.Author,
                    CoverImagePath = g.First().BookDefinition.CoverImagePath,
                    Count = g.Count()
                })
                .ToList();

            return grouped;
        }

        public bool BookExists(Guid id)
        {
            return (_context.Books?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
