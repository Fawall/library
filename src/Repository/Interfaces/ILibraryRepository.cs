using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Repository.Interfaces
{
    public interface ILibraryRepository
    {
        public void InsertBook(string title, string description, string genre, int pages);
        public List<Book> GetAllBooks();
        public void RemoveBook(int id);

    }
}