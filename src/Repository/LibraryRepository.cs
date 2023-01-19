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

        

        public void InsertBook(string Title, string Description, string Genre, int Pages)
        {          
            var book = new Book(Title, Description, Genre, Pages);
            _booksLibrary.Add(book);
            System.Console.WriteLine($"Livro adicionado com sucesso:\n {Title} {Description}, {Genre}, {Pages} ");

        }
    }
}