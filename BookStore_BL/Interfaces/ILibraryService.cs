﻿using BookStore_BL.Services;

namespace BookStore_BL.Interfaces
{
    public interface ILibraryService
    {
        public GetAllBookByAuthorResponse
             GetAllBookByAuthorAfterDate(GetAllBookByAuthorRequest request);
    }
}