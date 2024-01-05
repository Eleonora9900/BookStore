using BookStore_Models.Models;
using System;

public class GetAllBookByAuthorResponse
{
	public Author author {  get; set; }	
	public List<Book> Books { get; set; }

 }
