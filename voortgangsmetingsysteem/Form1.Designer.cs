﻿
namespace voortgangsmetingsysteem
{
    partial class Form1
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
            this.brs = new System.Windows.Forms.Label();
            this.knop1 = new System.Windows.Forms.Button();
            this.walrus = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.voltooien = new System.Windows.Forms.Label();
            this.projecten = new System.Windows.Forms.Label();
            this.urs = new System.Windows.Forms.Label();
            this.ccs = new System.Windows.Forms.Label();
            this.datum = new System.Windows.Forms.Label();
            this.percentage1 = new System.Windows.Forms.Label();
            this.percentage2 = new System.Windows.Forms.Label();
            this.percentage3 = new System.Windows.Forms.Label();
            this.percentage4 = new System.Windows.Forms.Label();
            this.knop2 = new System.Windows.Forms.Button();
            this.knop3 = new System.Windows.Forms.Button();
            this.knop4 = new System.Windows.Forms.Button();
            this.Paginatitel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // brs
            // 
            this.brs.AutoSize = true;
            this.brs.Location = new System.Drawing.Point(3, 69);
            this.brs.Name = "brs";
            this.brs.Size = new System.Drawing.Size(147, 17);
            this.brs.TabIndex = 0;
            this.brs.Text = "bierregistratiesysteem";
            this.brs.Click += new System.EventHandler(this.label1_Click);
            // 
            // knop1
            // 
            this.knop1.Location = new System.Drawing.Point(679, 223);
            this.knop1.Name = "knop1";
            this.knop1.Size = new System.Drawing.Size(95, 23);
            this.knop1.TabIndex = 1;
            this.knop1.Text = "voltooid✅";
            this.knop1.UseVisualStyleBackColor = true;
            this.knop1.Click += new System.EventHandler(this.knop1_Click);
            // 
            // walrus
            // 
            this.walrus.AutoSize = true;
            this.walrus.Location = new System.Drawing.Point(3, 20);
            this.walrus.Name = "walrus";
            this.walrus.Size = new System.Drawing.Size(48, 17);
            this.walrus.TabIndex = 3;
            this.walrus.Text = "walrus";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.voltooien, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.projecten, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.brs, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.walrus, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.datum, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.percentage1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.percentage2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.percentage3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.percentage4, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.urs, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ccs, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(116, 188);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(557, 217);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // voltooien
            // 
            this.voltooien.AutoSize = true;
            this.voltooien.Location = new System.Drawing.Point(448, 0);
            this.voltooien.Name = "voltooien";
            this.voltooien.Size = new System.Drawing.Size(65, 17);
            this.voltooien.TabIndex = 5;
            this.voltooien.Text = "voltooien";
            // 
            // projecten
            // 
            this.projecten.AutoSize = true;
            this.projecten.Location = new System.Drawing.Point(3, 0);
            this.projecten.Name = "projecten";
            this.projecten.Size = new System.Drawing.Size(67, 17);
            this.projecten.TabIndex = 5;
            this.projecten.Text = "projecten";
            // 
            // urs
            // 
            this.urs.AutoSize = true;
            this.urs.Location = new System.Drawing.Point(3, 118);
            this.urs.Name = "urs";
            this.urs.Size = new System.Drawing.Size(165, 17);
            this.urs.TabIndex = 5;
            this.urs.Text = "uitleenregistratiesysteem";
            // 
            // ccs
            // 
            this.ccs.AutoSize = true;
            this.ccs.Location = new System.Drawing.Point(3, 167);
            this.ccs.Name = "ccs";
            this.ccs.Size = new System.Drawing.Size(29, 17);
            this.ccs.TabIndex = 6;
            this.ccs.Text = "ccs";
            // 
            // datum
            // 
            this.datum.AutoSize = true;
            this.datum.Location = new System.Drawing.Point(337, 0);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(47, 17);
            this.datum.TabIndex = 5;
            this.datum.Text = "datum";
            // 
            // percentage1
            // 
            this.homepageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.p_toevoegen,
            this.overzicht});
            this.homepageToolStripMenuItem.Name = "homepageToolStripMenuItem";
            this.homepageToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.homepageToolStripMenuItem.Text = "menu";
            this.homepageToolStripMenuItem.Click += new System.EventHandler(this.homepageToolStripMenuItem_Click);
            // 
            // p_toevoegen
            // 
            this.p_toevoegen.Name = "p_toevoegen";
            this.p_toevoegen.Size = new System.Drawing.Size(224, 26);
            this.p_toevoegen.Text = "project toevoegen";
            // 
            // overzicht
            // 
            this.overzicht.Name = "overzicht";
            this.overzicht.Size = new System.Drawing.Size(224, 26);
            this.overzicht.Text = "overzicht";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homepageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // knop2
            // 
            this.knop2.Location = new System.Drawing.Point(679, 273);
            this.knop2.Name = "knop2";
            this.knop2.Size = new System.Drawing.Size(95, 23);
            this.knop2.TabIndex = 5;
            this.knop2.Text = "voltooid✅";
            this.knop2.UseVisualStyleBackColor = true;
            this.knop2.Click += new System.EventHandler(this.knop2_Click);
            // 
            // knop3
            // 
            this.knop3.Location = new System.Drawing.Point(679, 320);
            this.knop3.Name = "knop3";
            this.knop3.Size = new System.Drawing.Size(95, 23);
            this.knop3.TabIndex = 6;
            this.knop3.Text = "voltooid✅";
            this.knop3.UseVisualStyleBackColor = true;
            // 
            // knop4
            // 
            this.knop4.Location = new System.Drawing.Point(679, 368);
            this.knop4.Name = "knop4";
            this.knop4.Size = new System.Drawing.Size(95, 23);
            this.knop4.TabIndex = 7;
            this.knop4.Text = "voltooid✅";
            this.knop4.UseVisualStyleBackColor = true;
            // 
            // Paginatitel
            // 
            this.Paginatitel.AutoSize = true;
            this.Paginatitel.Location = new System.Drawing.Point(359, 9);
            this.Paginatitel.Name = "Paginatitel";
            this.Paginatitel.Size = new System.Drawing.Size(68, 17);
            this.Paginatitel.TabIndex = 10;
            this.Paginatitel.Text = "Projecten";
            this.Paginatitel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Paginatitel);
            this.Controls.Add(this.knop4);
            this.Controls.Add(this.knop3);
            this.Controls.Add(this.knop2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.knop1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label brs;
        private System.Windows.Forms.Button knop1;
        private System.Windows.Forms.Label walrus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label urs;
        private System.Windows.Forms.Label ccs;
        private System.Windows.Forms.Label projecten;
        private System.Windows.Forms.Label voltooien;
        private System.Windows.Forms.Label datum;
        private System.Windows.Forms.Button knop2;
        private System.Windows.Forms.Button knop3;
        private System.Windows.Forms.Button knop4;
        private System.Windows.Forms.Label percentage1;
        private System.Windows.Forms.Label percentage2;
        private System.Windows.Forms.Label percentage3;
        private System.Windows.Forms.Label percentage4;
        private System.Windows.Forms.Label Paginatitel;
    }
}

