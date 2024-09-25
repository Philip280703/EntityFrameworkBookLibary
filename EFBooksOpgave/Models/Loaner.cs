using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBooksOpgave.Models
{
    public class Loaner
    {
        public int LoanerId { get; set; }

        public string Name { get; set; }

        public List<Book> Loans { get; set; } = new List<Book>();

        public Loaner() { }

        public Loaner(string name = "")
        {

            Name = name;

        }
    }
}
