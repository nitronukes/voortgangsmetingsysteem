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
    public partial class project_overzicht : Form
    {
        public project_overzicht()
        {
            InitializeComponent();
        }

        private void Project_overzicht_load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 2; i++)
            {
                // maak een nieuwe rij aan (van 3 kolommen).
                string[] row = { "Eerste project" + i, "29-03-2022", "100%" , "kaas" };

                // maak een listview item (rij) aan.
                var newListViewItem = new ListViewItem(row);

                // voeg het nieuwe item toe aan de lijst.
                overzicht.Items.Add(newListViewItem);
            }
        }

        private void home_Click(object sender, EventArgs e)
        {
            Close();
            home newForm = new home();
            newForm.Show();
        }
    }
}
