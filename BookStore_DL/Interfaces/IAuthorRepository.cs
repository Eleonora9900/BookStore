using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore_Models.Models;

namespace BookStore_DL.Interfaces
{
    public interface IAuthorRepository
    {
        List<Author> GetAll();

        Author? GetById(int id);

        void Add(Author author);

        void Delete(int id);
    }
}
