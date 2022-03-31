
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("walrus");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("ccs");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("uitleensysteem");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("bier");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            this.button1 = new System.Windows.Forms.Button();
            this.beoordeling = new System.Windows.Forms.ListView();
            this.projecten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.samenwerking = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.standups = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reviews = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vpt = new System.Windows.Forms.Button();
            this.v3 = new System.Windows.Forms.Button();
            this.v2 = new System.Windows.Forms.Button();
            this.v1 = new System.Windows.Forms.Button();
            this.v4 = new System.Windows.Forms.Button();
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // beoordeling
            // 
            this.beoordeling.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.projecten,
            this.samenwerking,
            this.code,
            this.standups,
            this.reviews});
            this.beoordeling.GridLines = true;
            this.beoordeling.HideSelection = false;
            this.beoordeling.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.beoordeling.Location = new System.Drawing.Point(12, 46);
            this.beoordeling.Margin = new System.Windows.Forms.Padding(13);
            this.beoordeling.MinimumSize = new System.Drawing.Size(10, 10);
            this.beoordeling.Name = "beoordeling";
            this.beoordeling.Size = new System.Drawing.Size(706, 158);
            this.beoordeling.TabIndex = 1;
            this.beoordeling.TileSize = new System.Drawing.Size(1, 1);
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
            // vpt
            // 
            this.vpt.Location = new System.Drawing.Point(12, 166);
            this.vpt.Name = "vpt";
            this.vpt.Size = new System.Drawing.Size(143, 38);
            this.vpt.TabIndex = 2;
            this.vpt.Text = "voeg project toe";
            this.vpt.UseVisualStyleBackColor = true;
            this.vpt.Click += new System.EventHandler(this.vpt_Click);
            // 
            // v3
            // 
            this.v3.Location = new System.Drawing.Point(719, 109);
            this.v3.Name = "v3";
            this.v3.Size = new System.Drawing.Size(25, 22);
            this.v3.TabIndex = 4;
            this.v3.Text = "V";
            this.v3.UseVisualStyleBackColor = true;
            this.v3.Click += new System.EventHandler(this.v3_Click);
            // 
            // v2
            // 
            this.v2.Location = new System.Drawing.Point(719, 90);
            this.v2.Name = "v2";
            this.v2.Size = new System.Drawing.Size(25, 22);
            this.v2.TabIndex = 5;
            this.v2.Text = "V";
            this.v2.UseVisualStyleBackColor = true;
            this.v2.Click += new System.EventHandler(this.v2_Click);
            // 
            // v1
            // 
            this.v1.Location = new System.Drawing.Point(719, 72);
            this.v1.Name = "v1";
            this.v1.Size = new System.Drawing.Size(25, 22);
            this.v1.TabIndex = 6;
            this.v1.Text = "V";
            this.v1.UseVisualStyleBackColor = true;
            this.v1.Click += new System.EventHandler(this.v1_Click);
            // 
            // v4
            // 
            this.v4.Location = new System.Drawing.Point(719, 127);
            this.v4.Name = "v4";
            this.v4.Size = new System.Drawing.Size(25, 22);
            this.v4.TabIndex = 7;
            this.v4.Text = "V";
            this.v4.UseVisualStyleBackColor = true;
            this.v4.Click += new System.EventHandler(this.v4_Click);
            // 
            // beoordelingspagina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.v4);
            this.Controls.Add(this.v1);
            this.Controls.Add(this.v2);
            this.Controls.Add(this.v3);
            this.Controls.Add(this.vpt);
            this.Controls.Add(this.beoordeling);
            this.Controls.Add(this.button1);
            this.Name = "beoordelingspagina";
            this.Text = "beoordelinsg pagina";
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
        private System.Windows.Forms.Button vpt;
        private System.Windows.Forms.Button v3;
        private System.Windows.Forms.Button v2;
        private System.Windows.Forms.Button v1;
        private System.Windows.Forms.Button v4;
    }
}