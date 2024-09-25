using EFBooksOpgave.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBooksOpgave.DbAccess
{
    public class DbHandler
    {
        SqlConnection conn = null;
        public DbHandler()
        {
            conn = new SqlConnection("Server=PHILIP-LAPTOP;Database=EntityFrameworkLibaryBooks;TrustServerCertificate = true; Trusted_Connection=True");
        }
        public void printAuthors()
        {


            List<Author> authors = new List<Author>();

            string command = "select * from authors ";

            SqlCommand cmd = new SqlCommand(command, conn);


            try
            {
                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int AuthorID = (int)reader["AuthorID"];
                    string name = (string)reader["Name"];

                    Author author = new Author { AuthorId = AuthorID, Name = name };

                    authors.Add(author);
                }

                Console.WriteLine("\n\n-----------------------------\nAuthor List");
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                conn.Close();
            }


            foreach (Author author in authors)
            {
                Console.WriteLine("\n-----------------------------------------------");
                Console.Write($"AuthorID = {author.AuthorId}\t Name = {author.Name}");
            }
            Console.WriteLine();


        }



        public void printBooks()
        {


            List<Book> books = new List<Book>();

            string command = "select * from Books ";

            SqlCommand cmd = new SqlCommand(command, conn);


            try
            {
                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int Id = (int)reader["BookID"];
                    string Title = (string)reader["Title"];
                    int NumberOfCopies = (int)reader["NumberOfCopies"];
                    int AuthorID = (int)reader["AuthorID"];

                    Book book = new Book { BookId = Id, Title = Title, NumberOfCopies = NumberOfCopies, AuthorId = AuthorID };

                    books.Add(book);
                }

                Console.WriteLine("\n\n-----------------------------\nBookList");
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                conn.Close();
            }


            foreach (Book book in books)
            {
                Console.WriteLine("\n-----------------------------------------------");
                Console.Write($"ID = {book.BookId}  Title = {book.Title}\nNr of copies = ${book.NumberOfCopies} \t AuthorID = {book.AuthorId}");
            }
            Console.WriteLine();


        }


        public void printLoaners()
        {


            List<Loaner> Loaners = new List<Loaner>();

            string command = "select * from loaners ";

            SqlCommand cmd = new SqlCommand(command, conn);


            try
            {
                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int LoanerID = (int)reader["LoanerID"];
                    string name = (string)reader["Name"];

                    Loaner Loaner = new Loaner { LoanerId = LoanerID, Name = name };

                    Loaners.Add(Loaner);
                }

                Console.WriteLine("\n\n-----------------------------\nLoaner List");
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                conn.Close();
            }


            foreach (Loaner Loaner in Loaners)
            {
                Console.WriteLine("\n-----------------------------------------------");
                Console.Write($"LoanerID = {Loaner.LoanerId}\t Name = {Loaner.Name}");
            }
            Console.WriteLine();


        }


    }
}
