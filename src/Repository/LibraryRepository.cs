using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using src.Repository.Interfaces;


namespace src.Repository
{
    public class LibraryRepository : ILibraryRepository
    {
        private List<Book> _booksLibrary = new List<Book>();
        public List<Book> GetBooks {get => _booksLibrary;}

        public void InsertBook(string Title, string Description, string Genre, int Pages)
        {          
            _booksLibrary.Add(new Book(Title, Description, Genre, Pages));
            System.Console.WriteLine($"Book successfully added:\n Title:{Title}, Description:{Description}, Genre:{Genre}, Pages:{Pages} ");
        }

        public List<Book> GetAllBooks()
        {
            return GetBooks;
        }

        public void RemoveBook(int id)
        {
            if(_booksLibrary.Any(x => x.Id == id) == true)
            {
                _booksLibrary.Remove(_booksLibrary.Single(x => x.Id == id));
                int newId = 1;
                foreach(var book in _booksLibrary)
                {
                    book.UpdateId(newId++);
                }
                
            }
            else
            {
                System.Console.WriteLine("Please inform a valid id");                
            }
            


        }

    }
}