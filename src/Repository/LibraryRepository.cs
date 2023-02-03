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

        public void InsertBook(string title, string description, string genre, int pages)
        {   
            if(string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(genre) || pages <= 0 || pages <= 0)
            {
                System.Console.WriteLine("Please inform valid values");
            }
            else
            {
                _booksLibrary.Add(new Book(title, description, genre, pages));
                System.Console.WriteLine($"Book successfully added:\n Title:{title}, Description:{description}, Genre:{genre}, Pages:{pages} ");
            }
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