
namespace voortgangsysteem
{
    partial class beoordeling3
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
            this.label1 = new System.Windows.Forms.Label();
            this.onvoldoende = new System.Windows.Forms.Button();
            this.voldoende = new System.Windows.Forms.Button();
            this.goed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "hoe zijn de standups gegaan";
            // 
            // onvoldoende
            // 
            this.onvoldoende.Location = new System.Drawing.Point(251, 290);
            this.onvoldoende.Name = "onvoldoende";
            this.onvoldoende.Size = new System.Drawing.Size(203, 65);
            this.onvoldoende.TabIndex = 10;
            this.onvoldoende.Text = "onvoldoende";
            this.onvoldoende.UseVisualStyleBackColor = true;
            this.onvoldoende.Click += new System.EventHandler(this.onvoldoende_Click);
            // 
            // voldoende
            // 
            this.voldoende.Location = new System.Drawing.Point(251, 219);
            this.voldoende.Name = "voldoende";
            this.voldoende.Size = new System.Drawing.Size(203, 65);
            this.voldoende.TabIndex = 9;
            this.voldoende.Text = "voldoende";
            this.voldoende.UseVisualStyleBackColor = true;
            this.voldoende.Click += new System.EventHandler(this.voldoende_Click);
            // 
            // goed
            // 
            this.goed.Location = new System.Drawing.Point(251, 148);
            this.goed.Name = "goed";
            this.goed.Size = new System.Drawing.Size(203, 65);
            this.goed.TabIndex = 8;
            this.goed.Text = "goed";
            this.goed.UseVisualStyleBackColor = true;
            this.goed.Click += new System.EventHandler(this.goed_Click);
            // 
            // beoordeling3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.onvoldoende);
            this.Controls.Add(this.voldoende);
            this.Controls.Add(this.goed);
            this.Name = "beoordeling3";
            this.Text = "beoordeling3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button onvoldoende;
        private System.Windows.Forms.Button voldoende;
        private System.Windows.Forms.Button goed;
    }
}