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
    public partial class beoordeling3 : Form
    {
        public beoordeling3()
        {
            InitializeComponent();
        }

        private void goed_Click(object sender, EventArgs e)
        {
            Close();
            beoordeling4 newForm = new beoordeling4();
            newForm.Show();
        }

        private void voldoende_Click(object sender, EventArgs e)
        {
            Close();
            beoordeling4 newForm = new beoordeling4();
            newForm.Show();
        }

        private void onvoldoende_Click(object sender, EventArgs e)
        {
            Close();
            beoordeling4 newForm = new beoordeling4();
            newForm.Show();
        }
    }
}
