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
    public partial class Form5 : Form
    {
        double temperatura = 1000;
        double temperaturaKoncowa = 0.001;
        double sigma = 0.99;
        int proby = 1000;
        droga komi;
        public Form5(droga a)
        {
            InitializeComponent();
            komi = a;
            textBox_temperatura.Text = temperatura.ToString();
            textBox_temperaturaKoncowa.Text = temperaturaKoncowa.ToString();
            textBox_sigma.Text = sigma.ToString();
            textBox_proby.Text = proby.ToString();
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
            long[] tmp = komi.symulowaneWyzarzanie2(komi.trasaDlaDwochBiezaca, temperatura, temperaturaKoncowa, sigma);
            long[] tmp2 = komi.symulowaneWyzarzanie2(komi.trasaDlaDwochBiezaca, temperatura, temperaturaKoncowa, sigma);
            for (int i = 0; i < proby; i++)
            {
                if (tmp[0] < tmp2[0])
                {
                    tmp2 = komi.symulowaneWyzarzanie2(komi.trasaDlaDwochBiezaca, temperatura, temperaturaKoncowa, sigma);
                    textBox_dlugosc1.Text = tmp.ToString();
                }
                else
                {
                    tmp = komi.symulowaneWyzarzanie2(komi.trasaDlaDwochBiezaca, temperatura, temperaturaKoncowa, sigma);
                    textBox_dlugosc1.Text = tmp2.ToString();
                }
            }
            textBox_biezaca.Text = komi.wyswietlTrase(komi.trasaDlaDwochNajkrotsza);
            textBox_dlugosc1.Text = komi.dlugoscTrasy2(komi.trasaDlaDwochNajkrotsza)[0].ToString();
            textBox_dlugosc12.Text = komi.dlugoscTrasy2(komi.trasaDlaDwochNajkrotsza)[1].ToString();
            btn_policz.Enabled = true;
            btn_reset.Enabled = true;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            komi.trasaDlaDwoch.CopyTo(komi.trasaDlaDwochBiezaca, 0);
            textBox_biezaca.Text = komi.wyswietlTrase(komi.trasaDlaDwochBiezaca);
            textBox_dlugosc0.Text = komi.dlugoscTrasy2(komi.trasaDlaDwoch)[0].ToString();
            textBox_dlugosc02.Text = komi.dlugoscTrasy2(komi.trasaDlaDwoch)[1].ToString();
            textBox_dlugosc1.Text = komi.dlugoscTrasy2(komi.trasaDlaDwochBiezaca)[0].ToString();
            textBox_dlugosc12.Text = komi.dlugoscTrasy2(komi.trasaDlaDwochBiezaca)[1].ToString();
            temperatura = 1000;
            temperaturaKoncowa = 0.001;
            sigma = 0.99;
            proby = 1000;
            textBox_temperatura.Text = temperatura.ToString();
            textBox_temperaturaKoncowa.Text = temperaturaKoncowa.ToString();
            textBox_sigma.Text = sigma.ToString();
            textBox_proby.Text = proby.ToString();
            komi.trasaDlaDwoch.CopyTo(komi.trasaDlaDwochNajkrotsza, 0);
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
    }
}
