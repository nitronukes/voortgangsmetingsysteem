using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace voortgangsysteem
{
    public partial class project_toevoegen : Form
    {
        public project_toevoegen()
        {
            InitializeComponent();
        }

        private void projectenoverzichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Project_overzichtpagina po = new Project_overzichtpagina();
            po.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu Home = new menu();
            Home.Show();
        }
    }
}
