namespace Opt_1
{
    partial class Form1
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
            this.btn_zaladuj = new System.Windows.Forms.Button();
            this.textBox_sciezka = new System.Windows.Forms.TextBox();
            this.textBox_zaladuj = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_wyswietl = new System.Windows.Forms.Button();
            this.btn_iteracyjna = new System.Windows.Forms.Button();
            this.btn_wyrzarzanie = new System.Windows.Forms.Button();
            this.bte_wyzarzanie2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_zaladuj
            // 
            this.btn_zaladuj.Location = new System.Drawing.Point(11, 53);
            this.btn_zaladuj.Name = "btn_zaladuj";
            this.btn_zaladuj.Size = new System.Drawing.Size(75, 23);
            this.btn_zaladuj.TabIndex = 0;
            this.btn_zaladuj.Text = "Wczytaj";
            this.btn_zaladuj.UseVisualStyleBackColor = true;
            this.btn_zaladuj.Click += new System.EventHandler(this.btn_zaladuj_Click);
            // 
            // textBox_sciezka
            // 
            this.textBox_sciezka.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_sciezka.Location = new System.Drawing.Point(12, 27);
            this.textBox_sciezka.Name = "textBox_sciezka";
            this.textBox_sciezka.Size = new System.Drawing.Size(341, 20);
            this.textBox_sciezka.TabIndex = 1;
            // 
            // textBox_zaladuj
            // 
            this.textBox_zaladuj.BackColor = System.Drawing.Color.Red;
            this.textBox_zaladuj.Location = new System.Drawing.Point(92, 56);
            this.textBox_zaladuj.Name = "textBox_zaladuj";
            this.textBox_zaladuj.Size = new System.Drawing.Size(20, 20);
            this.textBox_zaladuj.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(58, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz z pliku";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // btn_wyswietl
            // 
            this.btn_wyswietl.Location = new System.Drawing.Point(11, 82);
            this.btn_wyswietl.Name = "btn_wyswietl";
            this.btn_wyswietl.Size = new System.Drawing.Size(75, 23);
            this.btn_wyswietl.TabIndex = 5;
            this.btn_wyswietl.Text = "Wyświetl";
            this.btn_wyswietl.UseVisualStyleBackColor = true;
            this.btn_wyswietl.Click += new System.EventHandler(this.btn_wyswietl_Click);
            // 
            // btn_iteracyjna
            // 
            this.btn_iteracyjna.Location = new System.Drawing.Point(12, 111);
            this.btn_iteracyjna.Name = "btn_iteracyjna";
            this.btn_iteracyjna.Size = new System.Drawing.Size(75, 52);
            this.btn_iteracyjna.TabIndex = 6;
            this.btn_iteracyjna.Text = "Metoda\r\nIteracyjna";
            this.btn_iteracyjna.UseVisualStyleBackColor = true;
            this.btn_iteracyjna.Click += new System.EventHandler(this.btn_iteracyjna_Click);
            // 
            // btn_wyrzarzanie
            // 
            this.btn_wyrzarzanie.Location = new System.Drawing.Point(92, 111);
            this.btn_wyrzarzanie.Name = "btn_wyrzarzanie";
            this.btn_wyrzarzanie.Size = new System.Drawing.Size(75, 52);
            this.btn_wyrzarzanie.TabIndex = 7;
            this.btn_wyrzarzanie.Text = "Symulowane\r\nWyżarzanie";
            this.btn_wyrzarzanie.UseVisualStyleBackColor = true;
            this.btn_wyrzarzanie.Click += new System.EventHandler(this.btn_wyrzarzanie_Click);
            // 
            // bte_wyzarzanie2
            // 
            this.bte_wyzarzanie2.Location = new System.Drawing.Point(173, 111);
            this.bte_wyzarzanie2.Name = "bte_wyzarzanie2";
            this.bte_wyzarzanie2.Size = new System.Drawing.Size(75, 52);
            this.bte_wyzarzanie2.TabIndex = 8;
            this.bte_wyzarzanie2.Text = "Symulowane\r\nWyżarzanie\r\ndla 2";
            this.bte_wyzarzanie2.UseVisualStyleBackColor = true;
            this.bte_wyzarzanie2.Click += new System.EventHandler(this.btn_wyzarzanie2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 170);
            this.Controls.Add(this.bte_wyzarzanie2);
            this.Controls.Add(this.btn_wyrzarzanie);
            this.Controls.Add(this.btn_iteracyjna);
            this.Controls.Add(this.btn_wyswietl);
            this.Controls.Add(this.textBox_zaladuj);
            this.Controls.Add(this.textBox_sciezka);
            this.Controls.Add(this.btn_zaladuj);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(382, 208);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(382, 208);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_zaladuj;
        private System.Windows.Forms.TextBox textBox_sciezka;
        private System.Windows.Forms.TextBox textBox_zaladuj;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.Button btn_wyswietl;
        private System.Windows.Forms.Button btn_iteracyjna;
        private System.Windows.Forms.Button btn_wyrzarzanie;
        private System.Windows.Forms.Button bte_wyzarzanie2;
    }
}

