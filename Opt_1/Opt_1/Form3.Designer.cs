namespace Opt_1
{
    partial class Form3
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
            this.textBox_podstawowa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_biezaca = new System.Windows.Forms.TextBox();
            this.btn_policz = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_dlugosc1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_dlugosc0 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ileRazy = new System.Windows.Forms.TextBox();
            this.radioButton_swap = new System.Windows.Forms.RadioButton();
            this.radioButton_aswap = new System.Windows.Forms.RadioButton();
            this.radioButton_ins = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_podstawowa
            // 
            this.textBox_podstawowa.Location = new System.Drawing.Point(13, 25);
            this.textBox_podstawowa.Name = "textBox_podstawowa";
            this.textBox_podstawowa.Size = new System.Drawing.Size(109, 20);
            this.textBox_podstawowa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trasa podstawowa:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trasa bieżąca:";
            // 
            // textBox_biezaca
            // 
            this.textBox_biezaca.Location = new System.Drawing.Point(13, 64);
            this.textBox_biezaca.Name = "textBox_biezaca";
            this.textBox_biezaca.Size = new System.Drawing.Size(109, 20);
            this.textBox_biezaca.TabIndex = 2;
            // 
            // btn_policz
            // 
            this.btn_policz.Location = new System.Drawing.Point(13, 127);
            this.btn_policz.Name = "btn_policz";
            this.btn_policz.Size = new System.Drawing.Size(75, 23);
            this.btn_policz.TabIndex = 4;
            this.btn_policz.Text = "Policz";
            this.btn_policz.UseVisualStyleBackColor = true;
            this.btn_policz.Click += new System.EventHandler(this.btn_policz_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Długość:";
            // 
            // textBox_dlugosc1
            // 
            this.textBox_dlugosc1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_dlugosc1.Location = new System.Drawing.Point(150, 64);
            this.textBox_dlugosc1.Name = "textBox_dlugosc1";
            this.textBox_dlugosc1.Size = new System.Drawing.Size(109, 20);
            this.textBox_dlugosc1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Długość:";
            // 
            // textBox_dlugosc0
            // 
            this.textBox_dlugosc0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_dlugosc0.Location = new System.Drawing.Point(150, 25);
            this.textBox_dlugosc0.Name = "textBox_dlugosc0";
            this.textBox_dlugosc0.Size = new System.Drawing.Size(109, 20);
            this.textBox_dlugosc0.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ile razy:";
            // 
            // textBox_ileRazy
            // 
            this.textBox_ileRazy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ileRazy.Location = new System.Drawing.Point(13, 105);
            this.textBox_ileRazy.Name = "textBox_ileRazy";
            this.textBox_ileRazy.Size = new System.Drawing.Size(109, 20);
            this.textBox_ileRazy.TabIndex = 9;
            this.textBox_ileRazy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_ileRazy_KeyDown);
            // 
            // radioButton_swap
            // 
            this.radioButton_swap.AutoSize = true;
            this.radioButton_swap.Location = new System.Drawing.Point(150, 107);
            this.radioButton_swap.Name = "radioButton_swap";
            this.radioButton_swap.Size = new System.Drawing.Size(57, 17);
            this.radioButton_swap.TabIndex = 11;
            this.radioButton_swap.TabStop = true;
            this.radioButton_swap.Text = "SWAP";
            this.radioButton_swap.UseVisualStyleBackColor = true;
            this.radioButton_swap.CheckedChanged += new System.EventHandler(this.radioButton_swap_CheckedChanged);
            // 
            // radioButton_aswap
            // 
            this.radioButton_aswap.AutoSize = true;
            this.radioButton_aswap.Location = new System.Drawing.Point(150, 130);
            this.radioButton_aswap.Name = "radioButton_aswap";
            this.radioButton_aswap.Size = new System.Drawing.Size(64, 17);
            this.radioButton_aswap.TabIndex = 12;
            this.radioButton_aswap.TabStop = true;
            this.radioButton_aswap.Text = "ASWAP";
            this.radioButton_aswap.UseVisualStyleBackColor = true;
            this.radioButton_aswap.CheckedChanged += new System.EventHandler(this.radioButton_aswap_CheckedChanged);
            // 
            // radioButton_ins
            // 
            this.radioButton_ins.AutoSize = true;
            this.radioButton_ins.Location = new System.Drawing.Point(150, 153);
            this.radioButton_ins.Name = "radioButton_ins";
            this.radioButton_ins.Size = new System.Drawing.Size(43, 17);
            this.radioButton_ins.TabIndex = 13;
            this.radioButton_ins.TabStop = true;
            this.radioButton_ins.Text = "INS";
            this.radioButton_ins.UseVisualStyleBackColor = true;
            this.radioButton_ins.CheckedChanged += new System.EventHandler(this.radioButton_ins_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Metoda:";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(12, 156);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 15;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 192);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButton_ins);
            this.Controls.Add(this.radioButton_aswap);
            this.Controls.Add(this.radioButton_swap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_ileRazy);
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
            this.MaximumSize = new System.Drawing.Size(300, 230);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 230);
            this.Name = "Form3";
            this.Text = "Metoda iteracyjna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox_podstawowa;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox_biezaca;
        private System.Windows.Forms.Button btn_policz;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox_dlugosc1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox_dlugosc0;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBox_ileRazy;
        private System.Windows.Forms.RadioButton radioButton_swap;
        private System.Windows.Forms.RadioButton radioButton_aswap;
        private System.Windows.Forms.RadioButton radioButton_ins;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_reset;
    }
}