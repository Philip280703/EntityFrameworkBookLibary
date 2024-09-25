using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBooksOpgave.Models
{
    public class Book
    {
        public int BookId { get; set; }

        public string Title { get; set; }
        public int NumberOfCopies { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; }

        public List<Loaner> Loaners { get; set; } = new List<Loaner>();

        public Book() { }

        public Book(string title = "", int numberOfCopies = 0)
        {

            Title = title;

            NumberOfCopies = numberOfCopies;

        }
    }
}
