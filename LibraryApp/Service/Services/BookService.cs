using Domain.Models;
using Repository.Repositories;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class BookService : IBookService
    {
        private BookRepository _bookRepesitory;
        private LibraryRepository _libraryRepesitory;
        private int count;
        public Book Create(int libraryId, Book book)
        {
            var library = _libraryRepesitory.Get(mbox => mbox.Id == libraryId);
            if (library is null) return null;
             book.Id = count;
            book.Library = library;
            _bookRepesitory.Create(book);
            count++;
            return book;
        }
    }
}
