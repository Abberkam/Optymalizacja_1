namespace Opt_1
{
    partial class Form5
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
            this.textBox_proby = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_sigma = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_temperaturaKoncowa = new System.Windows.Forms.TextBox();
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
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_dlugosc12 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_dlugosc02 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Ile prób:";
            // 
            // textBox_proby
            // 
            this.textBox_proby.Location = new System.Drawing.Point(152, 135);
            this.textBox_proby.Name = "textBox_proby";
            this.textBox_proby.Size = new System.Drawing.Size(109, 20);
            this.textBox_proby.TabIndex = 58;
            this.textBox_proby.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_proby_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Sigma:";
            // 
            // textBox_sigma
            // 
            this.textBox_sigma.Location = new System.Drawing.Point(152, 174);
            this.textBox_sigma.Name = "textBox_sigma";
            this.textBox_sigma.Size = new System.Drawing.Size(109, 20);
            this.textBox_sigma.TabIndex = 56;
            this.textBox_sigma.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_sigma_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Temperatura końcowa:";
            // 
            // textBox_temperaturaKoncowa
            // 
            this.textBox_temperaturaKoncowa.Location = new System.Drawing.Point(15, 174);
            this.textBox_temperaturaKoncowa.Name = "textBox_temperaturaKoncowa";
            this.textBox_temperaturaKoncowa.Size = new System.Drawing.Size(109, 20);
            this.textBox_temperaturaKoncowa.TabIndex = 54;
            this.textBox_temperaturaKoncowa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_temperaturaKoncowa_KeyDown);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(13, 229);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 53;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Temperatura początkowa:";
            // 
            // textBox_temperatura
            // 
            this.textBox_temperatura.Location = new System.Drawing.Point(15, 133);
            this.textBox_temperatura.Name = "textBox_temperatura";
            this.textBox_temperatura.Size = new System.Drawing.Size(109, 20);
            this.textBox_temperatura.TabIndex = 51;
            this.textBox_temperatura.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_temperatura_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Długość:";
            // 
            // textBox_dlugosc1
            // 
            this.textBox_dlugosc1.Location = new System.Drawing.Point(152, 92);
            this.textBox_dlugosc1.Name = "textBox_dlugosc1";
            this.textBox_dlugosc1.Size = new System.Drawing.Size(109, 20);
            this.textBox_dlugosc1.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Długość:";
            // 
            // textBox_dlugosc0
            // 
            this.textBox_dlugosc0.Location = new System.Drawing.Point(152, 53);
            this.textBox_dlugosc0.Name = "textBox_dlugosc0";
            this.textBox_dlugosc0.Size = new System.Drawing.Size(109, 20);
            this.textBox_dlugosc0.TabIndex = 47;
            // 
            // btn_policz
            // 
            this.btn_policz.Location = new System.Drawing.Point(14, 200);
            this.btn_policz.Name = "btn_policz";
            this.btn_policz.Size = new System.Drawing.Size(75, 23);
            this.btn_policz.TabIndex = 46;
            this.btn_policz.Text = "Policz";
            this.btn_policz.UseVisualStyleBackColor = true;
            this.btn_policz.Click += new System.EventHandler(this.btn_policz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Trasa bieżąca:";
            // 
            // textBox_biezaca
            // 
            this.textBox_biezaca.Location = new System.Drawing.Point(15, 92);
            this.textBox_biezaca.Name = "textBox_biezaca";
            this.textBox_biezaca.Size = new System.Drawing.Size(109, 20);
            this.textBox_biezaca.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Trasa podstawowa:";
            // 
            // textBox_podstawowa
            // 
            this.textBox_podstawowa.Location = new System.Drawing.Point(15, 53);
            this.textBox_podstawowa.Name = "textBox_podstawowa";
            this.textBox_podstawowa.Size = new System.Drawing.Size(109, 20);
            this.textBox_podstawowa.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(286, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 67;
            this.label10.Text = "Długość:";
            // 
            // textBox_dlugosc12
            // 
            this.textBox_dlugosc12.Location = new System.Drawing.Point(289, 92);
            this.textBox_dlugosc12.Name = "textBox_dlugosc12";
            this.textBox_dlugosc12.Size = new System.Drawing.Size(109, 20);
            this.textBox_dlugosc12.TabIndex = 66;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(286, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 65;
            this.label11.Text = "Długość:";
            // 
            // textBox_dlugosc02
            // 
            this.textBox_dlugosc02.Location = new System.Drawing.Point(289, 53);
            this.textBox_dlugosc02.Name = "textBox_dlugosc02";
            this.textBox_dlugosc02.Size = new System.Drawing.Size(109, 20);
            this.textBox_dlugosc02.TabIndex = 64;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(286, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 69;
            this.label12.Text = "2 kierowca:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(149, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 68;
            this.label13.Text = "1 kierowca:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 263);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_dlugosc12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_dlugosc02);
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
            this.MaximumSize = new System.Drawing.Size(430, 301);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(430, 301);
            this.Name = "Form5";
            this.Text = "Symulowane wyżarzanie dla 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBox_proby;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textBox_sigma;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox textBox_temperaturaKoncowa;
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
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox textBox_dlugosc12;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox textBox_dlugosc02;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}