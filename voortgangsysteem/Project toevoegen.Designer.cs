
namespace voortgangsysteem
{
    partial class project_toevoegen
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectenoverzichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToevoegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(334, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Project Naam";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(334, 186);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Datum";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(334, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Opslaan";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Project Toevoegen";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.projectenoverzichtToolStripMenuItem,
            this.projectToevoegenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 40);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.AutoSize = false;
            this.homeToolStripMenuItem.Image = global::voortgangsysteem.Properties.Resources._2144;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(195, 28);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // projectenoverzichtToolStripMenuItem
            // 
            this.projectenoverzichtToolStripMenuItem.AutoSize = false;
            this.projectenoverzichtToolStripMenuItem.Image = global::voortgangsysteem.Properties.Resources._85c8e4cdc0b789da7933add412319134;
            this.projectenoverzichtToolStripMenuItem.Name = "projectenoverzichtToolStripMenuItem";
            this.projectenoverzichtToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.projectenoverzichtToolStripMenuItem.Text = "Projectenoverzicht";
            this.projectenoverzichtToolStripMenuItem.Click += new System.EventHandler(this.projectenoverzichtToolStripMenuItem_Click);
            // 
            // projectToevoegenToolStripMenuItem
            // 
            this.projectToevoegenToolStripMenuItem.AutoSize = false;
            this.projectToevoegenToolStripMenuItem.Image = global::voortgangsysteem.Properties.Resources._438a71db6962f35564e54b34835fd4cb;
            this.projectToevoegenToolStripMenuItem.Name = "projectToevoegenToolStripMenuItem";
            this.projectToevoegenToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.projectToevoegenToolStripMenuItem.Text = "Project Toevoegen";
            // 
            // project_toevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "project_toevoegen";
            this.Text = "project_toevoegen";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectenoverzichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToevoegenToolStripMenuItem;
    }
}