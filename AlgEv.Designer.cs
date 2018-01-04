namespace RSA
{
    partial class AlgEv
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.text_a = new System.Windows.Forms.TextBox();
            this.text_b = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_x = new System.Windows.Forms.TextBox();
            this.text_y = new System.Windows.Forms.TextBox();
            this.button_start = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.text_d = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // text_a
            // 
            this.text_a.Location = new System.Drawing.Point(29, 60);
            this.text_a.Name = "text_a";
            this.text_a.Size = new System.Drawing.Size(100, 20);
            this.text_a.TabIndex = 0;
            this.text_a.TextChanged += new System.EventHandler(this.text_a_TextChanged);
            // 
            // text_b
            // 
            this.text_b.Location = new System.Drawing.Point(29, 103);
            this.text_b.Name = "text_b";
            this.text_b.Size = new System.Drawing.Size(100, 20);
            this.text_b.TabIndex = 1;
            this.text_b.TextChanged += new System.EventHandler(this.text_b_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "A";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "B";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Y";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // text_x
            // 
            this.text_x.Location = new System.Drawing.Point(29, 204);
            this.text_x.Name = "text_x";
            this.text_x.ReadOnly = true;
            this.text_x.Size = new System.Drawing.Size(100, 20);
            this.text_x.TabIndex = 6;
            this.text_x.TextChanged += new System.EventHandler(this.text_x_TextChanged);
            // 
            // text_y
            // 
            this.text_y.Location = new System.Drawing.Point(29, 247);
            this.text_y.Name = "text_y";
            this.text_y.ReadOnly = true;
            this.text_y.Size = new System.Drawing.Size(100, 20);
            this.text_y.TabIndex = 7;
            this.text_y.TextChanged += new System.EventHandler(this.text_y_TextChanged);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(268, 135);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(100, 66);
            this.button_start.TabIndex = 8;
            this.button_start.Text = "Сгенерировать";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Входные данные";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Выходные данные";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(288, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "НОД";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // text_d
            // 
            this.text_d.Location = new System.Drawing.Point(268, 60);
            this.text_d.Name = "text_d";
            this.text_d.ReadOnly = true;
            this.text_d.Size = new System.Drawing.Size(100, 20);
            this.text_d.TabIndex = 12;
            this.text_d.TextChanged += new System.EventHandler(this.text_d_TextChanged);
            // 
            // AlgEv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(394, 304);
            this.Controls.Add(this.text_d);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_a);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.text_b);
            this.Controls.Add(this.text_y);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_x);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "AlgEv";
            this.Text = "AlgEv";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_a;
        private System.Windows.Forms.TextBox text_b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_x;
        private System.Windows.Forms.TextBox text_y;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_d;
    }
}