
namespace voortgangsysteem
{
    partial class beoordelingspagina
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
            this.button1 = new System.Windows.Forms.Button();
            this.beoordeling = new System.Windows.Forms.ListView();
            this.projecten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.samenwerking = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.standups = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reviews = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "home";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // beoordeling
            // 
            this.beoordeling.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.projecten,
            this.samenwerking,
            this.code,
            this.standups,
            this.reviews});
            this.beoordeling.HideSelection = false;
            this.beoordeling.Location = new System.Drawing.Point(12, 46);
            this.beoordeling.Name = "beoordeling";
            this.beoordeling.Size = new System.Drawing.Size(709, 364);
            this.beoordeling.TabIndex = 1;
            this.beoordeling.UseCompatibleStateImageBehavior = false;
            this.beoordeling.View = System.Windows.Forms.View.Details;
            this.beoordeling.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // projecten
            // 
            this.projecten.Text = "projecten";
            this.projecten.Width = 140;
            // 
            // samenwerking
            // 
            this.samenwerking.Text = "samenwerking";
            this.samenwerking.Width = 140;
            // 
            // code
            // 
            this.code.Text = "code";
            this.code.Width = 140;
            // 
            // standups
            // 
            this.standups.Text = "standups";
            this.standups.Width = 140;
            // 
            // reviews
            // 
            this.reviews.Text = "review";
            this.reviews.Width = 140;
            // 
            // beoordelingspagina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.beoordeling);
            this.Controls.Add(this.button1);
            this.Name = "beoordelingspagina";
            this.Text = "beoordelinsg pagina";
            this.Load += new System.EventHandler(this.beoordelingspagina_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView beoordeling;
        private System.Windows.Forms.ColumnHeader projecten;
        private System.Windows.Forms.ColumnHeader samenwerking;
        private System.Windows.Forms.ColumnHeader code;
        private System.Windows.Forms.ColumnHeader standups;
        private System.Windows.Forms.ColumnHeader reviews;
    }
}