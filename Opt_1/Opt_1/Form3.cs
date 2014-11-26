using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opt_1
{
    public partial class Form3 : Form
    {
        public int powtarzaj = 1;
        private int metoda = 0;
        droga komi;
        public Form3(droga a)
        {
            InitializeComponent();
            textBox_ileRazy.Text = powtarzaj.ToString();
            komi = a;
            radioButton_swap.Checked = true;
        }

        private void textBox_ileRazy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                powtarzaj = int.Parse(textBox_ileRazy.Text);
            }
        }

        private void btn_policz_Click(object sender, EventArgs e)
        {
            textBox_dlugosc1.Text = komi.znajdzNajkrotszaTrase(komi.trasaBiezaca, powtarzaj, metoda).ToString();
            textBox_biezaca.Text = komi.wyswietlTrase(komi.trasaNajkrotsza);
        }

        private void radioButton_swap_CheckedChanged(object sender, EventArgs e)
        {
            metoda = 1;
        }

        private void radioButton_aswap_CheckedChanged(object sender, EventArgs e)
        {
            metoda = 2;
        }

        private void radioButton_ins_CheckedChanged(object sender, EventArgs e)
        {
            metoda = 3;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            komi.trasa.CopyTo(komi.trasaBiezaca, 0);
            textBox_biezaca.Text = komi.wyswietlTrase(komi.trasaBiezaca);
            textBox_dlugosc0.Text = komi.dlugoscTrasy(komi.trasa).ToString();
            textBox_dlugosc1.Text = komi.dlugoscTrasy(komi.trasaBiezaca).ToString();
        }
    }
}
