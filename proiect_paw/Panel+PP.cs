using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Printing;
using System.Linq.Expressions;

namespace PROIECT_PAW_SFETCUA_1064_WF
{
    public partial class Panel_PP : Form
    {
        List<Camera> cameres = new List<Camera>();

        bool vb = false;

        Color culoare = Color.CornflowerBlue;
        Font font =new Font(FontFamily.GenericSerif,10);

        const int margine = 10;
        Graphics gr;

       PrintDocument pd=new PrintDocument();
       PrintPreviewDialog ppd=new PrintPreviewDialog();
        private object reportViewer1;

        public Panel_PP()

        {
            InitializeComponent();
           

            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
        }

        private void incarcaDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            BinaryFormatter bf = new BinaryFormatter();
                using (FileStream fs = new FileStream("camere.dat", FileMode.Open))
                {
                    cameres = (List<Camera>)bf.Deserialize(fs);
                    vb = true;
                }
                panel1.Invalidate();
            
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            gr= e.Graphics;
            if (vb)
            {
                Rectangle dreptRosu= new Rectangle(panel1.ClientRectangle.X+margine,
                      panel1.ClientRectangle.Y+2*margine,
                      panel1.ClientRectangle.Width-2*margine,
                      panel1.ClientRectangle.Height-3*margine);
                Pen pen=new Pen(Color.MidnightBlue,3);
                gr.DrawRectangle(pen,dreptRosu);

                double latime=dreptRosu.Width/cameres.Count/2;
                double distanta=(dreptRosu.Width-cameres.Count*latime)/(cameres.Count+1);
                double maxVal = cameres.Max(c => c.Pret);

                Brush br=new SolidBrush(culoare);
                Rectangle[]recs=new Rectangle[cameres.Count];

                for (int i = 0; i < cameres.Count; i++)
                {
                    double inaltime = cameres[i].Pret/maxVal*dreptRosu.Height;
                    recs[i] = new Rectangle(
                        (int)(dreptRosu.X + (i + 1) * distanta + i * latime),
                        (int)(dreptRosu.Y + dreptRosu.Height - inaltime),
                        (int)latime,
                        (int)inaltime);

                    gr.FillRectangle(br,recs[i]);

                    gr.DrawString(cameres[i].Pret.ToString(), font, Brushes.Black,
                        new Point((int)(recs[i].X + latime / 4), (int)(recs[i].Y - font.Height)));

                }

                for(int i = 0;i < cameres.Count-1;i++)
                {
                    gr.DrawLine(pen,
                        new Point((int)(recs[i].X + latime / 2), recs[i].Y),
                        new Point((int)(recs[i + 1].X + latime / 2), recs[i+1].Y));

                }
            }


        }

        private void schimbaCuloareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg=new ColorDialog();
            if(dlg.ShowDialog() == DialogResult.OK )
                culoare= dlg.Color;
            panel1.Invalidate();
        }

        private void schimbaFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg=new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                font = dlg.Font;
            panel1.Invalidate();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ppd.Document = pd;
                ppd.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la previzualizarea printării ");
            }
        }
        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            
                if (vb && cameres != null && cameres.Count > 0)
                {
                    Graphics gr = e.Graphics;

                    Rectangle dreptRosu = new Rectangle(50, 100, 700, 400);
                    Pen pen = new Pen(Color.Blue, 3);
                    gr.DrawRectangle(pen, dreptRosu);

                    double latime = dreptRosu.Width / cameres.Count / 2;
                    double distanta = (dreptRosu.Width - cameres.Count * latime) / (cameres.Count + 1);
                    double maxVal = cameres.Max(c => c.Pret);

                    Brush br = new SolidBrush(culoare);
                    Font fontPrint = new Font(FontFamily.GenericSerif, 12);
                    Rectangle[] recs = new Rectangle[cameres.Count];

                    for (int i = 0; i < cameres.Count; i++)
                    {
                        double inaltime = cameres[i].Pret / maxVal * dreptRosu.Height;
                        recs[i] = new Rectangle(
                            (int)(dreptRosu.X + (i + 1) * distanta + i * latime),
                            (int)(dreptRosu.Y + dreptRosu.Height - inaltime),
                            (int)latime,
                            (int)inaltime);

                        gr.FillRectangle(br, recs[i]);

                        gr.DrawString(cameres[i].Pret.ToString(), font, Brushes.Black,
                            new Point((int)(recs[i].X + latime / 4), (int)(recs[i].Y - font.Height)));

                    }

                    for (int i = 0; i < cameres.Count - 1; i++)
                    {
                        gr.DrawLine(pen,
                            new Point((int)(recs[i].X + latime / 2), recs[i].Y),
                            new Point((int)(recs[i + 1].X + latime / 2), recs[i + 1].Y));

                    }
                }
           
            
        }
     

     
        

    }
}

