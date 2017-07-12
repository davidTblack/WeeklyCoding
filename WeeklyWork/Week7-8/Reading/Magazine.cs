using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_8.Reading
{
    public class Magazine : ReadingMaterial, IPrintable
    {
        public string IssueFrequency { get; set; }
        public int IssueNumber { get; set; }


        public Magazine()
        {
        }

        public Magazine(ReadingMaterial material, string issueFreq, int issueNum)
        {
            Author = material.Author;
            Language = material.Language;
            NumberOfPages = material.NumberOfPages;
            Price = material.Price;
            IssueNumber = issueNum;
            IssueFrequency = issueFreq;
        }

        public Magazine(string issueFreq, int issueNum, string title, string author, string language, int numberPages, decimal price)
            : base (author, language, numberPages, price)
        {
            IssueFrequency = issueFreq;
            IssueNumber = issueNum;
        }

        public string HardCopySource()
        {
            return "Publisher";
        }
    }
}
