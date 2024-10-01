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
            new Loaner { Name = "Jane Doe" },
            new Loaner { Name = "Liam Smith" },
            new Loaner { Name = "Michael Jackson" },
            new Loaner { Name = "Emily Reed" },
            new Loaner { Name = "Mr Brown" },
            new Loaner { Name = "Owen Wilson" },
            new Loaner { Name = "James Smith" },
            new Loaner { Name = "Julio Martinez" },
            new Loaner { Name = "David Hesselhof" },
            new Loaner { Name = "Olivia Seebach" }
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

        public void SeedExpandedData()
        {
            Console.WriteLine("Seeding real Authors and Books...");

            var db = new MyDbContext();

            List<Author> newAuthors = new List<Author>
            {
                new Author { Name = "Cormac McCarthy" },
                new Author { Name = "Yuval Noah Harari" },
                new Author { Name = "Paulo Coelho" },
                new Author { Name = "Paula Hawkins" },
                new Author { Name = "Gillian Flynn" },
                new Author { Name = "Erin Morgenstern" },
                new Author { Name = "Markus Zusak" },
                new Author { Name = "Tara Westover" },
                new Author { Name = "Michelle Obama" },
                new Author { Name = "Frank Herbert" }

               
        };
            db.Authors.AddRange(newAuthors);
            db.SaveChanges(); // Save authors to generate their IDs




            List<Book> newBooks = new List<Book>
            {
                new Book { Title = "The Road", NumberOfCopies = 7, AuthorId = 11, Price = 13.99, Genre = "Post-Apocalyptic", NumOfPages = 287, PublicationDate = new DateTime(2006, 9, 26) },
                new Book { Title = "Sapiens: A Brief History of Humankind", NumberOfCopies = 10, AuthorId = 12, Price = 21.99, Genre = "Non-fiction", NumOfPages = 443, PublicationDate = new DateTime(2011, 9, 4) },
                new Book { Title = "The Alchemist", NumberOfCopies = 8, AuthorId = 13, Price = 15.99, Genre = "Adventure", NumOfPages = 208, PublicationDate = new DateTime(1988, 4, 25) },
                new Book { Title = "The Girl on the Train", NumberOfCopies = 9, AuthorId = 14, Price = 12.99, Genre = "Thriller", NumOfPages = 395, PublicationDate = new DateTime(2015, 1, 13) },
                new Book { Title = "Gone Girl", NumberOfCopies = 10, AuthorId = 15, Price = 14.99, Genre = "Thriller", NumOfPages = 422, PublicationDate = new DateTime(2012, 6, 5) },
                new Book { Title = "The Night Circus", NumberOfCopies = 6, AuthorId = 16, Price = 18.99, Genre = "Fantasy", NumOfPages = 387, PublicationDate = new DateTime(2011, 9, 13) },
                new Book { Title = "The Book Thief", NumberOfCopies = 8, AuthorId = 17, Price = 16.99, Genre = "Historical Fiction", NumOfPages = 552, PublicationDate = new DateTime(2005, 3, 14) },
                new Book { Title = "Educated", NumberOfCopies = 9, AuthorId = 18, Price = 17.99, Genre = "Memoir", NumOfPages = 334, PublicationDate = new DateTime(2018, 2, 20) },
                new Book { Title = "Becoming", NumberOfCopies = 12, AuthorId = 19, Price = 22.99, Genre = "Memoir", NumOfPages = 448, PublicationDate = new DateTime(2018, 11, 13) },
                new Book { Title = "Dune", NumberOfCopies = 11, AuthorId = 20, Price = 19.99, Genre = "Science Fiction", NumOfPages = 688, PublicationDate = new DateTime(1965, 8, 1) }
            };

            db.Books.AddRange(newBooks);
            db.SaveChanges(); // Save books to the database

        }

        public void SeedReviews()
        {
            var db = new MyDbContext(); // Replace with your actual DbContext

            var reviews = new List<Review>
        {
            new Review { FirstName = "Lily", LastName = "Scott", Email = "lilyscott@example.com", Stars = 4,  = 11, ReviewDate = new DateTime(2024, 09, 30) },
            new Review { FirstName = "Oliver", LastName = "King", Email = "oliverking@example.com", Stars = 5, BookId = 12, ReviewDate = new DateTime(2024, 10, 01) },
            new Review { FirstName = "Sophia", LastName = "Reed", Email = "sophiareed@example.com", Stars = 3, BookId = 13, ReviewDate = new DateTime(2024, 10, 02) },
            new Review { FirstName = "James", LastName = "Perry", Email = "jamesperry@example.com", Stars = 2, BookId = 14, ReviewDate = new DateTime(2024, 10, 03) },
            new Review { FirstName = "Isabella", LastName = "Wright", Email = "isabellawright@example.com", Stars = 4, BookId = 15, ReviewDate = new DateTime(2024, 10, 04) },
            new Review { FirstName = "Lucas", LastName = "Harris", Email = "lucasharris@example.com", Stars = 5, BookId = 16, ReviewDate = new DateTime(2024, 10, 05) },
            new Review { FirstName = "Mia", LastName = "Walker", Email = "miawalker@example.com", Stars = 3, BookId = 17, ReviewDate = new DateTime(2024, 10, 06) },
            new Review { FirstName = "Ethan", LastName = "Lewis", Email = "ethanlewis@example.com", Stars = 4, BookId = 18, ReviewDate = new DateTime(2024, 10, 07) },
            new Review { FirstName = "Charlotte", LastName = "Young", Email = "charlotteyoung@example.com", Stars = 5, BookId = 1, ReviewDate = new DateTime(2024, 10, 08) },
            new Review { FirstName = "Aiden", LastName = "Hall", Email = "aidenhall@example.com", Stars = 2, BookId = 2, ReviewDate = new DateTime(2024, 10, 09) }
        };

            db.Reviews.AddRange(reviews);
            db.SaveChanges();
        }

    }
}
