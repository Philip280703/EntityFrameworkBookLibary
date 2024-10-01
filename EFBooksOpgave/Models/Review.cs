using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBooksOpgave.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Email { get; set; }

        public int Stars { get; set; }
        public DateTime ReviewDate { get; set; }

        public Book book { get; set; }

        public Review() { }

        public Review(string name = " ")
        {
            FirstName = name;
        }


    }
}
