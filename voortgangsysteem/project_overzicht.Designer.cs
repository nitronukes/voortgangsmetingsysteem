
namespace voortgangsysteem
{
    partial class project_overzicht
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
            this.overzicht = new System.Windows.Forms.ListView();
            this.project = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.samenwerking = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.standup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.review = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // overzicht
            // 
            this.overzicht.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.project,
            this.samenwerking,
            this.code,
            this.standup,
            this.review});
            this.overzicht.GridLines = true;
            this.overzicht.HideSelection = false;
            this.overzicht.Location = new System.Drawing.Point(154, 91);
            this.overzicht.Name = "overzicht";
            this.overzicht.Size = new System.Drawing.Size(508, 249);
            this.overzicht.TabIndex = 1;
            this.overzicht.UseCompatibleStateImageBehavior = false;
            this.overzicht.View = System.Windows.Forms.View.Details;
            this.overzicht.SelectedIndexChanged += new System.EventHandler(this.Project_overzicht_load);
            // 
            // project
            // 
            this.project.Text = "project";
            // 
            // samenwerking
            // 
            this.samenwerking.Text = "samenwerking";
            // 
            // code
            // 
            this.code.Text = "code";
            // 
            // standup
            // 
            this.standup.Text = "standup";
            // 
            // review
            // 
            this.review.Text = "review";
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(12, 12);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(75, 34);
            this.home.TabIndex = 0;
            this.home.Text = "home";
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // project_overzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.home);
            this.Controls.Add(this.overzicht);
            this.Name = "project_overzicht";
            this.Text = "project_overzicht";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView overzicht;
        private System.Windows.Forms.ColumnHeader project;
        private System.Windows.Forms.ColumnHeader samenwerking;
        private System.Windows.Forms.ColumnHeader code;
        private System.Windows.Forms.ColumnHeader standup;
        private System.Windows.Forms.ColumnHeader review;
        private System.Windows.Forms.Button home;
    }
}