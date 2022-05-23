using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
     public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public int YearOfPublish { get; set; }

        public double Price { get; set; }

        public string Description => $"{Author}, {Title}";

        public override string ToString()
        {
            return $"{Author}. {Title}, {Price} UAH";
        }
    }
}
