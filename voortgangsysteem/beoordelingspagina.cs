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
    public partial class beoordelingspagina : Form
    {
        public beoordelingspagina()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void vpt_Click(object sender, EventArgs e)
        {
            project_toevoegen newForm = new project_toevoegen();
            newForm.ShowDialog();

           
        }

        private void v1_Click(object sender, EventArgs e)
        {
            Close();
            beoordeling1 newForm = new beoordeling1();
            newForm.Show();
        }

        private void v2_Click(object sender, EventArgs e)
        {
            Close();
            beoordeling1 newForm = new beoordeling1();
            newForm.Show();
        }

        private void v3_Click(object sender, EventArgs e)
        {
            Close();
            beoordeling1 newForm = new beoordeling1();
            newForm.Show();
        }

        private void v4_Click(object sender, EventArgs e)
        {
            Close();
            beoordeling1 newForm = new beoordeling1();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
          
        }
    }
    }

