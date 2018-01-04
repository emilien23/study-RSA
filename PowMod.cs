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
    public partial class PowMod : Form
    {
        Controller control = new Controller();
        public PowMod()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (text_a.Text != "" && text_b.Text != "" & text_n.Text != "")
            {
                String a = text_a.Text;
                String b = text_b.Text;
                String n = text_n.Text;
                
                text_out.Text = control.fastPow(BigInteger.Parse(a), BigInteger.Parse(b), BigInteger.Parse(n)).ToString();

            }
            else
                MessageBox.Show("Необходимо заполнить все поля");
        }
    }
}
