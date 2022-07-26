using Books.Core;
using Books.Core.Repository;
using Books.Core.SMS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiBasics.Filters;

namespace WebApiBasics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
   // [CheckIdParam]
    public class BooksController : ControllerBase
    {
        //private readonly BookRepository bookRepository;
        ISmsService smsService;
        IBookRepository bookRepository;
        public BooksController(ISmsService smsService, IBookRepository bookRepository)
        {            
    
            this.smsService = smsService;
            this.bookRepository = bookRepository;
        }

        [HttpGet]
        
        public IActionResult Get()
        {
            var books = bookRepository.GetBooks();
            return Ok(books);
        }

        [HttpGet("byid/{id}")]
       // [CheckException]
        public IActionResult Get(int id)
        {
            //if (id > 0)
            //{
                var book = bookRepository.FindById(id);

                if (book != null)
                    return Ok(book);
                else
                    return NotFound($"Book with the id:{id} cannot be found");
            //}
            //else
            //    return BadRequest($"Invalid Book Id");
        }

        [HttpGet("byauthor/{author}")]
        public IActionResult Get(string author)
        {
            if (!string.IsNullOrEmpty(author))
            {
                var booksByAuthor = bookRepository.GetBooksByAuthor(author);

                if (booksByAuthor.Count() > 0)
                    return Ok(booksByAuthor);
                else
                    return NotFound($"No books found for the author : {author}");
            }
            else
                return BadRequest($"Invalid Author Name");

        }

        [HttpPost]
       
        public IActionResult Post(Book book)
        {
            bookRepository.Add(book);
           // var sms = smsService.Sent($"New boook {book.Name} is now available at our library", "123456789");

            //return Created($"/api/books/{book.Id}", sms);

            return Created($"/api/books/{book.Id}", book);
        }

        [HttpPut]
       // [Authorize(Roles = "Admin")]
        public IActionResult Put(Book book)
        {
            if (book.Id > 0)
            {
                bookRepository.Update(book);
                return Ok();
            }
            else
                return BadRequest($"Invalid Book Id");
        }

        [HttpDelete("{id}")]
        //[Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            if (id > 0)
            {
                bookRepository.Delete(id);
                return Ok();
            }
            else
                return BadRequest($"Invalid Book Id");
        }
    }


}
