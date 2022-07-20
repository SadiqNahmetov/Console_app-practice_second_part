using Domain.Models;
using Service.Helpers;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Controllers
{
    public class BookController
    {
        BookService bookService = new BookService();
        public void Create()
        {
            Helper.WriteConsole(ConsoleColor.Blue, "Add library id : ");

        LibraryId : string libraryId = Console.ReadLine();
            int selectLibraryId;

           bool isSelectedId = int.TryParse(libraryId, out selectLibraryId);

            if (isSelectedId)
            {
                Helper.WriteConsole(ConsoleColor.Blue, "Add book name  : ");
                string bookName = Console.ReadLine();

                Helper.WriteConsole(ConsoleColor.Blue, "Add book author  : ");
                string author = Console.ReadLine();

                Book book = new Book()
                {
                    Name = bookName,
                    Author = author
                };

                var result = bookService.Create(selectLibraryId, book);

                if (result != null)
                {
                    Helper.WriteConsole(ConsoleColor.Green, $"Library id : {result.Id} , Name:{result.Name}, Seat count : {result.Author}, Book library: {result.Library.Name} ");
                }
                else
                {
                    Helper.WriteConsole(ConsoleColor.Red, "Library not found, please add coorrect library id: ");
                    goto LibraryId;
                }

            }
            else
            {
                Helper.WriteConsole(ConsoleColor.Red, "Add correct library id type : ");
                goto LibraryId;
            }




        }
    }
}
