//using Hello_Web_App.Models;
using HelloWeb.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MyBookLibrary
{
    public class BookRepository
    {
        private string conStr = "Integrated Security=False;Server=.\\SqlExpress;uid=sa;password=pass@123;database=Backend";

        public Book Add(Book book)
        {
            string sqlQuery = "insert into Books(BookId,Name,Author) values(@BookId,@Name,@Author);";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.Parameters.AddWithValue("@BookId", book.Id);
                cmd.Parameters.AddWithValue("@Name", book.Name);
                cmd.Parameters.AddWithValue("@Author", book.Author);

                cmd.ExecuteNonQuery();
            }


            return book;
        }

        public Book Update(Book book)
        {
            return null;
        }

        public void Delete(int id)
        {

        }

        public List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();

            string sqlQuery = "select * from Books";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Book book = new Book
                    {
                        Id = (int)reader["BookId"]
                                          ,
                        Name = reader["Name"].ToString()
                                          ,
                        Author = reader["Author"].ToString()
                    };

                    books.Add(book);
                }
            }

            return books;
        }

        public Book FindById(int id)
        {
            return null;
        }
    }
}
