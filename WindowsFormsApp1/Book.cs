using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
     public class Book
    {
        //id
        public int Id { get; set; }
        //title

        public string Title { get; set; }
        //author
        public string Author { get; set; }

        public int YearOfPublish { get; set; }
        //price
        public double Price { get; set; }
        //description
        public string Description => $"{Author}, {Title}";

        public override string ToString()
        {
            return $"{Author}. {Title}, {Price} UAH";
        }
    }
}
