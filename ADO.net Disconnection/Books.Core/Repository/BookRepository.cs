using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Core.Repository
{
    public class BookRepository : IBookRepository
    {
        BookDbContext dbContext;
        public BookRepository(BookDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        /// <summary>
        /// Add method will create a new book. 
        /// Currently no additional validations are checked
        /// </summary>
        /// <param name="book">Book</param>
        /// <returns>Books with the newly created Id updated</returns>
        public Book Add(Book book)
        {

            book.CreatedDate = DateTime.Now;
            dbContext.Books.Add(book);
            dbContext.SaveChanges();
            return book;
        }


        public Book Update(Book book)
        {
            Book currentBook = dbContext.Books.FirstOrDefault(d => d.Id == book.Id);
            currentBook.Name = book.Name;
            currentBook.Author = book.Author;
            currentBook.LastModifiedDate = DateTime.Now;

            dbContext.Update(currentBook);
            dbContext.SaveChanges();

            return currentBook;
        }

        public void Delete(int id)
        {
            Book book = dbContext.Books.FirstOrDefault(d => d.Id == id);
            book.DeletedDate = DateTime.Now;

            dbContext.Update(book);
            dbContext.SaveChanges();
        }

        public Book FindById(int id)
        {
           var book= dbContext.Books.FirstOrDefault(d => d.Id == id);
            if(book==null)
            {
                throw new Exception($"\nBook with id {id} is not found");

            }
            return book;
        }

        public List<Book> GetBooks()
        {
            return dbContext.Books.Where(d => d.DeletedDate == null).ToList();
        }

        public List<Book> GetBooksByAuthor(string author)
        {
            return dbContext.Books.Where(d => d.DeletedDate == null && d.Author == author).ToList();
        }

    }

}
