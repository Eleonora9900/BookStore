

using BookStore_Models.Models;

namespace BookStore_DL.Interfaces
{
    public interface IBookRepository
    {
        List<Book> GetAll();

        Book? GetById(int id);

        void Add(Book book);

        void Delete(int id);
    }
}
