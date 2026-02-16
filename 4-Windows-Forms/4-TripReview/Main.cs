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
            //LoadTravellers("../../Data/utasok.txt");
            //LoadReviews("../../Data/ertekelesek.csv");
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
        }
    }
}
