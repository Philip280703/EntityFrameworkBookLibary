using EFBooksOpgave.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBooksOpgave.DbAccess
{
    public class DbHandler
    {

        public void printAuthors()
        {
            MyDbContext db = new MyDbContext();

            var authorList = db.Authors.OrderBy(a => a.AuthorId).ToList();

            foreach (var author in authorList)
            {
                Console.WriteLine($"Author Name: {author.Name}, AuthorID: {author.AuthorId}\n---------------------------------------------");
            }


        }



        public void printBooks()
        {

            MyDbContext db = new MyDbContext();

            var BookList = db.Books.OrderBy(a => a.AuthorId).ToList();

            foreach (var Book in BookList)
            {
                Console.WriteLine($"AuthorID: {Book.AuthorId}, Price: {Book.Price:C2}, Number of pages: {Book.NumOfPages}\n--------------------------------------");
            }


        }


        public void printLoaners()
        {
            MyDbContext db = new MyDbContext();

            var LoanersList = db.Loaners.OrderBy(l => l.LoanerId).ToList();

            foreach (var item in LoanersList)
            {
                Console.WriteLine($"LoanerId {item.LoanerId}, Name: {item.Name}");
            }
        }


        public void PrintBookReviews()
        {
            MyDbContext db = new MyDbContext();
            var BookReviewList = db.Books.OrderBy(b => b.BookId).Include(b => b.Reviews).ToList();

            foreach (var b in BookReviewList)
            {
                Console.WriteLine($"BookID {b.BookId}, BookTitle: {b.Title}");
                foreach (var r in b.Reviews)
                {
                    Console.WriteLine($"Review {r.Stars}");
                }
            }
        }


    }


}

