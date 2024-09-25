using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBooksOpgave.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        public string Name { get; set; }

        public List<Book> BooksWritten { get; set; } = new List<Book>();

        public Author() { }

        public Author(string name = "")
        {

            Name = name;

        }
    }
}
