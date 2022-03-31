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
    public partial class beoordeling2 : Form
    {
        public beoordeling2()
        {
            InitializeComponent();
        }

        private void goed_Click(object sender, EventArgs e)
        {
            Close();
            beoordeling3 newForm = new beoordeling3();
            newForm.Show();
        }

        private void onvoldoende_Click(object sender, EventArgs e)
        {
            Close();
            beoordeling3 newForm = new beoordeling3();
            newForm.Show();
        }

        private void voldoende_Click(object sender, EventArgs e)
        {
            Close();
            beoordeling3 newForm = new beoordeling3();
            newForm.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
