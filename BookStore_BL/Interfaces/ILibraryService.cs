﻿
namespace BookStore_BL.Interfaces
{
    public interface ILibraryService
    {
        public GetAllBookByAuthorResponse
            GetAllBookByAuthorAfterDate(GetAllBookByAuthorRequest request);

        int CheckBookCount(int input);

        int CheckAuthorCount(int input);
    }

}

