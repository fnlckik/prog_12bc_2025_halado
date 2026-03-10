using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlovesFactory
{
    public partial class CategoryForm : Form
    {
        private List<int> data;
        private List<string> categories;

        public CategoryForm(List<int> data, List<string> categories)
        {
            InitializeComponent();
            this.data = data;
            this.categories = categories;
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            CategoriesDataGrid.Font = new Font("Microsoft Sans Serif", 12);
            //CategoriesDataGrid.Columns.Add("Frequencies", "Gyakoriságok");
            CategoriesDataGrid.RowCount = categories.Count;
            for (int i = 0; i < categories.Count; i++)
            {
                CategoriesDataGrid.Rows[i].HeaderCell.Value = categories[i];
            }
            CategoriesDataGrid.TopLeftHeaderCell.Value = "Kategóriák";
            CategoriesDataGrid.Columns[0].HeaderCell.Value = "Gyakoriságok";
        }
    }
}
