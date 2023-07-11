using BooksAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BooksAPI.Services.Interfaces
{
    public interface IBookService
    {
        List<Book> GetAll();
        Book GetById(int id);
        List<Book> AddBook(Book book);
        List<Book> UpdateBook(int id, Book book);
        List<Book> DeleteBook(int id);
    }

}
