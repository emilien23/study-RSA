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
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace RSA
{

    public partial class Form1 : Form
    {

        Stopwatch sw = new Stopwatch();

        Controller control = new Controller();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_alg_ev_Click(object sender, EventArgs e)
        {
            AlgEv form = new AlgEv();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PowMod form = new PowMod();
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_mil_rab_Click(object sender, EventArgs e)
        {
            if (text_border.Text != "")
            {
                String border = text_border.Text;
                text_out.Text = control.generateSimple(BigInteger.Parse(border)).ToString();
            }
            else
                MessageBox.Show("Необходимо заполнить все поля");

        }

        private void button_rsa_param_Click(object sender, EventArgs e)
        {
            if (text_len_rsa.Text != "")
            {
                Double b = Double.Parse(text_len_rsa.Text);
                text_len_rsa.Text = Convert.ToString(Convert.ToInt32(b / BigInteger.Log(10)));
                BigInteger len = BigInteger.Pow(10, (Int32.Parse(text_len_rsa.Text)));

                BigInteger p = 1;
                BigInteger q = 1;
                while (p < len)
                    p = control.generateSimple(len * 10);
                while (q < len)
                    q = control.generateSimple(len * 10);


                text_p_rsa.Text = p.ToString();
                text_q_rsa.Text = q.ToString();
                BigInteger n = (p * q);
                text_n_rsa.Text = n.ToString();
                BigInteger fi = (p - 1) * (q - 1);
                text_fi_rsa.Text = fi.ToString();
                BigInteger e_rsa = control.generateE(fi);
                text_e_rsa.Text = e_rsa.ToString();

                BigInteger d = 0, y = 0;

                control.AlgEv(e_rsa, fi, ref d, ref y);

                if (d < 0)
                    d += fi;
                text_d_rsa.Text = d.ToString();
            }
            else
                MessageBox.Show("Необходимо заполнить длину p и q");
        }

        void readAndDecrypt()
        {
            sw.Start();
            List<BigInteger> blocksCipher = control.readCipherFile(text_file_encrypto.Text);
            control.decrypto(blocksCipher, "decrypto.txt", BigInteger.Parse(text_d_rsa.Text), BigInteger.Parse(text_n_rsa.Text));
            text_result_decrypto.Text = "Завершено";
            text_file_decrypto.Text = "decrypto.txt";
            button_decrypto.Enabled = true;
            FileInfo fileInfo = new FileInfo(text_file_decrypto.Text);
            label_size_dec_file.Text = "Size: " + (fileInfo.Length).ToString() + " байт";

            sw.Stop();
            label_time_decrypto.Text = "Затраченное время: " + ((sw.ElapsedMilliseconds / 1000.0).ToString()) + " сек";
            sw.Reset();
        }
        void readAndEncrypt()
        {
            sw.Start();

            List<String> blocksText = control.readTextFile(text_path_encrypto.Text, Int32.Parse(text_len_block.Text));
            List<BigInteger> blocksBigInt = control.encrypto(blocksText, BigInteger.Parse(text_e_rsa.Text), BigInteger.Parse(text_n_rsa.Text));
            control.writeCipherToFile(blocksBigInt, "crypto.txt");
            text_result_encrypto.Text = "Завершено";
            text_file_encrypto.Text = "crypto.txt";
            button_encrypto.Enabled = true;
            FileInfo fileInfo = new FileInfo(text_file_encrypto.Text);
            label_size_enc_file.Text = "Size: " + (fileInfo.Length).ToString() + " байт";

            sw.Stop();
            label_time_encrypto.Text = "Затраченное время: " + ((sw.ElapsedMilliseconds / 1000.0).ToString()) + " сек";
            sw.Reset();
        }
        private void button_encrypto_Click(object sender, EventArgs e)
        {
            if (text_p_rsa.Text != "" && text_q_rsa.Text != "" && text_path_encrypto.Text != "" && text_len_block.Text != "")
            {
                text_result_encrypto.Text = "В процессе..";
                FileInfo fileInfo = new FileInfo(text_path_encrypto.Text);
                label_size_file.Text = "Size: " + (fileInfo.Length).ToString() + " байт";
                button_encrypto.Enabled = false;
                Thread encryptThread = new Thread(readAndEncrypt);

                encryptThread.Start();
            }
            else
                MessageBox.Show("Необходимо сгенерировать параметры RSA, указать путь к файлу и длину блока шифра");
        }

        private void button_decrypto_Click(object sender, EventArgs e)
        {
            if (text_file_encrypto.Text != "" && text_d_rsa.Text != "" && text_n_rsa.Text != "")
            {
                text_result_decrypto.Text = "В процессе..";
                button_decrypto.Enabled = false;
                Thread decryptThread = new Thread(readAndDecrypt);

                decryptThread.Start();
            }
            else
                MessageBox.Show("Необходимо сгенерировать параметры RSA, указать путь к файлу и длину блока");
        }
    }
}

       