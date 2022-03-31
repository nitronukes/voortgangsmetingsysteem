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
            Close();
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toevoegen_k_Click(object sender, EventArgs e)
        {
            DateTime p2 = dateTimePicker1.Value;
            String p1 = textBox1.Text;

            string strResultJson = Newtonsoft.Json.JsonConvert.SerializeObject(p1);
            System.IO.File.WriteAllText(@"jsonbestand.json", strResultJson);
            MessageBox.Show("opgeslagen");


            Close();
        }
    }
}
