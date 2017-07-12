using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_8.Reading
{
    public class ReadingMaterial
    {
        public string Author { get; set; }
        public string Language { get; set; }
        public int NumberOfPages { get; set; }
        public decimal Price { get; set; }


        public ReadingMaterial()
        {
        }

        public ReadingMaterial(string author, string language, int numberPages, decimal price)
        {
            Author = author;
            Language = language;
            NumberOfPages = numberPages;
            Price = price;
        }
    }

    
}
