using BookStore_BL.Interfaces;
using BookStore_DL.Interfaces;
using BookStore_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_BL.Services
{
    public class BookService : IBookService
    {
       
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void Add(Book book)
        {
            _bookRepository.Add(book);
        }

        public void Delete(int id)
        {
            _bookRepository.Delete(id);
        }

   
        public List<Book> GetAll()
        {
            return _bookRepository.GetAll();
        }

        public List<Book> GetAllByAuthorId(int authorId)
        {
            return _bookRepository.GetAllByAuthorId(authorId);
        }

        public Book? GetById(int id)
        {
            return _bookRepository.GetById(id);
        }
    }
}

