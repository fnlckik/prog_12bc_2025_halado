using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace _1_Hello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string personName; // field (mező, adattag)

        // Binding: összekötés, összekapcsolás
        // Csak property-re lehet használni! (get, set)
        // Observable: megfigyelhető
        public ObservableCollection<string> Names { get; set; }
        
        public string PersonName // property (tulajdonság) -> getter, setter
        { 
            get
            {
                return personName;
            }
            set
            {
                personName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PersonName)));
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            //Names = new ObservableCollection<string>();
            //Names = new();
            //Names = new ObservableCollection<string>() { "Sándor", "József", "Benedek" };
            Names = ["Sándor", "József", "Benedek"];
            personName = "";
            DataContext = this; // Azért kell, hogy a Binding tudja, hogy hol van a Names property.
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        // CREATE
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            //string name = NameTextBox.Text;
            //NamesListBox.Items.Add(name);
            Names.Add(PersonName);
            //NamesListBox.ItemsSource = null;
            //NamesListBox.ItemsSource = Names;
            //bool? b; -> true, false, null
        }

        // READ
        private void GreetButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Heló világ!", "Köszöntés", MessageBoxButton.OK, MessageBoxImage.Information);
            //string name = NameTextBox.Text;
            GreetingOutput.Text = $"Helló {PersonName}!";
        }

        //private void NamesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    // ?.ToString() -> ha null értéken hívom, akkor null legyen az eredmény
        //    // null-coalescing operator
        //    PersonName = NamesListBox.SelectedItem?.ToString() ?? "";
        //    //NameTextBox.Text = PersonName;
        //}

        // UPDATE
        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            int i = NamesListBox.SelectedIndex;
            if (i < 0) return;
            Names[i] = PersonName;
        }

        // DELETE
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            //Names.Remove(NamesListBox.SelectedItem?.ToString() ?? "");
            Names.Remove(PersonName);
        }

        // CRUD műveletek
    }
}