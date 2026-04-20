using Microsoft.Win32;
using System.Collections.ObjectModel;
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
    public partial class MainWindow : Window
    {
        //private ObservableCollection<Quotation> quotes; // field

        public MainWindow()
        {
            InitializeComponent();
            Quotes = [];
            DataContext = this;
        }

        public ObservableCollection<Quotation> Quotes { get; set; } // property

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
    }
}