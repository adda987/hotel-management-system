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
    public partial class TREEview : Form
    {
        List<Hotel> listaHoteluri;
        List<Camera> listaCamere;
        List<Oaspete> listaOaspeti;

        public TREEview(
            List<Hotel> listaHoteluri,
            List<Camera> listaCamere,
            List<Oaspete> listaOaspeti)
        {
            InitializeComponent();
            this.listaHoteluri = listaHoteluri;
            this.listaCamere = listaCamere;
            this.listaOaspeti = listaOaspeti;


            if (this.listaHoteluri.Count == 0)
            {
                Hotel h = new Hotel();
                this.listaHoteluri.Add(h);
            }
           
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();

            foreach (Hotel h in listaHoteluri)
            {
                TreeNode parinte = new TreeNode("HOTEL:" + h.Numele);
                treeView1.Nodes.Add(parinte);

                parinte.Nodes.Add("Adresa: " + h.Adresa);

                TreeNode copil = new TreeNode("CAMERE");
                foreach (Camera c in h.ListaC)
                {
                    TreeNode nepot = new TreeNode("Camera" + c.Numar);
                    nepot.Nodes.Add("Tip: " + c.Tip);
                    nepot.Nodes.Add("Pret: " + c.Pret + " lei");

                    copil.Nodes.Add(nepot); ;
                }
                parinte.Nodes.Add(copil);

                TreeNode oaspeti = new TreeNode("OASPETI");
                foreach (Oaspete o in h.ListaO)
                {
                    TreeNode oaspete = new TreeNode("Nume: " + o.Nume + " ,Varsta: " + o.Varsta);

                    foreach (Rezervare r in o.Rezervare)
                    {
                        oaspete.Nodes.Add(" ID Rezervare : " + r.Id + " ,Durata: " + r.Durata + " nopti");

                    }
                    oaspeti.Nodes.Add(oaspete);
                }
                parinte.Nodes.Add(oaspeti);

                parinte.Nodes.Add("TOTAL CAMERE: " + h.ListaC.Count + " | TOTAL OASPETI: " + h.ListaO.Count);

                treeView1.ExpandAll();
            }
        }
    }
}
