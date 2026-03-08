namespace PROIECT_PAW_SFETCUA_1064_WF
{
    partial class FormHOTEL
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHOTEL));
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumeHotel = new System.Windows.Forms.TextBox();
            this.tbAdresaHotel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adaugaCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inregistreazaOaspeteCuRezervareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIZUALIZAREGENERALADATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dRAGDROPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataOra1 = new PROIECT_PAW_SFETCUA_1064_WF.DataOra();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUME HOTEL: ";
            // 
            // tbNumeHotel
            // 
            this.tbNumeHotel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumeHotel.Location = new System.Drawing.Point(576, 233);
            this.tbNumeHotel.Name = "tbNumeHotel";
            this.tbNumeHotel.Size = new System.Drawing.Size(168, 34);
            this.tbNumeHotel.TabIndex = 1;
            // 
            // tbAdresaHotel
            // 
            this.tbAdresaHotel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdresaHotel.Location = new System.Drawing.Point(576, 309);
            this.tbAdresaHotel.Name = "tbAdresaHotel";
            this.tbAdresaHotel.Size = new System.Drawing.Size(168, 34);
            this.tbAdresaHotel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "ADRESA HOTEL:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaCameraToolStripMenuItem,
            this.inregistreazaOaspeteCuRezervareToolStripMenuItem,
            this.vIZUALIZAREGENERALADATEToolStripMenuItem,
            this.dRAGDROPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1025, 30);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adaugaCameraToolStripMenuItem
            // 
            this.adaugaCameraToolStripMenuItem.Name = "adaugaCameraToolStripMenuItem";
            this.adaugaCameraToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.adaugaCameraToolStripMenuItem.Text = "Adauga Camera";
            this.adaugaCameraToolStripMenuItem.Click += new System.EventHandler(this.adaugaCameraToolStripMenuItem_Click);
            // 
            // inregistreazaOaspeteCuRezervareToolStripMenuItem
            // 
            this.inregistreazaOaspeteCuRezervareToolStripMenuItem.Name = "inregistreazaOaspeteCuRezervareToolStripMenuItem";
            this.inregistreazaOaspeteCuRezervareToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.inregistreazaOaspeteCuRezervareToolStripMenuItem.Text = "Inregistreaza oaspete cu rezervare";
            this.inregistreazaOaspeteCuRezervareToolStripMenuItem.Click += new System.EventHandler(this.inregistreazaOaspeteCuRezervareToolStripMenuItem_Click);
            // 
            // vIZUALIZAREGENERALADATEToolStripMenuItem
            // 
            this.vIZUALIZAREGENERALADATEToolStripMenuItem.Name = "vIZUALIZAREGENERALADATEToolStripMenuItem";
            this.vIZUALIZAREGENERALADATEToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.vIZUALIZAREGENERALADATEToolStripMenuItem.Text = "VIZUALIZARE GENERALA DATE";
            this.vIZUALIZAREGENERALADATEToolStripMenuItem.Click += new System.EventHandler(this.vIZUALIZAREGENERALADATEToolStripMenuItem_Click);
            // 
            // dRAGDROPToolStripMenuItem
            // 
            this.dRAGDROPToolStripMenuItem.Name = "dRAGDROPToolStripMenuItem";
            this.dRAGDROPToolStripMenuItem.Size = new System.Drawing.Size(85, 26);
            this.dRAGDROPToolStripMenuItem.Text = "RECEPTIE";
            this.dRAGDROPToolStripMenuItem.Click += new System.EventHandler(this.dRAGDROPToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(371, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 89);
            this.button1.TabIndex = 5;
            this.button1.Text = "ADAUGA HOTEL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataOra1
            // 
            this.dataOra1.BackColor = System.Drawing.Color.Transparent;
            this.dataOra1.Location = new System.Drawing.Point(708, 521);
            this.dataOra1.Name = "dataOra1";
            this.dataOra1.Size = new System.Drawing.Size(257, 102);
            this.dataOra1.TabIndex = 6;
            this.dataOra1.Load += new System.EventHandler(this.dataOra1_Load);
            // 
            // FormHOTEL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1025, 635);
            this.Controls.Add(this.dataOra1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAdresaHotel);
            this.Controls.Add(this.tbNumeHotel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormHOTEL";
            this.Text = "FormHOTELcs";
            this.Load += new System.EventHandler(this.FormHOTEL_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumeHotel;
        private System.Windows.Forms.TextBox tbAdresaHotel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugaCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inregistreazaOaspeteCuRezervareToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem vIZUALIZAREGENERALADATEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dRAGDROPToolStripMenuItem;
        private DataOra dataOra1;
    }
}