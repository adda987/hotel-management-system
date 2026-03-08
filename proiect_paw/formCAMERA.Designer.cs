namespace PROIECT_PAW_SFETCUA_1064_WF
{
    partial class formCAMERA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCAMERA));
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumar = new System.Windows.Forms.TextBox();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vizualizareDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pANELPretCamerepreeviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataOra1 = new PROIECT_PAW_SFETCUA_1064_WF.DataOra();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Număr cameră:";
            // 
            // tbNumar
            // 
            this.tbNumar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumar.Location = new System.Drawing.Point(276, 90);
            this.tbNumar.Name = "tbNumar";
            this.tbNumar.Size = new System.Drawing.Size(100, 34);
            this.tbNumar.TabIndex = 1;
            this.tbNumar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumar_KeyPress);
            // 
            // tbPret
            // 
            this.tbPret.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPret.Location = new System.Drawing.Point(276, 286);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(100, 34);
            this.tbPret.TabIndex = 2;
            this.tbPret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPret_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Preț cameră:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tip cameră:";
            // 
            // cbTip
            // 
            this.cbTip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Items.AddRange(new object[] {
            "Single ",
            "Double ",
            "Twin",
            "Family Room"});
            this.cbTip.Location = new System.Drawing.Point(276, 187);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(121, 36);
            this.cbTip.TabIndex = 5;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(225, 397);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(312, 127);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "ADAUGA CAMERA";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vizualizareDateToolStripMenuItem,
            this.pANELPretCamerepreeviewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(973, 30);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vizualizareDateToolStripMenuItem
            // 
            this.vizualizareDateToolStripMenuItem.Name = "vizualizareDateToolStripMenuItem";
            this.vizualizareDateToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.vizualizareDateToolStripMenuItem.Text = "Vizualizare camere ";
            this.vizualizareDateToolStripMenuItem.Click += new System.EventHandler(this.vizualizareDateToolStripMenuItem_Click);
            // 
            // pANELPretCamerepreeviewToolStripMenuItem
            // 
            this.pANELPretCamerepreeviewToolStripMenuItem.Name = "pANELPretCamerepreeviewToolStripMenuItem";
            this.pANELPretCamerepreeviewToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.pANELPretCamerepreeviewToolStripMenuItem.Text = "Vizualizare preturi camere";
            this.pANELPretCamerepreeviewToolStripMenuItem.Click += new System.EventHandler(this.pANELPretCamerepreeviewToolStripMenuItem_Click);
            // 
            // dataOra1
            // 
            this.dataOra1.BackColor = System.Drawing.Color.Transparent;
            this.dataOra1.Location = new System.Drawing.Point(680, 480);
            this.dataOra1.Name = "dataOra1";
            this.dataOra1.Size = new System.Drawing.Size(257, 102);
            this.dataOra1.TabIndex = 8;
            // 
            // formCAMERA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(973, 583);
            this.Controls.Add(this.dataOra1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.cbTip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.tbNumar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formCAMERA";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumar;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vizualizareDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pANELPretCamerepreeviewToolStripMenuItem;
        private DataOra dataOra1;
    }
}

