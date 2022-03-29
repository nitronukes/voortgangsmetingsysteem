
namespace voortgangsysteem
{
    partial class Project_overzichtpagina
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
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 40);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.AutoSize = false;
            this.homeToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
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
            // 
            // projectToevoegenToolStripMenuItem
            // 
            this.projectToevoegenToolStripMenuItem.AutoSize = false;
            this.projectToevoegenToolStripMenuItem.Image = global::voortgangsysteem.Properties.Resources._438a71db6962f35564e54b34835fd4cb;
            this.projectToevoegenToolStripMenuItem.Name = "projectToevoegenToolStripMenuItem";
            this.projectToevoegenToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.projectToevoegenToolStripMenuItem.Text = "Project Toevoegen";
            // 
            // Project_overzichtpagina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Project_overzichtpagina";
            this.Text = "Project_overzichtpagina";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectenoverzichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToevoegenToolStripMenuItem;
    }
}