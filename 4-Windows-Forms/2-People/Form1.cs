using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_People
{
    public partial class Form1 : Form
    {
        private List<Person> people;

        public Form1()
        {
            InitializeComponent();
            people = new List<Person>
            {
                new Person("Fekete Róbert", 19),
                new Person("Nagy Kinga", 25),
                new Person("Szabó Regina", 15)
            };
            //peopleListBox.Items.AddRange(people.ToArray());
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            peopleListBox.SelectionMode = SelectionMode.None;
            panel.Visible = false;
            peopleListBox.DataSource = null;
            peopleListBox.DataSource = people;
            peopleListBox.SelectionMode = SelectionMode.One;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim(); // Trim: whitespace-ek leszedése a széléről
            if (name == "") return;
            int age = (int)ageNumUpDown.Value;
            if (people.Any(p => p.Name == name && p.Age == age))
            {
                MessageBox.Show("Van már ilyen rögzített adat.", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };
            Person person = new Person(name, age);
            //peopleListBox.Items.Add($"{name} ({age})");
            //peopleListBox.Items.Add(person);
            people.Add(person);
            UpdateListBox();
            //peopleListBox.SelectedItem = peopleListBox.Items[peopleListBox.Items.Count - 1];
            //peopleListBox.SelectedIndex = peopleListBox.Items.Count - 1;
            //peopleListBox.SelectedItem = people.Last();
            peopleListBox.SelectedItem = person;
        }

        private void peopleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(peopleListBox.SelectedItem.ToString());
            Person selected = peopleListBox.SelectedItem as Person;
            selectedName.Text = "Név: " + selected?.Name;
            selectedAge.Text = "Életkor: " + selected?.Age;
            selectedSalary.Text = "Fizetés: " + selected?.Salary + " Ft";
            panel.Visible = true;
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            /*
            IEnumerable<Person> people = peopleListBox.Items.Cast<Person>();
            people = people.OrderBy(p => p.Age).ToList();
            peopleListBox.Items.Clear();
            peopleListBox.Items.AddRange(people.ToArray());
            */
            //foreach (var item in people)
            //{
            //    peopleListBox.Items.Add(item);
            //}
            people = people.OrderBy(p => p.Age).ToList();
            UpdateListBox();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            //dialog.InitialDirectory = "H:\\25-26\\prog_12bc_2025_halado\\4-Windows-Forms\\2-People\\bin\\Debug";
            //MessageBox.Show(Application.ExecutablePath);
            //dialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //dialog.InitialDirectory = Directory.GetParent(Application.ExecutablePath).FullName;
            //dialog.InitialDirectory = Directory.GetCurrentDirectory();
            dialog.InitialDirectory = Application.StartupPath;
            dialog.Filter = "Szöveges fájl|*.txt|CSV fájl|*.csv|Minden fájl|*.*";
            dialog.DefaultExt = ".txt";
            DialogResult result = dialog.ShowDialog();
            if (result != DialogResult.OK) return;
            string path = dialog.FileName;
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (var p in people)
                {
                    sw.WriteLine($"{p.Name},{p.Age},{p.Salary}");
                }
            }
        }
    }
}
