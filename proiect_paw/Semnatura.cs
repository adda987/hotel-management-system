using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROIECT_PAW_SFETCUA_1064_WF
{
    public partial class Semnatura : UserControl
    {

        private bool isDrawing = false;
        private Point lastPoint;

        private List<LineSegment> strokes = new List<LineSegment>();
        public Semnatura()
        {
            InitializeComponent();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                lastPoint = e.Location;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
                panel1.Invalidate();
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing && e.Button == MouseButtons.Left)
            {
                // Variante de desen:

                // === VARIANTA A: DESEN DIRECT FĂRĂ PERSISTENȚĂ ===
                // Desenezi imediat pe panel, dar nu se păstrează la repaint:
                using (Graphics g = panel1.CreateGraphics())
                {
                    g.DrawLine(Pens.Black, lastPoint, e.Location);
                }
                lastPoint = e.Location;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (strokes.Count > 0)
            {
                using (var pen = new Pen(Color.Black, 2))
                {
                    foreach (var seg in strokes)
                    {
                        e.Graphics.DrawLine(pen, seg.Start, seg.End);
                    }
                }
            }
        }

        private class LineSegment
        {
            public Point Start { get; set; }
            public Point End { get; set; }
        }
    }
}
