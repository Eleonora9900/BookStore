using BookStore_Models.Models;

namespace BookStore_BL.Interfaces
{
    public interface IAuthorService
    {
        List<Author> GetAll();

        Author? GetById(int id);

        void Add(Author author);

        void Delete(int id);
    }
}
