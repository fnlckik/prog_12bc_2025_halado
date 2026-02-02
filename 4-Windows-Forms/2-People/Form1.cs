using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            peopleListBox.DataSource = null;
            peopleListBox.DataSource = people;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            int age = (int)ageNumUpDown.Value;
            Person person = new Person(name, age);
            //peopleListBox.Items.Add($"{name} ({age})");
            //peopleListBox.Items.Add(person);
            people.Add(person);
            UpdateListBox();
        }

        private void peopleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(peopleListBox.SelectedItem.ToString());
            Person selected = peopleListBox.SelectedItem as Person;
            selectedName.Text = "Név: " + selected?.Name;
            selectedAge.Text = "Életkor: " + selected?.Age;
            selectedSalary.Text = "Fizetés: " + selected?.Salary + " Ft";
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
    }
}
