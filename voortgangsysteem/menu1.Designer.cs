
namespace voortgangsysteem
{
    partial class menu1
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
            this.home = new System.Windows.Forms.Button();
            this.project_overzicht = new System.Windows.Forms.Button();
            this.project_toevoegen = new System.Windows.Forms.Button();
            this.beoordelingspagina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(208, 125);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(82, 42);
            this.home.TabIndex = 0;
            this.home.Text = "home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // project_overzicht
            // 
            this.project_overzicht.Location = new System.Drawing.Point(191, 201);
            this.project_overzicht.Name = "project_overzicht";
            this.project_overzicht.Size = new System.Drawing.Size(112, 34);
            this.project_overzicht.TabIndex = 1;
            this.project_overzicht.Text = "project_overzicht";
            this.project_overzicht.UseVisualStyleBackColor = true;
            this.project_overzicht.Click += new System.EventHandler(this.project_overzicht_Click);
            // 
            // project_toevoegen
            // 
            this.project_toevoegen.Location = new System.Drawing.Point(191, 271);
            this.project_toevoegen.Name = "project_toevoegen";
            this.project_toevoegen.Size = new System.Drawing.Size(110, 50);
            this.project_toevoegen.TabIndex = 2;
            this.project_toevoegen.Text = "project_toevoegen";
            this.project_toevoegen.UseVisualStyleBackColor = true;
            this.project_toevoegen.Click += new System.EventHandler(this.project_toevoegen_Click);
            // 
            // beoordelingspagina
            // 
            this.beoordelingspagina.Location = new System.Drawing.Point(191, 365);
            this.beoordelingspagina.Name = "beoordelingspagina";
            this.beoordelingspagina.Size = new System.Drawing.Size(99, 43);
            this.beoordelingspagina.TabIndex = 3;
            this.beoordelingspagina.Text = "beoordelingspagina";
            this.beoordelingspagina.UseVisualStyleBackColor = true;
            this.beoordelingspagina.Click += new System.EventHandler(this.beoordelingspagina_Click);
            // 
            // menu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.beoordelingspagina);
            this.Controls.Add(this.project_toevoegen);
            this.Controls.Add(this.project_overzicht);
            this.Controls.Add(this.home);
            this.Name = "menu1";
            this.Text = "menu1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button project_overzicht;
        private System.Windows.Forms.Button project_toevoegen;
        private System.Windows.Forms.Button beoordelingspagina;
    }
}