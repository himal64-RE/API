using System;
using System.Collections.Generic;
using System.Text;
using AuthorBooksAPI.Application.Interfaces;
using AuthorBooksAPI.Application.DTO;
using AuthorBooksAPI.Infrastructure.Interfaces;

namespace AuthorBooksAPI.Application.Implimentations
{
    public class BooksService
    {
        private readonly IBooksRepository _booksRepository;
        public BooksService(IBooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }
        public async Task<List<BookDto>> GetAllAsync()
        {
            var books = await _booksRepository.GetAllAsync();
            return books.Select(x => new BookDto
            {
                BookId = x.BookId,
                Title = x.Title,
                BookNumber = x.BookNumber,
                PublishedYear = x.PublishedYear,
                CreatedDate = x.CreatedDate,
                UpdatedDate = x.UpdatedDate,
                DeletedDate = x.DeletedDate,
            }).ToList();
        }
    }
}
