using System;
using System.Collections.Generic;
using System.Text;
using AuthorBooksAPI.Application.DTO;

namespace AuthorBooksAPI.Application.Interfaces
{
    public interface IBooksService
    {
        Task<List<BookDto>> GetAllAsync();
    }
}
