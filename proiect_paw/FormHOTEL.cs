using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROIECT_PAW_SFETCUA_1064_WF
{
    public partial class FormHOTEL : Form
    {
        List<Hotel> listaHotel=new List<Hotel>();
        List<Camera> listaCamere = new List<Camera>();
        List<Oaspete> listaOaspeti = new List<Oaspete>();
        public FormHOTEL()
        {
            InitializeComponent();
            Hotel h = new Hotel(); // hotelul implicit „Hotel Andreea”
            listaHotel.Add(h);
        }

        private void inregistreazaOaspeteCuRezervareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formOASPETE frm = new formOASPETE(listaOaspeti);
            frm.Show();
        }

        private void adaugaCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCAMERA frm= new formCAMERA(listaCamere);
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNumeHotel.Text == "")
                errorProvider1.SetError(tbNumeHotel, "Introduceti numele hotelului!");
       
            else if (tbAdresaHotel.Text == "")
                errorProvider1.SetError(tbAdresaHotel, "Introduceti adresa hotelului!");
            else
            {
                errorProvider1.Clear();
                try
                {
                    string nume = Convert.ToString(tbNumeHotel.Text);
                    string adresa = Convert.ToString(tbAdresaHotel.Text);


                    Hotel h = new Hotel(nume,adresa, listaCamere, listaOaspeti);
                    
                    listaHotel.Add(h);
                    

                    MessageBox.Show(h.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbNumeHotel.Clear();
                    
                    tbAdresaHotel.Clear();
                    

                }
            }
        }

        
        private void vIZUALIZAREGENERALADATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TREEview frm = new TREEview(listaHotel,listaCamere,listaOaspeti);
            frm.Show();
        }

        private void dRAGDROPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DRAG_DROP form=new DRAG_DROP();
            form.Show();
        }

        private void FormHOTEL_Load(object sender, EventArgs e)
        {

        }

        private void dataOra1_Load(object sender, EventArgs e)
        {

        }
    }
}
