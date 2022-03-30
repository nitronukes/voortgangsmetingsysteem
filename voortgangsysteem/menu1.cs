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
    public partial class menu1 : Form
    {
        public menu1()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, EventArgs e)
        {
            home newForm = new home();
            newForm.Show();
        }

        private void project_overzicht_Click(object sender, EventArgs e)
        {
            project_overzicht newForm = new project_overzicht();
            newForm.Show();

        }

        private void project_toevoegen_Click(object sender, EventArgs e)
        {
            project_toevoegen newForm = new project_toevoegen();
            newForm.Show();
        }

        private void beoordelingspagina_Click(object sender, EventArgs e)
        {
            beoordelings_pagina newForm = new beoordelings_pagina();
            newForm.Show();
        }
    }
}





