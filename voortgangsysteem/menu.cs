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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void projectToevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void projectov_Click(object sender, EventArgs e)
        {
            Project_overzichtpagina newForm = new Project_overzichtpagina();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            project_toevoegen newForm = new project_toevoegen();
            newForm.Show();
        }

        private void projectToevoegenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
