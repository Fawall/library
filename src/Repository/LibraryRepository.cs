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
            System.Console.WriteLine($"Livro adicionado com sucesso:\n {Title} {Description}, {Genre}, {Pages} ");
        }

        public List<Book> GetAllBooks()
        {
            return GetBooks;
        }

    }
}