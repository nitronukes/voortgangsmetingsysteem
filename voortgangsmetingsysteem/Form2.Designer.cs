
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
            this.p_naam = new System.Windows.Forms.TextBox();
            this.p_naam_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.datum = new System.Windows.Forms.Label();
            this.toevoegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // p_naam
            // 
            this.p_naam.Location = new System.Drawing.Point(299, 170);
            this.p_naam.Name = "p_naam";
            this.p_naam.Size = new System.Drawing.Size(159, 22);
            this.p_naam.TabIndex = 0;
            this.p_naam.Tag = "";
            this.p_naam.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // p_naam_label
            // 
            this.p_naam_label.AutoSize = true;
            this.p_naam_label.Location = new System.Drawing.Point(256, 150);
            this.p_naam_label.Name = "p_naam_label";
            this.p_naam_label.Size = new System.Drawing.Size(158, 17);
            this.p_naam_label.TabIndex = 1;
            this.p_naam_label.Text = "voer uw project naam in";
            this.p_naam_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(299, 213);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Tag = "";
            // 
            // datum
            // 
            this.datum.AutoSize = true;
            this.datum.Location = new System.Drawing.Point(256, 193);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(47, 17);
            this.datum.TabIndex = 3;
            this.datum.Text = "datum";
            // 
            // toevoegen
            // 
            this.toevoegen.Location = new System.Drawing.Point(327, 270);
            this.toevoegen.Name = "toevoegen";
            this.toevoegen.Size = new System.Drawing.Size(87, 32);
            this.toevoegen.TabIndex = 4;
            this.toevoegen.Text = "toevoegen";
            this.toevoegen.UseVisualStyleBackColor = true;
            this.toevoegen.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
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