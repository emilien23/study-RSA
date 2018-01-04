namespace RSA
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_alg_ev = new System.Windows.Forms.Button();
            this.button_pow_mod = new System.Windows.Forms.Button();
            this.button_mil_rab = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.text_border = new System.Windows.Forms.TextBox();
            this.text_out = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.text_q_rsa = new System.Windows.Forms.TextBox();
            this.text_p_rsa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.text_d_rsa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_e_rsa = new System.Windows.Forms.TextBox();
            this.text_fi_rsa = new System.Windows.Forms.TextBox();
            this.text_len_rsa = new System.Windows.Forms.TextBox();
            this.text_n_rsa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_rsa_param = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_time_decrypto = new System.Windows.Forms.Label();
            this.label_time_encrypto = new System.Windows.Forms.Label();
            this.label_size_dec_file = new System.Windows.Forms.Label();
            this.label_size_enc_file = new System.Windows.Forms.Label();
            this.label_size_file = new System.Windows.Forms.Label();
            this.button_decrypto = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.text_file_encrypto = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.text_result_encrypto = new System.Windows.Forms.TextBox();
            this.text_len_block = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.text_file_decrypto = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.text_result_decrypto = new System.Windows.Forms.TextBox();
            this.text_path_encrypto = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.button_encrypto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_alg_ev
            // 
            this.button_alg_ev.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_alg_ev.Location = new System.Drawing.Point(305, 239);
            this.button_alg_ev.Name = "button_alg_ev";
            this.button_alg_ev.Size = new System.Drawing.Size(94, 51);
            this.button_alg_ev.TabIndex = 0;
            this.button_alg_ev.Text = "Расширенный алгоритм Евклида";
            this.button_alg_ev.UseVisualStyleBackColor = true;
            this.button_alg_ev.Click += new System.EventHandler(this.button_alg_ev_Click);
            // 
            // button_pow_mod
            // 
            this.button_pow_mod.Location = new System.Drawing.Point(433, 239);
            this.button_pow_mod.Name = "button_pow_mod";
            this.button_pow_mod.Size = new System.Drawing.Size(94, 51);
            this.button_pow_mod.TabIndex = 1;
            this.button_pow_mod.Text = "Возведение в степень по модулю";
            this.button_pow_mod.UseVisualStyleBackColor = true;
            this.button_pow_mod.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_mil_rab
            // 
            this.button_mil_rab.Location = new System.Drawing.Point(34, 140);
            this.button_mil_rab.Name = "button_mil_rab";
            this.button_mil_rab.Size = new System.Drawing.Size(97, 37);
            this.button_mil_rab.TabIndex = 2;
            this.button_mil_rab.Text = "Сгенерировать";
            this.button_mil_rab.UseVisualStyleBackColor = true;
            this.button_mil_rab.Click += new System.EventHandler(this.button_mil_rab_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.text_border);
            this.panel1.Controls.Add(this.text_out);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_mil_rab);
            this.panel1.Location = new System.Drawing.Point(305, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 221);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "> 1 000 000";
            // 
            // text_border
            // 
            this.text_border.Location = new System.Drawing.Point(15, 57);
            this.text_border.Name = "text_border";
            this.text_border.Size = new System.Drawing.Size(136, 20);
            this.text_border.TabIndex = 21;
            // 
            // text_out
            // 
            this.text_out.Location = new System.Drawing.Point(15, 102);
            this.text_out.Name = "text_out";
            this.text_out.ReadOnly = true;
            this.text_out.Size = new System.Drawing.Size(136, 20);
            this.text_out.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Граница";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Выходные данные";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Генерация простого числа";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.text_q_rsa);
            this.panel2.Controls.Add(this.text_p_rsa);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.text_d_rsa);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.text_e_rsa);
            this.panel2.Controls.Add(this.text_fi_rsa);
            this.panel2.Controls.Add(this.text_len_rsa);
            this.panel2.Controls.Add(this.text_n_rsa);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.button_rsa_param);
            this.panel2.Location = new System.Drawing.Point(550, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 385);
            this.panel2.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(49, 269);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Private key";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(49, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Public key";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "q";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "p";
            // 
            // text_q_rsa
            // 
            this.text_q_rsa.Location = new System.Drawing.Point(15, 140);
            this.text_q_rsa.Name = "text_q_rsa";
            this.text_q_rsa.ReadOnly = true;
            this.text_q_rsa.Size = new System.Drawing.Size(245, 20);
            this.text_q_rsa.TabIndex = 34;
            // 
            // text_p_rsa
            // 
            this.text_p_rsa.Location = new System.Drawing.Point(15, 101);
            this.text_p_rsa.Name = "text_p_rsa";
            this.text_p_rsa.ReadOnly = true;
            this.text_p_rsa.Size = new System.Drawing.Size(245, 20);
            this.text_p_rsa.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "d";
            // 
            // text_d_rsa
            // 
            this.text_d_rsa.Location = new System.Drawing.Point(15, 343);
            this.text_d_rsa.Name = "text_d_rsa";
            this.text_d_rsa.ReadOnly = true;
            this.text_d_rsa.Size = new System.Drawing.Size(234, 20);
            this.text_d_rsa.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "e";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "fi(n)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "n";
            // 
            // text_e_rsa
            // 
            this.text_e_rsa.Location = new System.Drawing.Point(15, 239);
            this.text_e_rsa.Name = "text_e_rsa";
            this.text_e_rsa.ReadOnly = true;
            this.text_e_rsa.Size = new System.Drawing.Size(234, 20);
            this.text_e_rsa.TabIndex = 27;
            // 
            // text_fi_rsa
            // 
            this.text_fi_rsa.Location = new System.Drawing.Point(15, 300);
            this.text_fi_rsa.Name = "text_fi_rsa";
            this.text_fi_rsa.ReadOnly = true;
            this.text_fi_rsa.Size = new System.Drawing.Size(234, 20);
            this.text_fi_rsa.TabIndex = 26;
            // 
            // text_len_rsa
            // 
            this.text_len_rsa.Location = new System.Drawing.Point(15, 57);
            this.text_len_rsa.Name = "text_len_rsa";
            this.text_len_rsa.Size = new System.Drawing.Size(136, 20);
            this.text_len_rsa.TabIndex = 21;
            // 
            // text_n_rsa
            // 
            this.text_n_rsa.Location = new System.Drawing.Point(15, 200);
            this.text_n_rsa.Name = "text_n_rsa";
            this.text_n_rsa.ReadOnly = true;
            this.text_n_rsa.Size = new System.Drawing.Size(234, 20);
            this.text_n_rsa.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Длина p и q в битах (<= 1024 бит)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(30, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Генерация параметров RSA";
            // 
            // button_rsa_param
            // 
            this.button_rsa_param.Location = new System.Drawing.Point(167, 57);
            this.button_rsa_param.Name = "button_rsa_param";
            this.button_rsa_param.Size = new System.Drawing.Size(93, 35);
            this.button_rsa_param.TabIndex = 2;
            this.button_rsa_param.Text = "Сгенерировать";
            this.button_rsa_param.UseVisualStyleBackColor = true;
            this.button_rsa_param.Click += new System.EventHandler(this.button_rsa_param_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label_time_decrypto);
            this.panel3.Controls.Add(this.label_time_encrypto);
            this.panel3.Controls.Add(this.label_size_dec_file);
            this.panel3.Controls.Add(this.label_size_enc_file);
            this.panel3.Controls.Add(this.label_size_file);
            this.panel3.Controls.Add(this.button_decrypto);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.text_file_encrypto);
            this.panel3.Controls.Add(this.label25);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.text_result_encrypto);
            this.panel3.Controls.Add(this.text_len_block);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.text_file_decrypto);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.text_result_decrypto);
            this.panel3.Controls.Add(this.text_path_encrypto);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.button_encrypto);
            this.panel3.Location = new System.Drawing.Point(12, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(276, 385);
            this.panel3.TabIndex = 5;
            // 
            // label_time_decrypto
            // 
            this.label_time_decrypto.AutoSize = true;
            this.label_time_decrypto.Location = new System.Drawing.Point(15, 365);
            this.label_time_decrypto.Name = "label_time_decrypto";
            this.label_time_decrypto.Size = new System.Drawing.Size(113, 13);
            this.label_time_decrypto.TabIndex = 47;
            this.label_time_decrypto.Text = "Затраченное время: ";
            // 
            // label_time_encrypto
            // 
            this.label_time_encrypto.AutoSize = true;
            this.label_time_encrypto.Location = new System.Drawing.Point(15, 223);
            this.label_time_encrypto.Name = "label_time_encrypto";
            this.label_time_encrypto.Size = new System.Drawing.Size(113, 13);
            this.label_time_encrypto.TabIndex = 46;
            this.label_time_encrypto.Text = "Затраченное время: ";
            // 
            // label_size_dec_file
            // 
            this.label_size_dec_file.AutoSize = true;
            this.label_size_dec_file.Location = new System.Drawing.Point(159, 330);
            this.label_size_dec_file.Name = "label_size_dec_file";
            this.label_size_dec_file.Size = new System.Drawing.Size(33, 13);
            this.label_size_dec_file.TabIndex = 45;
            this.label_size_dec_file.Text = "Size: ";
            // 
            // label_size_enc_file
            // 
            this.label_size_enc_file.AutoSize = true;
            this.label_size_enc_file.Location = new System.Drawing.Point(159, 183);
            this.label_size_enc_file.Name = "label_size_enc_file";
            this.label_size_enc_file.Size = new System.Drawing.Size(33, 13);
            this.label_size_enc_file.TabIndex = 44;
            this.label_size_enc_file.Text = "Size: ";
            // 
            // label_size_file
            // 
            this.label_size_file.AutoSize = true;
            this.label_size_file.Location = new System.Drawing.Point(159, 60);
            this.label_size_file.Name = "label_size_file";
            this.label_size_file.Size = new System.Drawing.Size(33, 13);
            this.label_size_file.TabIndex = 43;
            this.label_size_file.Text = "Size: ";
            // 
            // button_decrypto
            // 
            this.button_decrypto.Location = new System.Drawing.Point(169, 284);
            this.button_decrypto.Name = "button_decrypto";
            this.button_decrypto.Size = new System.Drawing.Size(93, 35);
            this.button_decrypto.TabIndex = 42;
            this.button_decrypto.Text = "Расшифровать";
            this.button_decrypto.UseVisualStyleBackColor = true;
            this.button_decrypto.Click += new System.EventHandler(this.button_decrypto_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 164);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(175, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "Зашифрованный файл с текстом";
            // 
            // text_file_encrypto
            // 
            this.text_file_encrypto.Location = new System.Drawing.Point(15, 180);
            this.text_file_encrypto.Name = "text_file_encrypto";
            this.text_file_encrypto.ReadOnly = true;
            this.text_file_encrypto.Size = new System.Drawing.Size(136, 20);
            this.text_file_encrypto.TabIndex = 40;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(85, 248);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(115, 17);
            this.label25.TabIndex = 39;
            this.label25.Text = "Дешифование";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 124);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = "Результат";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 86);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(146, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Длина блока шифра (<= 10)";
            // 
            // text_result_encrypto
            // 
            this.text_result_encrypto.Location = new System.Drawing.Point(15, 140);
            this.text_result_encrypto.Name = "text_result_encrypto";
            this.text_result_encrypto.ReadOnly = true;
            this.text_result_encrypto.Size = new System.Drawing.Size(136, 20);
            this.text_result_encrypto.TabIndex = 34;
            // 
            // text_len_block
            // 
            this.text_len_block.Location = new System.Drawing.Point(15, 101);
            this.text_len_block.Name = "text_len_block";
            this.text_len_block.Size = new System.Drawing.Size(136, 20);
            this.text_len_block.TabIndex = 33;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 311);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(124, 13);
            this.label19.TabIndex = 32;
            this.label19.Text = "Файл с расшифровкой";
            // 
            // text_file_decrypto
            // 
            this.text_file_decrypto.Location = new System.Drawing.Point(15, 327);
            this.text_file_decrypto.Name = "text_file_decrypto";
            this.text_file_decrypto.ReadOnly = true;
            this.text_file_decrypto.Size = new System.Drawing.Size(136, 20);
            this.text_file_decrypto.TabIndex = 31;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 269);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 13);
            this.label21.TabIndex = 29;
            this.label21.Text = "Результат";
            // 
            // text_result_decrypto
            // 
            this.text_result_decrypto.Location = new System.Drawing.Point(15, 285);
            this.text_result_decrypto.Name = "text_result_decrypto";
            this.text_result_decrypto.ReadOnly = true;
            this.text_result_decrypto.Size = new System.Drawing.Size(136, 20);
            this.text_result_decrypto.TabIndex = 26;
            // 
            // text_path_encrypto
            // 
            this.text_path_encrypto.Location = new System.Drawing.Point(15, 57);
            this.text_path_encrypto.Name = "text_path_encrypto";
            this.text_path_encrypto.Size = new System.Drawing.Size(136, 20);
            this.text_path_encrypto.TabIndex = 21;
            this.text_path_encrypto.Text = "C:/bible.txt";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 41);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(74, 13);
            this.label23.TabIndex = 23;
            this.label23.Text = "Путь к файлу";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(85, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(103, 17);
            this.label24.TabIndex = 3;
            this.label24.Text = "Шифрование";
            // 
            // button_encrypto
            // 
            this.button_encrypto.Location = new System.Drawing.Point(169, 113);
            this.button_encrypto.Name = "button_encrypto";
            this.button_encrypto.Size = new System.Drawing.Size(93, 35);
            this.button_encrypto.TabIndex = 2;
            this.button_encrypto.Text = "Зашифровать";
            this.button_encrypto.UseVisualStyleBackColor = true;
            this.button_encrypto.Click += new System.EventHandler(this.button_encrypto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 395);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_pow_mod);
            this.Controls.Add(this.button_alg_ev);
            this.Name = "Form1";
            this.Text = "RSA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_alg_ev;
        private System.Windows.Forms.Button button_pow_mod;
        private System.Windows.Forms.Button button_mil_rab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_border;
        private System.Windows.Forms.TextBox text_out;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_e_rsa;
        private System.Windows.Forms.TextBox text_fi_rsa;
        private System.Windows.Forms.TextBox text_len_rsa;
        private System.Windows.Forms.TextBox text_n_rsa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_rsa_param;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox text_q_rsa;
        private System.Windows.Forms.TextBox text_p_rsa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_d_rsa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_decrypto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox text_file_encrypto;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox text_result_encrypto;
        private System.Windows.Forms.TextBox text_len_block;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox text_file_decrypto;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox text_result_decrypto;
        private System.Windows.Forms.TextBox text_path_encrypto;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button_encrypto;
        private System.Windows.Forms.Label label_size_dec_file;
        private System.Windows.Forms.Label label_size_enc_file;
        private System.Windows.Forms.Label label_size_file;
        private System.Windows.Forms.Label label_time_decrypto;
        private System.Windows.Forms.Label label_time_encrypto;
    }
}

