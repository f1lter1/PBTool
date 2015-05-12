using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();

            frm.Show();
        }

        private void index_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ids frm = new ids();

            frm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http:\\ragezone.com.br");   // Fórum
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http:\\migre.me/pHxUt");   // Skelleton
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PainelADMIN frm = new PainelADMIN();

            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Creditos frm = new Creditos();

            frm.Show();
        }
    }
}
