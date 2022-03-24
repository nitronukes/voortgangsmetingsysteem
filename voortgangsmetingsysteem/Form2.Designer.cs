
namespace voortgangsmetingsysteem
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toevoegen);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.p_naam_label);
            this.Controls.Add(this.p_naam);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox p_naam;
        private System.Windows.Forms.Label p_naam_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label datum;
        private System.Windows.Forms.Button toevoegen;
    }
}