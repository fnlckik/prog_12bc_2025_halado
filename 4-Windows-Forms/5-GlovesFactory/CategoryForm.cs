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
    }
}
