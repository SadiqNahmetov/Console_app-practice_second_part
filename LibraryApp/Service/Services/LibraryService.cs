using Domain.Models;
using Repository.Repositories;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class LibraryService : ILibraryService
    {
        private LibraryRepository _libraryRepesitory;
        private int _count;
        public LibraryService()
        {
            _libraryRepesitory = new LibraryRepository();
        }
        public Library Create(Library library)
        {
            library.Id = _count;

            _libraryRepesitory.Create(library);
            _count++;
            return library;
        }

        public void Delete(int id)
        {
            Library library = GetById(id);
            _libraryRepesitory.Delete(library);
        }

        public List<Library> GetAll()
        {
            return _libraryRepesitory.GetAll();
        }

        public Library GetById(int id)
        {
            var library = _libraryRepesitory.Get(m => m.Id == id);
            if (library is null) return null;
            return library;
        }

        public List<Library> Search(string search)
        {
           return _libraryRepesitory.GetAll(m=>m.Name.Trim().ToLower().StartsWith(search.Trim().ToLower()));
        }

        public Library Update(int Id, Library library)
        {
            Library dblibrary = GetById(Id);
            if (dblibrary is null) return null;
            library.Id = dblibrary.Id;
            _libraryRepesitory.Update(library);
            return dblibrary;
        }
    }
}
