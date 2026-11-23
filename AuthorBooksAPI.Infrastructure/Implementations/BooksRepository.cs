using AuthorBooksAPI.Domain.Entities;
using AuthorBooksAPI.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace AuthorBooksAPI.Infrastructure.Implementations
{
    public class BooksRepository : IBooksRepository
    {
        private readonly AuthorBooksAPIDbContext _context;
        public BooksRepository(AuthorBooksAPIDbContext context) {
            _context = context;
        }
        public async Task<List<Book>> GetAllAsync()
        {
            return await _context.Books.Where(x => x.DeletedDate == null).ToListAsync();
        }
    }
}
