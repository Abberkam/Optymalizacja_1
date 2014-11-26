namespace Opt_1
{
    partial class Form4
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
            this.btn_reset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_temperatura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_dlugosc1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_dlugosc0 = new System.Windows.Forms.TextBox();
            this.btn_policz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_biezaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_podstawowa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_temperaturaKoncowa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_sigma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_proby = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton_ins = new System.Windows.Forms.RadioButton();
            this.radioButton_aswap = new System.Windows.Forms.RadioButton();
            this.radioButton_swap = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(13, 201);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 31;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Temperatura początkowa:";
            // 
            // textBox_temperatura
            // 
            this.textBox_temperatura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_temperatura.Location = new System.Drawing.Point(15, 105);
            this.textBox_temperatura.Name = "textBox_temperatura";
            this.textBox_temperatura.Size = new System.Drawing.Size(109, 20);
            this.textBox_temperatura.TabIndex = 25;
            this.textBox_temperatura.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_temperatura_KeyDown);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Długość:";
            // 
            // textBox_dlugosc1
            // 
            this.textBox_dlugosc1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_dlugosc1.Location = new System.Drawing.Point(152, 64);
            this.textBox_dlugosc1.Name = "textBox_dlugosc1";
            this.textBox_dlugosc1.Size = new System.Drawing.Size(109, 20);
            this.textBox_dlugosc1.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Długość:";
            // 
            // textBox_dlugosc0
            // 
            this.textBox_dlugosc0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_dlugosc0.Location = new System.Drawing.Point(152, 25);
            this.textBox_dlugosc0.Name = "textBox_dlugosc0";
            this.textBox_dlugosc0.Size = new System.Drawing.Size(109, 20);
            this.textBox_dlugosc0.TabIndex = 21;
            // 
            // btn_policz
            // 
            this.btn_policz.Location = new System.Drawing.Point(14, 172);
            this.btn_policz.Name = "btn_policz";
            this.btn_policz.Size = new System.Drawing.Size(75, 23);
            this.btn_policz.TabIndex = 20;
            this.btn_policz.Text = "Policz";
            this.btn_policz.UseVisualStyleBackColor = true;
            this.btn_policz.Click += new System.EventHandler(this.btn_policz_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Trasa bieżąca:";
            // 
            // textBox_biezaca
            // 
            this.textBox_biezaca.Location = new System.Drawing.Point(15, 64);
            this.textBox_biezaca.Name = "textBox_biezaca";
            this.textBox_biezaca.Size = new System.Drawing.Size(109, 20);
            this.textBox_biezaca.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Trasa podstawowa:";
            // 
            // textBox_podstawowa
            // 
            this.textBox_podstawowa.Location = new System.Drawing.Point(15, 25);
            this.textBox_podstawowa.Name = "textBox_podstawowa";
            this.textBox_podstawowa.Size = new System.Drawing.Size(109, 20);
            this.textBox_podstawowa.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Temperatura końcowa:";
            // 
            // textBox_temperaturaKoncowa
            // 
            this.textBox_temperaturaKoncowa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_temperaturaKoncowa.Location = new System.Drawing.Point(15, 146);
            this.textBox_temperaturaKoncowa.Name = "textBox_temperaturaKoncowa";
            this.textBox_temperaturaKoncowa.Size = new System.Drawing.Size(109, 20);
            this.textBox_temperaturaKoncowa.TabIndex = 32;
            this.textBox_temperaturaKoncowa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_temperaturaKoncowa_KeyDown);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Sigma:";
            // 
            // textBox_sigma
            // 
            this.textBox_sigma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_sigma.Location = new System.Drawing.Point(152, 146);
            this.textBox_sigma.Name = "textBox_sigma";
            this.textBox_sigma.Size = new System.Drawing.Size(109, 20);
            this.textBox_sigma.TabIndex = 34;
            this.textBox_sigma.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_sigma_KeyDown);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Ile prób:";
            // 
            // textBox_proby
            // 
            this.textBox_proby.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_proby.Location = new System.Drawing.Point(152, 107);
            this.textBox_proby.Name = "textBox_proby";
            this.textBox_proby.Size = new System.Drawing.Size(109, 20);
            this.textBox_proby.TabIndex = 36;
            this.textBox_proby.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_proby_KeyDown);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(149, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Metoda:";
            // 
            // radioButton_ins
            // 
            this.radioButton_ins.AutoSize = true;
            this.radioButton_ins.Location = new System.Drawing.Point(152, 238);
            this.radioButton_ins.Name = "radioButton_ins";
            this.radioButton_ins.Size = new System.Drawing.Size(43, 17);
            this.radioButton_ins.TabIndex = 40;
            this.radioButton_ins.TabStop = true;
            this.radioButton_ins.Text = "INS";
            this.radioButton_ins.UseVisualStyleBackColor = true;
            // 
            // radioButton_aswap
            // 
            this.radioButton_aswap.AutoSize = true;
            this.radioButton_aswap.Location = new System.Drawing.Point(152, 215);
            this.radioButton_aswap.Name = "radioButton_aswap";
            this.radioButton_aswap.Size = new System.Drawing.Size(64, 17);
            this.radioButton_aswap.TabIndex = 39;
            this.radioButton_aswap.TabStop = true;
            this.radioButton_aswap.Text = "ASWAP";
            this.radioButton_aswap.UseVisualStyleBackColor = true;
            // 
            // radioButton_swap
            // 
            this.radioButton_swap.AutoSize = true;
            this.radioButton_swap.Location = new System.Drawing.Point(152, 192);
            this.radioButton_swap.Name = "radioButton_swap";
            this.radioButton_swap.Size = new System.Drawing.Size(57, 17);
            this.radioButton_swap.TabIndex = 38;
            this.radioButton_swap.TabStop = true;
            this.radioButton_swap.Text = "SWAP";
            this.radioButton_swap.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.radioButton_ins);
            this.Controls.Add(this.radioButton_aswap);
            this.Controls.Add(this.radioButton_swap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_proby);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_sigma);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_temperaturaKoncowa);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_temperatura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_dlugosc1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_dlugosc0);
            this.Controls.Add(this.btn_policz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_biezaca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_podstawowa);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form4";
            this.Text = "Symulowane wyżarzanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBox_temperatura;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox_dlugosc1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox_dlugosc0;
        private System.Windows.Forms.Button btn_policz;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox_biezaca;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox_podstawowa;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox textBox_temperaturaKoncowa;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textBox_sigma;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBox_proby;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButton_ins;
        private System.Windows.Forms.RadioButton radioButton_aswap;
        private System.Windows.Forms.RadioButton radioButton_swap;
    }
}