using BookStore_Models.Models;

namespace BookStore_BL.Interfaces
{
    public interface IBookService
    {
        List<Book>GetAll();

        List<Book> GetAllByAuthorId(int authorId);

        Book? GetById(int id);

        void Add(Book book);

        void Delete(int id);
    }
}
