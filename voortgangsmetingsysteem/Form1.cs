using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace voortgangsmetingsysteem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {
             
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void knop1_Click(object sender, EventArgs e)
        {
            percentage1.Text = "100%";
        }
        private void knop2_Click(object sender, EventArgs e)
        {
            percentage2.Text = "100%";
        }
        private void knop3_Click(object sender, EventArgs e)
        {
            percentage3.Text = "100%";
        }
        private void knop4_Click(object sender, EventArgs e)
        {
            percentage4.Text = "100%";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            percentage1.Text = "0%";
            percentage2.Text = "0%";
            percentage3.Text = "0%";
            percentage4.Text = "0%";

        }

        private void homepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //overzicht.Redirect("WebForm1.aspx");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }
    }
}
