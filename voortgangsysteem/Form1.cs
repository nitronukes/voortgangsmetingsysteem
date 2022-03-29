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

namespace voortgangsysteem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void projectToevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void projectenoverzichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Project_overzichtpagina overzichtpagina = new Project_overzichtpagina();
            overzichtpagina.Show();
        }
    }
}
