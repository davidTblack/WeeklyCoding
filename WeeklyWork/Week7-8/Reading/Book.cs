using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_8.Reading
{
    public class Book : ReadingMaterial, IPrintable
    {
        public bool IsHardCover { get; set; }
        //public string CopyWrightDate { get; set; }
        public string BookTitle { get; set; }

        public Book()
        {
        }

        public Book(ReadingMaterial material, bool isHardCover, string title)
        {
            Author = material.Author;
            Language = material.Language;
            NumberOfPages = material.NumberOfPages;
            Price = material.Price;
            IsHardCover = isHardCover;
            BookTitle = title;

        }

        public Book(bool isHardCover, string title, string author, string language, int numberPages, decimal price)
            : base (author, language, numberPages, price)
        {
            IsHardCover = isHardCover;
            BookTitle = title;
        }

        public string HardCopySource()
        {
            return "Bookstore";
        }
    }
}
