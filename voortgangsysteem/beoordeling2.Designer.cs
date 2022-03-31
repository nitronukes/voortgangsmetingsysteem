
namespace voortgangsysteem
{
    partial class beoordeling2
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
            this.label1.Location = new System.Drawing.Point(221, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "hoe is het uitwerken van de code verlopen?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // onvoldoende
            // 
            this.onvoldoende.Location = new System.Drawing.Point(257, 277);
            this.onvoldoende.Name = "onvoldoende";
            this.onvoldoende.Size = new System.Drawing.Size(203, 65);
            this.onvoldoende.TabIndex = 6;
            this.onvoldoende.Text = "onvoldoende";
            this.onvoldoende.UseVisualStyleBackColor = true;
            this.onvoldoende.Click += new System.EventHandler(this.onvoldoende_Click);
            // 
            // voldoende
            // 
            this.voldoende.Location = new System.Drawing.Point(257, 206);
            this.voldoende.Name = "voldoende";
            this.voldoende.Size = new System.Drawing.Size(203, 65);
            this.voldoende.TabIndex = 5;
            this.voldoende.Text = "voldoende";
            this.voldoende.UseVisualStyleBackColor = true;
            this.voldoende.Click += new System.EventHandler(this.voldoende_Click);
            // 
            // goed
            // 
            this.goed.Location = new System.Drawing.Point(257, 135);
            this.goed.Name = "goed";
            this.goed.Size = new System.Drawing.Size(203, 65);
            this.goed.TabIndex = 4;
            this.goed.Text = "goed";
            this.goed.UseVisualStyleBackColor = true;
            this.goed.Click += new System.EventHandler(this.goed_Click);
            // 
            // beoordeling2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.onvoldoende);
            this.Controls.Add(this.voldoende);
            this.Controls.Add(this.goed);
            this.Name = "beoordeling2";
            this.Text = "beoordeling2";
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