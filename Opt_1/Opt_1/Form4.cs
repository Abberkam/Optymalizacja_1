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
    public partial class Form4 : Form
    {
        double temperatura = 1000;
        double temperaturaKoncowa = 0.001;
        double sigma = 0.99;
        int proby = 1000;
        int metoda = 0;
        droga komi;
        public Form4(droga a)
        {
            InitializeComponent();
            komi = a;
            textBox_temperatura.Text = temperatura.ToString();
            textBox_temperaturaKoncowa.Text = temperaturaKoncowa.ToString();
            textBox_sigma.Text = sigma.ToString();
            textBox_proby.Text = proby.ToString();
            radioButton_ins.Checked = true;
        }

        private void textBox_temperatura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                temperatura = int.Parse(textBox_temperatura.Text);
            }
        }

        private void textBox_temperaturaKoncowa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                temperaturaKoncowa = int.Parse(textBox_temperaturaKoncowa.Text);
            }
        }

        private void btn_policz_Click(object sender, EventArgs e)
        {
            //textBox_dlugosc1.Text = komi.symulowaneWyzarzanie(komi.trasaBiezaca, temperatura, temperaturaKoncowa, sigma).ToString();
            //textBox_biezaca.Text = komi.wyswietlTrase(komi.trasaBiezaca);

            btn_policz.Enabled = false;
            btn_reset.Enabled = false;
            long tmp = komi.symulowaneWyzarzanie(komi.trasaBiezaca, temperatura, temperaturaKoncowa, sigma, metoda);
            long tmp2 = komi.symulowaneWyzarzanie(komi.trasaBiezaca, temperatura, temperaturaKoncowa, sigma, metoda);
            for (int i = 0; i < proby; i++)
            {
                if (tmp < tmp2)
                {
                    tmp2 = komi.symulowaneWyzarzanie(komi.trasaBiezaca, temperatura, temperaturaKoncowa, sigma, metoda);
                    textBox_dlugosc1.Text = tmp.ToString();
                }
                else
                {
                    tmp = komi.symulowaneWyzarzanie(komi.trasaBiezaca, temperatura, temperaturaKoncowa, sigma, metoda);
                    textBox_dlugosc1.Text = tmp2.ToString();
                }
            }
            textBox_biezaca.Text = komi.wyswietlTrase(komi.trasaNajkrotsza);
            btn_policz.Enabled = true;
            btn_reset.Enabled = true;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            komi.trasa.CopyTo(komi.trasaBiezaca, 0);
            textBox_biezaca.Text = komi.wyswietlTrase(komi.trasaBiezaca);
            textBox_dlugosc0.Text = komi.dlugoscTrasy(komi.trasa).ToString();
            textBox_dlugosc1.Text = komi.dlugoscTrasy(komi.trasaBiezaca).ToString();
            temperatura = 1000;
            temperaturaKoncowa = 0.001;
            sigma = 0.99;
            proby = 1000;
            textBox_temperatura.Text = temperatura.ToString();
            textBox_temperaturaKoncowa.Text = temperaturaKoncowa.ToString();
            textBox_sigma.Text = sigma.ToString();
            textBox_proby.Text = proby.ToString();
        }

        private void textBox_sigma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sigma = int.Parse(textBox_sigma.Text);
            }
        }

        private void textBox_proby_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                proby = int.Parse(textBox_proby.Text);
            }
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
    }
}
