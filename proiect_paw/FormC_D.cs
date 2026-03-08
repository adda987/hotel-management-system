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
    public partial class FormC_D : Form
    {
        List<Oaspete> oaspeti = new List<Oaspete>();
        public FormC_D(List<Oaspete> listaO)
        {
            InitializeComponent();
            this.oaspeti = listaO;



            foreach (Oaspete oaspete in oaspeti)
            {
                ListViewItem itm = new ListViewItem(oaspete.Cod.ToString());
                itm.SubItems.Add(oaspete.Sex.ToString());
                itm.SubItems.Add(oaspete.Nume);
                itm.SubItems.Add(oaspete.Varsta.ToString());


                listView1.Items.Add(itm);
            }
        }

        private void listView2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listView2_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(typeof(ListViewItem)))
                return;

            
                
                    ListViewItem itmOriginal = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
                   ListViewItem itemClona=(ListViewItem)itmOriginal.Clone();
            listView2.Items.Add(itemClona);

            listView1.Items.Remove(itmOriginal);
                    
              
        }

        private void listView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            ListViewItem itm = (ListViewItem)e.Item;
            
            listView1.DoDragDrop(itm, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void stergereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView2.Items)
                if (itm.Selected == true)
                    itm.Remove();

        }
    }
}
