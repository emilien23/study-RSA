using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace RSA
{
    public partial class AlgEv : Form
    {
        Controller control;
        public AlgEv()
        {
            InitializeComponent();
            control = new Controller();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (text_a.Text != "" && text_b.Text != "")
            {
                String a = text_a.Text;
                String b = text_b.Text;
                BigInteger x = 0, y = 0;
                BigInteger d = control.AlgEv(BigInteger.Parse(a), BigInteger.Parse(b), ref x, ref y);
                text_x.Text = x.ToString();
                text_y.Text = y.ToString();
                text_d.Text = d.ToString();
            }
            else
                MessageBox.Show("Необходимо заполнить все поля");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void text_a_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_d_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_b_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_y_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void text_x_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
