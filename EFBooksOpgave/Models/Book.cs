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

        public double Price { get; set; }

        public string Genre { get; set; }

        public int NumOfPages { get; set; }

        public DateTime PublicationDate { get; set; }

        public int? NextInSeriesId { get; set; }

        public Book? NextInSeries { get; set; }

        public Author Author { get; set; }

        public List<Loaner> Loaners { get; set; } = new List<Loaner>();

        public List<Review> Reviews { get; set; } = new List<Review>();

        public Book() { }

        public Book(string title = "", int numberOfCopies = 0)
        {

            Title = title;

            NumberOfCopies = numberOfCopies;

        }
    }
}
