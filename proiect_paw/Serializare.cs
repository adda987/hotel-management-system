using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PROIECT_PAW_SFETCUA_1064_WF
{
    public partial class Serializare : Form
    {
        List<Camera> lista2;

       
        public Serializare(List<Camera> lista)
        {
            InitializeComponent();
            lista2 = lista;
            foreach (Camera c in lista)
                tbForm2.Text += c.ToString() + Environment.NewLine;

        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("fisier.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, lista2);
            tbForm2.Clear();
            fs.Close();

        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("fisier.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            List<Camera> listaDeserializata = (List<Camera>)bf.Deserialize(fs);
            foreach (Camera c in listaDeserializata)
                tbForm2.Text += c.ToString() + Environment.NewLine;
            fs.Close();

        }

        private void tbForm2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
