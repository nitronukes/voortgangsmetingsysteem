
namespace voortgangsysteem
{
    partial class beoordeling1
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
            this.goed = new System.Windows.Forms.Button();
            this.voldoende = new System.Windows.Forms.Button();
            this.onvoldoende = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // goed
            // 
            this.goed.Location = new System.Drawing.Point(274, 138);
            this.goed.Name = "goed";
            this.goed.Size = new System.Drawing.Size(203, 65);
            this.goed.TabIndex = 0;
            this.goed.Text = "goed";
            this.goed.UseVisualStyleBackColor = true;
            this.goed.Click += new System.EventHandler(this.goed_Click);
            // 
            // voldoende
            // 
            this.voldoende.Location = new System.Drawing.Point(274, 209);
            this.voldoende.Name = "voldoende";
            this.voldoende.Size = new System.Drawing.Size(203, 65);
            this.voldoende.TabIndex = 1;
            this.voldoende.Text = "voldoende";
            this.voldoende.UseVisualStyleBackColor = true;
            this.voldoende.Click += new System.EventHandler(this.voldoende_Click);
            // 
            // onvoldoende
            // 
            this.onvoldoende.Location = new System.Drawing.Point(274, 280);
            this.onvoldoende.Name = "onvoldoende";
            this.onvoldoende.Size = new System.Drawing.Size(203, 65);
            this.onvoldoende.TabIndex = 2;
            this.onvoldoende.Text = "onvoldoende";
            this.onvoldoende.UseVisualStyleBackColor = true;
            this.onvoldoende.Click += new System.EventHandler(this.onvoldoende_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "hoe ging de zamen werking";
            // 
            // beoordeling1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.onvoldoende);
            this.Controls.Add(this.voldoende);
            this.Controls.Add(this.goed);
            this.Name = "beoordeling1";
            this.Text = "beoordeling1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goed;
        private System.Windows.Forms.Button voldoende;
        private System.Windows.Forms.Button onvoldoende;
        private System.Windows.Forms.Label label1;
    }
}