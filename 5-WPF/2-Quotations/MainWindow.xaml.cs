using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Security.Policy;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2_Quotations
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        //private ObservableCollection<Quotation> quotes; // field
        private Quotation selected; // field
        private Quotation answer;
        private Brush? authorBackground;
        private Brush? titleBackground;
        private Brush? yearBackground;
        private bool isReloaded;

        public event PropertyChangedEventHandler? PropertyChanged;

        public MainWindow()
        {
            InitializeComponent();
            Quotes = [];
            Answers = [];
            selected = new();
            answer = new();
            DataContext = this;
            isReloaded = false;
        }

        public ObservableCollection<Quotation> Quotes { get; set; } // property
        public ObservableCollection<Quotation> Answers { get; set; }

        public Quotation Selected
        {
            get => selected;
            set
            {
                selected = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Selected)));
            }
        }

        public Quotation Answer
        { 
            get => answer;
            set
            {
                answer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Answer)));
            }
        }

        public Brush? AuthorBackground
        { 
            get => authorBackground;
            set
            {
                authorBackground = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AuthorBackground)));
            }
        }

        public Brush? TitleBackground
        {
            get => titleBackground;
            set
            {
                titleBackground = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TitleBackground)));
            }
        }

        public Brush? YearBackground
        {
            get => yearBackground;
            set
            {
                yearBackground = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(YearBackground)));
            }
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            //OpenFileDialog dialog = new();
            //dialog.InitialDirectory = Directory.GetCurrentDirectory();
            //bool success = dialog.ShowDialog() ?? false;
            //if (!success) return;
            //bool? success = dialog.ShowDialog();
            //if (success != true) return;
            string path = "../../../Forras/idezetek.txt";
            using StreamReader sr = new(path);
            Quotes.Clear();
            while (!sr.EndOfStream)
            {
                // !. operátor: null-forgiving operator
                // Ritkán használjuk! Ha biztosak vagyunk benne, hogy nem lehet null!
                string[] temp = sr.ReadLine()!.Split("|");
                string author = temp[0];
                string title = temp[1];
                int year = int.Parse(temp[2]);
                string text = temp[3];
                Quotation q = new(author, title, year, text);
                Quotes.Add(q);
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (isReloaded) return;
            // Windows Forms
            //selected = QuoteComboBox.SelectedItem as Quotation ?? new();
            QuoteTextBlock.Visibility = Visibility.Visible;
            //QuoteTextBlock.Text = selected.Text;
            Answer = new();
            Answer.Text = Selected.Text;
            //Answer.Author = "";
            //Answer.Title = "";
            //Answer.Year = 1000;
            AuthorBackground = Brushes.White;
            TitleBackground = Brushes.White;
            YearBackground = Brushes.White;
        }

        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            if (Answer == null) return;
            // Ez inkább Windows Forms még!
            //if (selected.Author == answer.Author)
            //{
            //    AuthorTextBox.Background = Brushes.LightGreen;
            //}
            //else
            //{
            //    SolidColorBrush b = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            //    AuthorTextBox.Background = b;
            //}

            // WPF
            //if (selected.Author == answer.Author)
            //{
            //    AuthorBackground = Brushes.LightGreen;
            //}
            //else
            //{
            //    SolidColorBrush b = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            //    AuthorBackground = b;
            //}
            Brush g = Brushes.LightGreen;
            Brush r = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            AuthorBackground = selected.Author == answer.Author ? g : r;
            TitleBackground = selected.Title == answer.Title ? g : r;
            YearBackground = selected.Year == answer.Year? g : r;
        }

        private void StoreButton_Click(object sender, RoutedEventArgs e)
        {
            if (Answer == null || Selected == null || Selected.Text == "") return;
            Answers.Add(Answer.Clone());
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Answer == null) return;
            isReloaded = true;
            Selected = Quotes.First(q => q.Text == Answer.Text);
            isReloaded = false;
            CheckButton_Click(sender, e);
        }
    }
}