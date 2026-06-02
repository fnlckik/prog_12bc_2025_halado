using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
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

namespace UsedCarDealership
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        Car selected;

        public event PropertyChangedEventHandler? PropertyChanged;

        public MainWindow()
        {
            selected = new();
            InitializeComponent();
            Cars = [];
            DataContext = this;
        }

        public ObservableCollection<Car> Cars { get; set; }
        public Car Selected
        {
            get => selected;
            set { 
                selected = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Selected)));
            }
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            bool success = dialog.ShowDialog() ?? false;
            if (!success) return;
            using StreamReader sr = new StreamReader(dialog.FileName);
            Cars.Clear();
            while (!sr.EndOfStream)
            {
                string[] temp = sr.ReadLine()!.Split(";");
                string brand = temp[0];
                int year = int.Parse(temp[1]);
                int price = int.Parse(temp[2]);
                bool isPetrol = bool.Parse(temp[3]);
                string condition = temp[4];
                Car c = new(brand, year, price, isPetrol, condition);
                Cars.Add(c);
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new();
            bool success = dialog.ShowDialog() ?? false;
            if (!success) return;
            using StreamWriter sw = new StreamWriter(dialog.FileName + ".txt");
            foreach (Car c in ListBox.SelectedItems)
            {
                sw.WriteLine($"{c.Brand};{c.Year};{c.Price};{c.IsPetrol};{c.Condition}");
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (selected.Brand == "" || selected.Condition == "") return;
            Car s = selected;
            Cars.Add(new(s.Brand,s.Year,s.Price,s.IsPetrol,s.Condition));
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBox.SelectedItems.Count != 0)
            {
                Car original = ListBox.SelectedItems.Cast<Car>().Last();
                Selected = new Car(original.Brand, original.Year, original.Price, original.IsPetrol, original.Condition);
            }
            else Selected = new();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Car? c = Cars.Where(x => x.Brand == selected.Brand 
                            && x.Year == selected.Year 
                            && x.Price == selected.Price 
                            && x.Condition == selected.Condition).FirstOrDefault();
            if (c == null) return;
            Cars.Remove(c);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox t = ConditionTextBox;
            switch (t.Text)
            {
                case "új":
                    t.Background = Brushes.Green;
                    break;
                case "használt":
                    t.Background = Brushes.Yellow;
                    break;
                case "sérült":
                    t.Background = Brushes.Red;
                    break;
                default:
                    t.Background= Brushes.LightBlue;
                    break;
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (ListBox.SelectedItems.Count == 0) return;

            Car actualcar = (Car)ListBox.SelectedItems[ListBox.SelectedItems.Count -1]!;

            Car updated = new(Selected.Brand, Selected.Year, Selected.Price, Selected.IsPetrol, Selected.Condition);

            Cars[Cars.IndexOf(actualcar)] = updated;
        }
    }
}