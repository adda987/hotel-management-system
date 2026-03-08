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

namespace PROIECT_PAW_SFETCUA_1064_WF
{
    public partial class formCAMERA : Form
    {
        List<Camera> listaCamere = new List<Camera>();

        public formCAMERA(List<Camera> listaCamere)
        {
            InitializeComponent();
            this.listaCamere = listaCamere;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (tbNumar.Text == "")
                errorProvider1.SetError(tbNumar, "Introduceti numarul camerei!");
            else if (cbTip.Text == "")
                errorProvider1.SetError(cbTip, "Selectati tipul!");
            else if (tbPret.Text == "")
                errorProvider1.SetError(tbPret, "Introduceti pretul!");
            else
            {
                errorProvider1.Clear();
                try
                {
                    int numar = Convert.ToInt32(tbNumar.Text);
                    string tip = Convert.ToString(cbTip.Text);
                    double pret = Convert.ToDouble(tbPret.Text);

                    Camera c = new Camera(numar, tip, pret);
                    listaCamere.Add(c);

                    SalveazaCamere(); 

                    MessageBox.Show(c.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbNumar.Clear();
                    cbTip.Text = "";
                    tbPret.Clear();

                }
            }

        }

        private void vizualizareDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serializare frm = new Serializare(listaCamere);
            frm.ShowDialog();

        }

        private void tbNumar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
                e.Handled = false;
            else e.Handled = true;
        }

        private void tbPret_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8 || e.KeyChar == '.')
                e.Handled = false;
            else e.Handled = true;
        }


        private void SalveazaCamere()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "camere.dat");

            try
            {
                

                FileStream fs = new FileStream(path, FileMode.Create,FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, listaCamere);
                fs.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvare camere: " + ex.Message);
            }

        }

        private void pANELPretCamerepreeviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Panel_PP frm = new Panel_PP();
            frm.ShowDialog();
        }
    }
}

    

