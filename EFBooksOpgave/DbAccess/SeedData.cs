using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFBooksOpgave.Models;

namespace EFBooksOpgave.DbAccess
{
    public class SeedData
    {

        public void seedBooksAndAuthors()
        {
            Console.WriteLine("Seeding real Authors and Books...");

            var db = new MyDbContext();

            // Step 1: Create 10 real authors
            var authors = new List<Author>
        {
            new Author { Name = "George Orwell" },
            new Author { Name = "J.K. Rowling" },
            new Author { Name = "J.R.R. Tolkien" },
            new Author { Name = "Harper Lee" },
            new Author { Name = "F. Scott Fitzgerald" },
            new Author { Name = "Ernest Hemingway" },
            new Author { Name = "Jane Austen" },
            new Author { Name = "Mark Twain" },
            new Author { Name = "Charles Dickens" },
            new Author { Name = "Leo Tolstoy" }
        };

            db.Authors.AddRange(authors);
            db.SaveChanges(); // Save authors to generate their IDs

            // Step 2: Create 10 real books, each linked to an author
            var books = new List<Book>
        {
            new Book { Title = "1984", NumberOfCopies = 12, AuthorId = authors[0].AuthorId },       // George Orwell
            new Book { Title = "Harry Potter and the Philosopher's Stone", NumberOfCopies = 15, AuthorId = authors[1].AuthorId },  // J.K. Rowling
            new Book { Title = "The Lord of the Rings", NumberOfCopies = 10, AuthorId = authors[2].AuthorId }, // J.R.R. Tolkien
            new Book { Title = "To Kill a Mockingbird", NumberOfCopies = 8, AuthorId = authors[3].AuthorId }, // Harper Lee
            new Book { Title = "The Great Gatsby", NumberOfCopies = 14, AuthorId = authors[4].AuthorId },     // F. Scott Fitzgerald
            new Book { Title = "The Old Man and the Sea", NumberOfCopies = 9, AuthorId = authors[5].AuthorId }, // Ernest Hemingway
            new Book { Title = "Pride and Prejudice", NumberOfCopies = 11, AuthorId = authors[6].AuthorId },   // Jane Austen
            new Book { Title = "The Adventures of Tom Sawyer", NumberOfCopies = 7, AuthorId = authors[7].AuthorId },  // Mark Twain
            new Book { Title = "A Tale of Two Cities", NumberOfCopies = 13, AuthorId = authors[8].AuthorId },  // Charles Dickens
            new Book { Title = "War and Peace", NumberOfCopies = 6, AuthorId = authors[9].AuthorId }            // Leo Tolstoy
        };

            db.Books.AddRange(books);
            db.SaveChanges(); // Save books to the database
        }

        public void seedLoaners()
        {
            Console.WriteLine("Seeding Loaners...");

            var db = new MyDbContext();

            // Step 1: Create 10 loaners with real names
            var loaners = new List<Loaner>
        {
            new Loaner { Name = "John Doe" },
            new Loaner { Name = "Jane Smith" },
            new Loaner { Name = "Michael Johnson" },
            new Loaner { Name = "Emily Davis" },
            new Loaner { Name = "William Brown" },
            new Loaner { Name = "Sophia Wilson" },
            new Loaner { Name = "James Garcia" },
            new Loaner { Name = "Mia Martinez" },
            new Loaner { Name = "David Miller" },
            new Loaner { Name = "Olivia Anderson" }
        };

            db.Loaners.AddRange(loaners);
            db.SaveChanges();

            // Step 2: Assign random books to the loaners
            var random = new Random();
            var books = db.Books.ToList();

            foreach (var loaner in loaners)
            {
                // Assign random books to each loaner (1-3 books)
                int numberOfBooks = random.Next(1, 4);
                loaner.Loans = new List<Book>();

                for (int i = 0; i < numberOfBooks; i++)
                {
                    var randomBook = books[random.Next(books.Count)];
                    loaner.Loans.Add(randomBook);
                }

                db.Loaners.Update(loaner);
            }

            db.SaveChanges(); // Save loaners and their assigned books
        }

        //public void seedBooksAndAuthors()
        //{
        //    Console.WriteLine("Seeding data");

        //    var db = new MyDbContext();

        //    var author1 = new Author { Name = "Scott Gallaway" };
        //    var author2 = new Author { Name = "Peter Thiel" };


        //    db.Authors.Add(author1);
        //    db.Authors.Add(author2);

        //    db.SaveChanges();


        //    var book1 = new Book { Title = "The Four", NumberOfCopies = 10, AuthorId =  author1.AuthorId, Loaners =  new List<Loaner>()};
        //    var book2 = new Book { Title = "Zero to One", NumberOfCopies = 8, AuthorId = author2.AuthorId, Loaners = new List<Loaner>()};

        //    db.Books.Add(book1);
        //    db.Books.Add(book2);
        //    db.SaveChanges();

        //}

        //public void seedLoaners()
        //{
        //    var db = new MyDbContext();

        //    var loaner1 = new Loaner { Name = "Jens Christiansen" };

        //    var book1 = db.Books.Where(x => x.Title.StartsWith("The Four")).First();
        //    if (loaner1.Loans == null)
        //    {
        //        loaner1.Loans = new List<Book>(); 
        //    }

        //    if (book1 != null)
        //    {
        //        loaner1.Loans.Add(book1);  
        //        db.Loaners.Add(loaner1);  
        //        db.SaveChanges();         
        //    }
        //    else
        //    {
        //        Console.WriteLine("Book not found.");
        //    }

        //}



    }
}
