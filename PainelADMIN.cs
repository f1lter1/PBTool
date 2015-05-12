using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class PainelADMIN : Form
    {
        public PainelADMIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Painel frm = new Painel();

            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CashAdmin frm = new CashAdmin();

            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExpAdmin frm = new ExpAdmin();

            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PatenteAdmin frm = new PatenteAdmin();

            frm.Show();
        }
    }
}
