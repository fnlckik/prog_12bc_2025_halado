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
        internal King EditKing { get; }

        public EditForm()
        {
            InitializeComponent();
        }
    }
}
