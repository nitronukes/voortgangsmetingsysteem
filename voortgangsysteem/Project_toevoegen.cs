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

        private void home_Click(object sender, EventArgs e)
        {
            menu1 newForm = new menu1();
            newForm.Show();

        }
    }
}
