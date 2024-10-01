using EFBooksOpgave.DbAccess;
using Microsoft.EntityFrameworkCore;

MyDbContext db = new MyDbContext();

SeedData sd = new SeedData();

DbHandler handler = new DbHandler();

//handler.printBooks();

//handler.printAuthors();

//handler.printLoaners();


var books = db.Books.OrderBy(b=>b.Title).Include(b=>b.Loaners).ToList();

books.ForEach(b =>
{
    Console.WriteLine("----------------------------\nBookID: " + b.BookId + "\tTitle: " + b.Title);

    // If there are loaners, print their details
    if (b.Loaners.Any())
    {
        Console.WriteLine("Has been loaned by the following persons: ");
        foreach (var loaner in b.Loaners) // Accessing the Loaners navigation property
        {
            Console.WriteLine($"ID: {loaner.LoanerId}\tName: {loaner.Name}");
        }
    }
    else
    {
        Console.WriteLine("This book has not been loaned by anyone yet.");
    }

    Console.WriteLine(); // For separating output between books
});











////----------------------------------------------------------
//// insert seed data to database - only use once
//var seeder = new SeedData();
//seeder.seedBooksAndAuthors();
//seeder.seedLoaners();
////-----------------------------------------------------------------------




