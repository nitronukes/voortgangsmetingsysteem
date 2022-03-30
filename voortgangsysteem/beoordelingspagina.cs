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

        private void beoordelingspagina_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 2; i++)
            {
                // maak een nieuwe rij aan (van 3 kolommen).
                string[] row = { "Eerste project" + i, "29-03-2022", "100%" };

                // maak een listview item (rij) aan.
                var newListViewItem = new ListViewItem(row);

                // voeg het nieuwe item toe aan de lijst.
                beoordeling.Items.Add(newListViewItem);
            }
        }
    }
}
