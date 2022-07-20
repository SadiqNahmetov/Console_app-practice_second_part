using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services.Interface
{
    public interface IBookService
    {
        Book Create(int libraryId, Book book);
    }
}
