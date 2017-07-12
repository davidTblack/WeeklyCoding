using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_8.Reading
{
    public class Online : ReadingMaterial, IPrintable
    {
        //public string UrlSource { get; set; }
        //public string PostDate { get; set; }
        public string PostTitle { get; set; }

        public Online()
        {
        }

        public Online(ReadingMaterial material, string title)
        {
            Author = material.Author;
            Language = material.Language;
            NumberOfPages = material.NumberOfPages;
            Price = material.Price;
            PostTitle = title;
        }

        public Online(string title, string author, string language, int numberPages, decimal price)
            : base (author, language, numberPages, price)
        {
            PostTitle = title;
        }

        public string HardCopySource()
        {
            return "Printable PDF";
        }
    }
}
