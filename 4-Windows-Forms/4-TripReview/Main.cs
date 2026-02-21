using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TripReview
{
    public partial class Main : Form
    {
        private List<Traveller> travellers = new List<Traveller>();
        private List<Rating> ratings = new List<Rating>();

        public Main()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
            string path = GetParentPath(Application.StartupPath, 2) + "\\Data";
            openFileDialog.InitialDirectory = path;
            //LoadTravellers("../../Data/utasok.txt");
            //LoadReviews("../../Data/ertekelesek.csv");
        }

        private void LoadReviews(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                ratings.Clear();
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] temp = sr.ReadLine().Split(';');
                    int id = int.Parse(temp[0]);
                    string tripName = temp[1];
                    int travellerId = int.Parse(temp[2]);
                    DateTime reviewDate = DateTime.Parse(temp[3]);
                    int activitiesRating = int.Parse(temp[4]);
                    int locationRating = int.Parse(temp[5]);
                    string comment = temp[6];
                    Rating r = new Rating(id, tripName, travellerId, reviewDate, activitiesRating, locationRating, comment);
                    ratings.Add(r);
                }
            }
            //TravellersComboBox.DataSource = null;
            //TravellersComboBox.DataSource = ratings;
            //RatingsDataGrid.Columns.Clear();
            //RatingsDataGrid.DataSource = ratings;
            ShowRatings();
        }

        private void ShowRatings()
        {
            RatingsDataGrid.Columns.Clear();
            RatingsDataGrid.Columns.Add("TripName", "Utazás célja");
            RatingsDataGrid.Columns.Add("TravellerId", "Utazó azonosítója");
            RatingsDataGrid.Columns.Add("ReviewDate", "Értékelés dátuma");
            RatingsDataGrid.Columns.Add("ActivitiesRating", "Programok");
            RatingsDataGrid.Columns.Add("LocationRating", "Helyszín");
            RatingsDataGrid.Columns.Add("Comment", "Szöveges értékelés");
            foreach (var r in ratings)
            {
                RatingsDataGrid.Rows.Add();
            }
        }

        private void LoadTravellers(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                travellers.Clear();
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] temp = sr.ReadLine().Split(';');
                    int id = int.Parse(temp[0]);
                    string name = temp[1];
                    string email = temp[2];
                    DateTime birthDate = DateTime.Parse(temp[3]);
                    Traveller t = new Traveller(id, name, email, birthDate);
                    travellers.Add(t);
                }
            }
            TravellersComboBox.DataSource = travellers;
            TravellersComboBox.SelectedIndex = -1;
            TravellersComboBox.SelectedIndexChanged += TravellersComboBox_SelectedIndexChanged;
        }

        private void TravellersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Traveller t = TravellersComboBox.SelectedItem as Traveller;
            if (t == null) return;
            NameLabel.Text = "Név: " + t.Name;
            EmailLabel.Text = "Email: " + t.Email;
            //DateLabel.Text = "Születési dátum: " + t.BirthDate.ToShortDateString();
            DateLabel.Text = $"Születési dátum: {t.BirthDate:d}";
        }

        private string GetParentPath(string path, int n)
        {
            string[] temp = path.Split('\\');
            return string.Join("\\", temp.Take(temp.Length - n));
        }

        private void TravellersMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Szöveges fájl|*.txt";
            DialogResult result = openFileDialog.ShowDialog();
            if (result != DialogResult.OK) return;
            LoadTravellers(openFileDialog.FileName);
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void RatingsMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "CSV fájl|*.csv";
            openFileDialog.FileName = "";
            DialogResult result = openFileDialog.ShowDialog();
            if (result != DialogResult.OK) return;
            LoadReviews(openFileDialog.FileName);
        }
    }
}
