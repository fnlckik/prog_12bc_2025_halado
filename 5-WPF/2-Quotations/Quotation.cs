using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Quotations
{
    public class Quotation
    {
        public Quotation(string author, string title, int year, string text)
        {
            Author = author;
            Title = title;
            Year = year;
            Text = text;
        }

        public Quotation()
        {
            Author = "";
            Title = "";
            Year = 1000;
            Text = "";
        }

        public string Author { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            //string result = string.Join("", Text.Take(20));
            //$"{Text[..20]}..."
            int n = Math.Min(Text.Length, 20);
            return $"{Text[..n].Trim()}...";
        }
    }
}
