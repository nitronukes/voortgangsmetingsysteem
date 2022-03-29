
using System;

namespace voortgangsysteem
{
    partial class menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectenoverzichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToevoegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.projectov = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Location = new System.Drawing.Point(9, -1);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 40);
            this.menuStrip1.TabIndex = 2;
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
            this.projectenoverzichtToolStripMenuItem.Click += new System.EventHandler(this.projectenoverzichtToolStripMenuItem_Click_1);
            // 
            // projectToevoegenToolStripMenuItem
            // 
            this.projectToevoegenToolStripMenuItem.AutoSize = false;
            this.projectToevoegenToolStripMenuItem.Image = global::voortgangsysteem.Properties.Resources._438a71db6962f35564e54b34835fd4cb;
            this.projectToevoegenToolStripMenuItem.Name = "projectToevoegenToolStripMenuItem";
            this.projectToevoegenToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.projectToevoegenToolStripMenuItem.Text = "Project Toevoegen";
            this.projectToevoegenToolStripMenuItem.Click += new System.EventHandler(this.projectToevoegenToolStripMenuItem_Click_1);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 42);
            this.listView1.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.listView1.MinimumSize = new System.Drawing.Size(783, 412);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(783, 412);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.projectov.Location = new System.Drawing.Point(58, 98);
            this.projectov.Name = "projectov";
            this.projectov.Size = new System.Drawing.Size(193, 24);
            this.projectov.TabIndex = 4;
            this.projectov.Text = "home";
            this.projectov.UseVisualStyleBackColor = true;
            this.projectov.Click += new System.EventHandler(this.projectov_Click);
            this.button2.Location = new System.Drawing.Point(59, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 55);
            this.button2.TabIndex = 6;
            this.button2.Text = "beoordelings pagina";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "project toevoegen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // projectov
            // 
            this.projectov.Location = new System.Drawing.Point(58, 98);
            this.projectov.Name = "projectov";
            this.projectov.Size = new System.Drawing.Size(193, 24);
            this.projectov.TabIndex = 4;
            this.projectov.Text = "projecten overzicht";
            this.projectov.UseVisualStyleBackColor = true;
            this.projectov.Click += new System.EventHandler(this.projectov_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(57, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 78);
            this.button3.TabIndex = 7;
            this.button3.Text = "project overzicht";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.projectov);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "menu";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void projectenoverzichtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Project_overzichtpagina po = new Project_overzichtpagina();
            po.Show();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectenoverzichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToevoegenToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button projectov;
    }
}

