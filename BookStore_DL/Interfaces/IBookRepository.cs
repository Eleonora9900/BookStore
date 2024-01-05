

using BookStore_Models.Models;

namespace BookStore_DL.Interfaces
{
    public interface IBookRepository
    {
        List<Book> GetAll();

        List<Book> GetAllByAuthorId(int authorId);

        Book? GetById(int id);

        void Add(Book book);

        void Delete(int id);
    }
}
