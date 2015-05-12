using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.VisualStudio;
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class CashAdmin : Form
    {
        public CashAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                MySqlConnection conn = null;
                try
                {
                    string strConn = ConfigurationManager.ConnectionStrings["PainelConnection"].ToString();


                    conn = new MySqlConnection(strConn);
                    conn.Open();
                    //MessageBox.Show("Conexão estavel");
                    string mSQL = "Select * from accounts where login='" + textBox2.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(mSQL, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    reader.Read();

                    if (!reader.HasRows)
                    {
                        MessageBox.Show("Usuário inexistente!");
                    }
                    else
                    {
                        int money;
                        money = Convert.ToInt32(reader.GetValue(7).ToString());
                        money = money + Convert.ToInt32(textBox1.Text);
                        //MessageBox.Show(gp.ToString());

                        conn.Close(); conn.Open();

                        string saveSQL = "UPDATE accounts SET money=" + money + " WHERE money='" + textBox2.Text + "';";
                        MySqlCommand cmd2 = new MySqlCommand(saveSQL, conn);
                        cmd2.ExecuteNonQuery();

                        //MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                        //DataTable dt = new DataTable();
                        //da.Fill(dt); 
                        MessageBox.Show(textBox1.Text + " Cash Adicionado.");
                        //que?
                    }
                }
                catch (MySqlException msqle)
                {

                    MessageBox.Show("Erro de acesso ao MySQL : " + msqle.Message, "Erro");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void CashAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
