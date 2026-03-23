using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kings
{
    public partial class EditForm : Form
    {
        internal King EditedKing { get; private set; }

        internal EditForm(King editedKing)
        {
            InitializeComponent();
            this.EditedKing = editedKing;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            NameTextBox.Text = EditedKing.Name;
            YearNumUpDown.Value = EditedKing.Year;
            PlaceTextBox.Text = EditedKing.Place;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int year = (int)YearNumUpDown.Value;
            string place = PlaceTextBox.Text;
            King k = EditedKing;
            EditedKing = new King(k.Name, year, place, k.Start, k.End, k.Dynasty);
            Close();
        }
    }
}
