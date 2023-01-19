using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Repository.Interfaces
{
    public interface ILibraryRepository
    {
        public void InsertBook( string Title, string Description, string Genre, int Pages);
    }
}