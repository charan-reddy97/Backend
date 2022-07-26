using System.Collections.Generic;

namespace Books.Core.Repository
{
    public interface IBookRepository
    {
        Book Add(Book book);
        void Delete(int id);
        Book FindById(int id);
        List<Book> GetBooks();
        List<Book> GetBooksByAuthor(string author);
        Book Update(Book book);
    }
}