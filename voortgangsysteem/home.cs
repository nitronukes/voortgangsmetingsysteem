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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void Project_overzichtpagina_Load(object sender, EventArgs e)
        {

            for (int i = 0; i <= 2; i++)
            {
                // maak een nieuwe rij aan (van 3 kolommen).
                string[] row = { "Eerste project" + i, "29-03-2022", "100%" };

                // maak een listview item (rij) aan.
                var newListViewItem = new ListViewItem(row);

                // voeg het nieuwe item toe aan de lijst.
                projectenListView.Items.Add(newListViewItem);
            }


            // maak een nieuwe rij aan (van 3 kolommen).
            //string[] row = { "Eerste project", "29-03-2022", "100%" };

            //string[] row1 = { "Eerste project", "29-03-2022", "100%" };

            //// maak een listview item (rij) aan.
            //var newListViewItem = new ListViewItem(row);
            //var newListViewItem1 = new ListViewItem(row1);

            //// voeg het nieuwe item toe aan de lijst.
            //projectenListView.Items.Add(newListViewItem);
            //projectenListView.Items.Add(newListViewItem1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //menu1 newForm = new menu1();
            //newForm.ShowDialog();

            Close();

        }

        private void projectenListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
