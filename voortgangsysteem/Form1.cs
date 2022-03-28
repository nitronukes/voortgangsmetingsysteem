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
            Form3 Projectenoverzicht = new Form3();
            Projectenoverzicht.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void projectenoverzichtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 Projectenoverzicht = new Form3();
            Projectenoverzicht.Show();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string filebath = @"C:\Users\yasse\OneDrive\Documents\GitHub\voortgangsmetingsysteem\voortgangsysteem\Projecten.txt";
            List<string> Projecten = new List<string>();
            File.ReadAllLines(filebath).ToList();
        }
    }
}
