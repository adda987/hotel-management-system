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
    public partial class DRAG_DROP : Form
    {
        List<Oaspete> oaspeti = new List<Oaspete>();

        private bool cameraOcupata=false;
        
        public DRAG_DROP()
        {
            InitializeComponent();
            oaspeti.Add(new Oaspete(1010, 'M', "Matei", 30, new List<Rezervare>
            {
                new Rezervare(1, 3)

            }));

            oaspeti.Add(new Oaspete(1011, 'M', "Luca", 25, new List<Rezervare>
            {
                new Rezervare(3, 2)
            }));
            oaspeti.Add(new Oaspete(1012, 'M', "Ioan", 40, new List<Rezervare>()));

            foreach (Oaspete oaspete in oaspeti)
            {
                ListViewItem itm = new ListViewItem(oaspete.Cod.ToString());
                itm.SubItems.Add(oaspete.Sex.ToString());
                itm.SubItems.Add(oaspete.Nume);
                itm.SubItems.Add(oaspete.Varsta.ToString());

                string Text = "";
                foreach (Rezervare r in oaspete.Rezervare)
                {
                    Text += " Camera :" + r.Id + ",   Nopti:" + r.Durata + Environment.NewLine;
                }

                itm.SubItems.Add(Text);
                listView1.Items.Add(itm);
            }


            //PANEL
            panel1.BackgroundImageLayout=ImageLayout.Stretch;
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left &&
                !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.DoDragDrop(textBox1.Text, DragDropEffects.Copy);
            }

        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) ||
                e.Data.GetDataPresent(DataFormats.UnicodeText))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            string nume=(string)e.Data.GetData(DataFormats.Text);
            foreach(Oaspete o in oaspeti)
            {
                if(o.Nume.Equals(nume,StringComparison.OrdinalIgnoreCase))
                {
                    ListViewItem itm = new ListViewItem(o.Cod.ToString());
                    itm.SubItems.Add(o.Sex.ToString());
                    itm.SubItems.Add(o.Nume);
                    itm.SubItems.Add(o.Varsta.ToString());

                    string Text = "";
                    foreach (Rezervare r in o.Rezervare)
                    {
                        Text += " Camera :" + r.Id + ",   Nopti:" + r.Durata + Environment.NewLine;
                    }

                    itm.SubItems.Add(Text);
                    listView1.Items.Add(itm);
                    break;
                }

             
            }
        }

        //panel 
        private void DRAG_DROP_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode==Keys.V)
            {
                if(Clipboard.ContainsImage())
                {
                    panel1.BackgroundImage=Clipboard.GetImage();
                    panel1.BackgroundImageLayout=ImageLayout.Stretch;
                }
                else
                {
                    MessageBox.Show("Clipboardul nu contine o imagine");
                }
                e.Handled = true;
            }



        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect= DragDropEffects.None;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string nume = (string)e.Data.GetData(DataFormats.Text);

            if (panel1.Controls.Count>0 && cameraOcupata==true)
            {
                MessageBox.Show("Camera este ocupata.Va rugam sa asteptati!");
                return;
            }
            else
            {
                
                
                panel1.Controls.Clear();

                Label l1 = new Label
                {
                    Text = nume,
                    AutoSize = true,
                    BackColor = Color.Transparent,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    ForeColor = Color.Black,
                    Location = new Point(130, 10)
                };

                panel1.Controls.Add(l1);

                l1.MouseDown += panel1_MouseDown;

                MessageBox.Show("Oaspete cazat!");

                foreach (ListViewItem itm in listView1.Items)
                {
                    if (itm.SubItems[2].Text.Equals(nume,StringComparison.OrdinalIgnoreCase))
                    {
                        listView1.Items.Remove(itm);
                        break;
                    }
                }
                cameraOcupata = true;
            }
        }

        private void panel2_DragDrop(object sender, DragEventArgs e)
        {
            string nume=(string)e.Data.GetData(DataFormats.Text);

            Label l2 = new Label
            {
                Text = nume,
                AutoSize = true,
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                Location = new Point(130, 10)
            };
            panel2.Controls.Add(l2);

            
            MessageBox.Show("Oaspetele a plecat!");

           

            foreach (ListViewItem itm in listView1.Items)
            {
                if (itm.SubItems[2].Text.Equals(nume, StringComparison.OrdinalIgnoreCase))
                {
                    listView1.Items.Remove(itm);
                    break;
                }
            }

            panel2.Controls.Clear();
            cameraOcupata = false;
            panel1.Controls.Clear();
            
        }




        private void panel2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            ListViewItem itm=(ListViewItem)e.Item;
            string nume=itm.SubItems[2].Text;
            listView1.DoDragDrop(nume, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            Label l1 = sender as Label
                ?? (panel1.Controls.Count > 0 ? panel1.Controls[0] as Label : null);
             if (l1 == null) return;
            
                string nume=l1.Text;
                panel1.DoDragDrop(nume, DragDropEffects.Move);
            
        }

        private void dataOra1_Load(object sender, EventArgs e)
        {

        }
    }
}
