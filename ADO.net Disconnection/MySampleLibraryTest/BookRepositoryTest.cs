using HelloWeb.Model;
using MyBookLibrary;
using NUnit.Framework;

namespace BookLibraryTest
{
    public class BookRepositoryTest
    {
        BookRepository bookRepository = new BookRepository();

        [Test]
        public void AddNewBook_ValidData_ReturnsBook()
        {
            //Arrange
            Book book = new Book();
            book.Name = "Test Book";
            book.Author = "Demo Author";

            //Act
            var newBook = bookRepository.Add(book);

            //Assert
            Assert.IsNotNull(newBook);
            Assert.IsTrue(newBook.Id > 0);
        }
        [Test]
        public void GetAllBooks_ValidData_ReturnsListBooks()
        {
            //Arrange 

            //Act
            var books = bookRepository.GetAllBooks();

            //Assert
            Assert.That(books.Count > 0);
        }


    }
}
