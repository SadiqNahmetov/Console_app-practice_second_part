﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services.Interface
{
    public interface ILibraryService
    {
        Library Create(Library library);

        Library Update(int Id, Library library);
        void Delete(int id);

        Library GetById(int id);
        List<Library> GetAll();
        List<Library> Search(string name);
    }
}
