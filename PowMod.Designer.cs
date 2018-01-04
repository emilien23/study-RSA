namespace RSA
{
    partial class PowMod
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_a = new System.Windows.Forms.TextBox();
            this.button_start = new System.Windows.Forms.Button();
            this.text_b = new System.Windows.Forms.TextBox();
            this.text_out = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_n = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(2, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Выходные данные";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(2, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Входные данные";
            // 
            // text_a
            // 
            this.text_a.Location = new System.Drawing.Point(19, 68);
            this.text_a.Name = "text_a";
            this.text_a.Size = new System.Drawing.Size(100, 20);
            this.text_a.TabIndex = 13;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(258, 143);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(100, 66);
            this.button_start.TabIndex = 21;
            this.button_start.Text = "Сгенерировать";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // text_b
            // 
            this.text_b.Location = new System.Drawing.Point(19, 111);
            this.text_b.Name = "text_b";
            this.text_b.Size = new System.Drawing.Size(100, 20);
            this.text_b.TabIndex = 14;
            // 
            // text_out
            // 
            this.text_out.Location = new System.Drawing.Point(19, 243);
            this.text_out.Name = "text_out";
            this.text_out.ReadOnly = true;
            this.text_out.Size = new System.Drawing.Size(100, 20);
            this.text_out.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "A";
            // 
            // text_n
            // 
            this.text_n.Location = new System.Drawing.Point(19, 156);
            this.text_n.Name = "text_n";
            this.text_n.Size = new System.Drawing.Size(100, 20);
            this.text_n.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "mod N";
            // 
            // PowMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 308);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_a);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.text_b);
            this.Controls.Add(this.text_out);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_n);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "PowMod";
            this.Text = "PowMod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_a;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.TextBox text_b;
        private System.Windows.Forms.TextBox text_out;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_n;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}