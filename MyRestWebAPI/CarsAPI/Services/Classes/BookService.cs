using BooksAPI.Models;
using BooksAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BooksAPI.Services.Classes
{
    public class BookService : IBookService
    {
        static List<Book> books = new List<Book>
        {
            new Book{Id = 1, Title="Harry Potter and the Philosopher's Stone", Year=1997, Genre="Fantasy"},
            new Book{Id = 2, Title="Harry Potter and the Chamber of Secrets", Year=1998, Genre="Fantasy"},
            new Book{Id = 3, Title="Harry Potter and the Prisoner of Azkaban", Year=1999, Genre="Fantasy"},
            new Book{Id = 4, Title="Harry Potter and the Goblet of Fire", Year=2000, Genre="Fantasy"},
            new Book{Id = 5, Title="Harry Potter and the Order of the Phoenix", Year=2003, Genre="Fantasy"},
            new Book{Id = 6, Title="Harry Potter and Half-Blood Prince", Year=2005, Genre="Fantasy"},
            new Book{Id = 7, Title="Harry Potter and Deathly Hallows", Year=2007, Genre="Fantasy"},
        };

        [HttpGet]
        public List<Book> GetAll()
        {
            return books;
        }
        [HttpGet]
        public Book GetById([FromHeader] int id)
        { 
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Id == id)
                {
                    return books[i];
                }
            }
            throw new Exception("This id doesn't exist");
        }

        [HttpPost]
        public List<Book> AddBook([FromBody] Book book)
        {
            int counter = 0;
            for (int i = 0; i < books.Count; i++)
            {
                if (book.Id != books[i].Id)
                {
                    counter++;
                }
            }
            if (counter == books.Count)
            {
                books.Add(book);
                return books;
            }
            throw new Exception("This id is already taken");
        }

        [HttpPut]
        public List<Book> UpdateBook([FromHeader] int id, [FromBody] Book book)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Id == id)
                {
                    books.RemoveAt(i);
                    books.Insert(i, book);
                }
            }
            return books;
        }

        [HttpDelete]
        public List<Book> DeleteBook([FromHeader] int id)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Id == id)
                {
                    books.RemoveAt(i);
                    return books;
                }
            }
            throw new Exception("This id doesn't exist");
        }

    }
}
