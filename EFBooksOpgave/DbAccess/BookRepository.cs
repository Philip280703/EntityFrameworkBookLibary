using EFBooksOpgave.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBooksOpgave.DbAccess
{
    public class BookRepository
    {
        public BookRepository() {
        
        }

        public void Add(Book book)
        {
            MyDbContext db = new MyDbContext();
            db.Books.Add(book);
            db.SaveChanges();
        }

        public Book GetBook(int id)
        {
            MyDbContext db = new MyDbContext();
            var book = db.Books.First(b => b.BookId == id);
            return book;
        }

        public List<Book> GetAllBooks()
        {
            MyDbContext db = new MyDbContext();
            var Booklist = db.Books.ToList();
            return Booklist;
        }

        public void UpdateBook(Book book)
        {
            MyDbContext db = new MyDbContext();
            db.Books.Update(book);
            db.SaveChanges();
        }

        public void DeleteBook(Book book)
        {
            MyDbContext db = new MyDbContext();
            db.Books.Remove(book);
            db.SaveChanges();
        }
    }
}
