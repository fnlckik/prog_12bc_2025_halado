using System.ComponentModel;

namespace _2_Quotations
{
    public class Quotation : INotifyPropertyChanged
    {
        private string author;
        private string title;
        private int year;

        public Quotation(string author, string title, int year, string text)
        {
            this.author = author;
            this.title = title;
            this.year = year;
            Text = text;
        }

        public Quotation()
        {
            this.author = "";
            this.title = "";
            this.year = 1000;
            Text = "";
        }

        public string Text { get; set; }
        public string Author
        {
            get => author;
            set
            {
                author = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Author)));
            }
        }

        public string Title
        {
            get => title;
            set
            {
                title = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Title)));
            }
        }

        public int Year
        {
            get => year;
            set
            {
                year = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Year)));
            }
        }

        // Számított adattag
        public string DisplayedText
        {
            get => $"{Author}: {Text}";
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public override string ToString()
        {
            //string result = string.Join("", Text.Take(20));
            //$"{Text[..20]}..."
            int n = Math.Min(Text.Length, 20);
            return $"{Text[..n].Trim()}...";
        }

        public Quotation Clone()
        {
            return new(Author, Title, Year, Text);
        }
    }
}
