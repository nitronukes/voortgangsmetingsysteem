
namespace voortgangsysteem
{
    partial class home
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
            this.projectenListView = new System.Windows.Forms.ListView();
            this.Projectnaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Voortgang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projectToevoegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beoordelingspaginaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectenListView
            // 
            this.projectenListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Projectnaam,
            this.Datum,
            this.Voortgang});
            this.projectenListView.GridLines = true;
            this.projectenListView.HideSelection = false;
            this.projectenListView.Location = new System.Drawing.Point(232, 134);
            this.projectenListView.Name = "projectenListView";
            this.projectenListView.Size = new System.Drawing.Size(460, 245);
            this.projectenListView.TabIndex = 1;
            this.projectenListView.UseCompatibleStateImageBehavior = false;
            this.projectenListView.View = System.Windows.Forms.View.Details;
            // 
            // Projectnaam
            // 
            this.Projectnaam.Text = "Projectnaam";
            this.Projectnaam.Width = 150;
            // 
            // Datum
            // 
            this.Datum.Text = "Datum";
            // 
            // Voortgang
            // 
            this.Voortgang.Text = "Voortgang";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToevoegenToolStripMenuItem,
            this.beoordelingspaginaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1153, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projectToevoegenToolStripMenuItem
            // 
            this.projectToevoegenToolStripMenuItem.Name = "projectToevoegenToolStripMenuItem";
            this.projectToevoegenToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.projectToevoegenToolStripMenuItem.Text = "project toevoegen";
            this.projectToevoegenToolStripMenuItem.Click += new System.EventHandler(this.projectToevoegenToolStripMenuItem_Click);
            // 
            // beoordelingspaginaToolStripMenuItem
            // 
            this.beoordelingspaginaToolStripMenuItem.Name = "beoordelingspaginaToolStripMenuItem";
            this.beoordelingspaginaToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.beoordelingspaginaToolStripMenuItem.Text = "beoordelingspagina";
            this.beoordelingspaginaToolStripMenuItem.Click += new System.EventHandler(this.beoordelingspaginaToolStripMenuItem_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 450);
            this.Controls.Add(this.projectenListView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "home";
            this.Text = "home";
            this.Load += new System.EventHandler(this.Project_overzichtpagina_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView projectenListView;
        private System.Windows.Forms.ColumnHeader Projectnaam;
        private System.Windows.Forms.ColumnHeader Datum;
        private System.Windows.Forms.ColumnHeader Voortgang;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projectToevoegenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beoordelingspaginaToolStripMenuItem;
    }
}