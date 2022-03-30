
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.projectenListView.SelectedIndexChanged += new System.EventHandler(this.projectenListView_SelectedIndexChanged);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.projectenListView);
            this.Name = "home";
            this.Text = "home";
            this.Load += new System.EventHandler(this.Project_overzichtpagina_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView projectenListView;
        private System.Windows.Forms.ColumnHeader Projectnaam;
        private System.Windows.Forms.ColumnHeader Datum;
        private System.Windows.Forms.ColumnHeader Voortgang;
        private System.Windows.Forms.Button button1;
    }
}