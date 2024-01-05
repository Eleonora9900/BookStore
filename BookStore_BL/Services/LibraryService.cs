
using BookStore_BL.Services;
using BookStore_BL.Interfaces;
using BookStore_Models.Models;

public class LibraryService : ILibraryService
{
    private readonly IBookService _bookService;
    private readonly  IAuthorService _authorService;
    public LibraryService(IAuthorService authorService, IBookService bookService)
    {
        _authorService = authorService;
        _bookService = bookService;
    }

    public GetAllBookByAuthorResponse GetAllBookByAuthorAfterDate(GetAllBookByAuthorRequest request)
    {
        var result = new GetAllBookByAuthorResponse()
        {
            Author = _authorService.GetById(int id);
            Books = _bookService.GetAllByAuthorId(request.AuthorId);
        }
        return result;
    }

}
