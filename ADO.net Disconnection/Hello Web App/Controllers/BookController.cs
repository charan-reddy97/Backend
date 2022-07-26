//using Hello_Web_App.Models;
using HelloWeb.Model;
using Microsoft.AspNetCore.Mvc;
using MyBookLibrary;
using System.Collections.Generic;


    [Route("/books")]
    public class BookController : Controller
    {
        BookRepository bookRepository = new BookRepository();

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Books = bookRepository.GetAllBooks();
            return View();
        }

        [HttpPost]
        public IActionResult Index(Book book)
        {
            if (ModelState.IsValid)
            {
                bookRepository.Add(book);
            }

            ViewBag.Books = bookRepository.GetAllBooks();
            return View();
        }

        [HttpGet("details/{id}")]
        public IActionResult
            Details(int id)
        {
            Book searchedBook = bookRepository.FindById(id);
            //foreach (var book in books)
            //{
            //    if(book.Id == id)
            //    {
            //        searchedBook = book;
            //        break;
            //    }
            //}

            return View(searchedBook);
        }

        [HttpGet("edit/{id}")]
        public IActionResult Edit(int id)
        {
            Book searchedBook = bookRepository.FindById(id);

            //foreach (var book in books)
            //{
            //    if (book.Id == id)
            //    {
            //        searchedBook = book;
            //        break;
            //    }
            //}

            return View(searchedBook);
        }

        [HttpPost("edit")]
        public IActionResult Edit(Book updateBoook)
        {
            Book book = bookRepository.FindById(updateBoook.Id);
            book.Name = updateBoook.Name;
            book.Author = updateBoook.Author;

            bookRepository.Update(book);

            //foreach (var book in books)
            //{
            //    if (book.Id == updateBoook.Id)
            //    {
            //        book.Name = updateBoook.Name;
            //        book.Author = updateBoook.Author;

            //        Response.Redirect("/books");
            //        break;
            //    }
            //}
            return View(updateBoook);
        }

    }

