using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.CodeDom;


namespace PROIECT_PAW_SFETCUA_1064_WF
{
    public partial class BazeDeDate : Form
    {
        string connString;

        public BazeDeDate()
        {
            InitializeComponent();
            connString = " Provider = Microsoft.ACE.OLEDB.12.0; Data Source=oaspeti.accdb";

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            listView1.Items.Clear();
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                // MessageBox.Show("Conexiune deschisa");
                OleDbCommand comanda = new OleDbCommand();
                comanda.CommandText = "SELECT * FROM oaspeti";
                comanda.Connection = conexiune;
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read()) {
                    ListViewItem itm = new ListViewItem(reader["COD"].ToString());
                    itm.SubItems.Add(reader["SEX"].ToString());
                    itm.SubItems.Add(reader["NUME"].ToString());
                    itm.SubItems.Add(reader["VARSTA"].ToString());

                    listView1.Items.Add(itm);
                }
                reader.Close();

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune=new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda=new OleDbCommand();
                comanda.Connection=conexiune;
                int cod = 0; 
                foreach(ListViewItem itm in listView1.Items) 
                    if(itm.Selected)
                        cod=Convert.ToInt32(itm.SubItems[0].Text);

                comanda.CommandText = "UPDATE oaspeti SET sex='"+
                    cbSex.Text+ "' WHERE cod = "+cod;
                comanda.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune=new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                int cod = 0;
                foreach (ListViewItem itm in listView1.Items)
                    if (itm.Checked)
                        cod = Convert.ToInt32(itm.SubItems[0].Text);
                comanda.CommandText = "DELETE FROM oaspeti WHERE cod=" + cod;
                comanda.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }


    }
}
