using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROIECT_PAW_SFETCUA_1064_WF
{
    public partial class formOASPETE : Form
    {
       List<Oaspete> listaOaspeti=new List<Oaspete>();
       List<Rezervare> listaRezervari= new List<Rezervare>();
    
        public formOASPETE(List<Oaspete>listaOaspeti)
        {
            InitializeComponent();
            this.listaOaspeti = listaOaspeti;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (tbCod.Text == "")
                errorProvider1.SetError(tbCod, "Introduceti codul oaspetelui!");

            else if (tbNume.Text == "")
                errorProvider1.SetError(tbNume, "Introduceti numele oaspetelui!");
        
            else if (tbVarsta.Text == "")
                errorProvider1.SetError(tbVarsta, "Introduceti varsta !");

            if (tbIdRezervare.Text == "")
                errorProvider1.SetError(tbIdRezervare, "Introduceti ID-ul rezervarii");

            if (tbDurata.Text == "")
                errorProvider1.SetError(tbDurata, "Introduceti durata rezervarii!");

            else
            {
                errorProvider1.Clear();
                try
                {
                    char sex = 'M';
                    if (radioButton1.Checked == true)
                        sex = 'M';
                    else
                        if (radioButton2.Checked == true)
                        sex = 'F';


                    int cod = Convert.ToInt32(tbCod.Text);
                    string nume = Convert.ToString(tbNume.Text);
                    int varsta = Convert.ToInt32(tbVarsta.Text);
                    int id = Convert.ToInt32(tbIdRezervare.Text);
                    int durata= Convert.ToInt32(tbDurata.Text);

                    Rezervare r = new Rezervare(id, durata);
                    Oaspete o = new Oaspete(cod, sex, nume, varsta, listaRezervari);
                   

                    listaOaspeti.Add(o);
                    listaRezervari.Add(r);

                    

                    MessageBox.Show(o.ToString());
                    listaRezervari.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbCod.Clear();
                    tbNume.Clear();
                    tbVarsta.Clear();
                    tbIdRezervare.Clear();
                    tbDurata.Clear();

                }
            }
        }

        private void tbCod_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
                e.Handled = false;
            else e.Handled = true;
        }

        private void tbVarsta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
                e.Handled = false;
            else e.Handled = true;
        }

        private void tbIdRezervare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
                e.Handled = false;
            else e.Handled = true;
        }

        private void tbDurata_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
                e.Handled = false;
            else e.Handled = true;
        }

        

        private void cAZĂRIȘIDECAZĂRIToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormC_D frm = new FormC_D(listaOaspeti);
            frm.ShowDialog();
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BazeDeDate frm= new BazeDeDate();   
            frm.ShowDialog();
        }
    }
}
