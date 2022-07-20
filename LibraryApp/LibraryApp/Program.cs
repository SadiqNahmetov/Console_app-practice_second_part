using Domain.Models;
using LibraryApp.Controllers;
using Service.Helpers;
using Service.Services;
using System;
using System.Collections.Generic;

namespace LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            LibraryController libraryController = new LibraryController();
            BookController bookController = new BookController();
             Helper.WriteConsole(ConsoleColor.Blue, "Select one option : ");

            GetMenues();

            while (true)
            {
                SelectOption : string selectOption = Console.ReadLine();
                //Console.WriteLine(selectOption);

                int selectTrueOption;
                bool isSelectOption = int.TryParse(selectOption,out selectTrueOption);

                if (isSelectOption)
                {
                    switch (selectTrueOption)
                    {
                        case (int)Menues.CreatLibrary:

                             libraryController.Create();

                              break;
                       
                        case (int)Menues.GetLibraryById:

                              libraryController.GetById();

                                break;
                            
                        case (int)Menues.UpdateLIbrary:

                            libraryController.Update();

                            break;

                        case (int)Menues.DeleteLibrary:

                            libraryController.Delete();

                            break;

                        case (int)Menues.GetAllLibraries:

                            libraryController.GetAll();

                            break;

                        case (int)Menues.SearchLibrary:

                            libraryController.Search();

                            break;

                        case (int)Menues.CreateBook:

                            bookController.Create();

                            break;

                        default:
                            Helper.WriteConsole(ConsoleColor.Red,"Select corectt option number");
                            break;

                    }
                }
                else
                {
                    Helper.WriteConsole(ConsoleColor.Red, "Select corect option : ");
                    goto SelectOption;
                }
            }
        }

       private static void GetMenues()
        {
            Helper.WriteConsole(ConsoleColor.Yellow, " 1 - Create library, 2 - Get library by id, 3 - Update library, 4 - Delete library," +
                " 5 - Get all libraries, 6 - Search for library by name, 7 - Create book ");
        }

    }
}
