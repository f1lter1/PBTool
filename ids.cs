using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class ids : Form
    {
        List<string> riffles = new List<string>();

        public ids()
        {
            InitializeComponent();
        }

        private void ids_Load(object sender, EventArgs e)
        {
            carregaArmas();
        }
        private void carregaArmas()
        {
            MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["idsConnection"].ToString());
            try
            {
                con.Open();
                string loadSql = "SELECT * FROM ids";
                MySqlCommand cmd = new MySqlCommand(loadSql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //MessageBox.Show(reader.GetValue(3).ToString());
                    if (reader.GetValue(3).ToString() == "ALL")
                    {
                        cmbRiffle.Items.Add(reader.GetValue(1));
                        riffles.Add(reader.GetValue(2).ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro com MYSQL");
                ex.GetType();
            }
            finally
            {
                con.Close();
            }
        }
        private void getId(string tipo, ComboBox cmb)
        {
            if (tipo == "ALL")
            {
                int index = cmb.SelectedIndex;
                txtValor.Text = riffles.ElementAt(index);
            }
        }

        private void cmbRiffle_Click(object sender, EventArgs e)
        {

        }

        private void cmbRiffle_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbRiffle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ids_Load_1(object sender, EventArgs e)
        {
            carregaArmas();
        }

        private void cmbRiffle_TextChanged_1(object sender, EventArgs e)
        {
            getId("ALL", cmbRiffle);
        }
    }
}
