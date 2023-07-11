using BooksAPI.Models;
using BooksAPI.Services.Classes;
using BooksAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BooksAPI.Controllers
{

    [ApiController]
    [Route("booksApi/[controller]/[action]")]
    public class BooksController : ControllerBase
    {
        private IBookService bookService;
        public BooksController(IBookService service)
        {
            this.bookService = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(bookService.GetAll());
        }
        [HttpGet]
        public IActionResult GetById([FromHeader]int id)
        {
            try
            {
                return Ok(bookService.GetById(id));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult Post([FromBody] Book book)
        {
            try
            {
                return Ok(bookService.AddBook(book));

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
              
        }
        [HttpPut]
        public IActionResult Put([FromHeader]int id, [FromBody] Book book)
        {
            return Ok(bookService.UpdateBook(id, book));
        }
        [HttpDelete]
        public IActionResult Delete([FromHeader]int id)
        {
            try
            {
                return Ok(bookService.DeleteBook(id));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
