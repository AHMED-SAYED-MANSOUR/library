using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newlibrary1
{
    public partial class view : Form
    {
        public view()
        {
            InitializeComponent();
        }

        private void view_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librarySystemDataSet1.Document' table. You can move, or remove it, as needed.
            this.documentTableAdapter2.Fill(this.librarySystemDataSet1.Document);
            // TODO: This line of code loads data into the 'newlibraryDataSet.Document' table. You can move, or remove it, as needed.
            this.documentTableAdapter1.Fill(this.newlibraryDataSet.Document);
            // TODO: This line of code loads data into the 'librarySystemDataSet.Document' table. You can move, or remove it, as needed.
            this.documentTableAdapter.Fill(this.librarySystemDataSet.Document);
            // TODO: This line of code loads data into the 'newlibraryDataSet.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.newlibraryDataSet.Admin);

        }
    }
}
