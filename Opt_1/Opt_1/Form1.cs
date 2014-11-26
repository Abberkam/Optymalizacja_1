using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Opt_1
{
    public partial class Form1 : Form
    {
        public droga komi;
        public Form1()
        {
            InitializeComponent();
            komi = new droga();
            //textBox_sciezka.Text = "Wpisz ścieżkę pliku lub użyj Menu";
            textBox_sciezka.Text = "C:\\Users\\abberkam\\Source\\Repos\\Optymalizacja\\exp0.txt";
        }

        private void Blad()
        {
            MessageBox.Show("Załaduj najpierw dane!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_zaladuj_Click(object sender, EventArgs e)
        {
            try
            {
                komi.open(textBox_sciezka.Text);
                textBox_zaladuj.BackColor = Color.Lime;
            }
            catch (Exception ex)
            {
                textBox_zaladuj.BackColor = Color.Red;
                MessageBox.Show("Nie można otworzyć pliku z podanej ścieżki. Komunikat błędu: " + ex.Message);
            }
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "C:\\Users\\abberkam\\Source\\Repos\\Optymalizacja\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        try
                        {
                            komi.open(openFileDialog1.FileName);
                            textBox_sciezka.Text = openFileDialog1.FileName;
                            textBox_zaladuj.BackColor = Color.Lime;
                        }
                        catch
                        {
                            textBox_zaladuj.BackColor = Color.Red;
                            MessageBox.Show("Niepoprawna zawartość pliku", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nie można otworzyć pliku. Komunikat błędu: " + ex.Message);
                }
            }
        }

        private void btn_wyswietl_Click(object sender, EventArgs e)
        {
            if (komi.ileMiast != 0)
            {
                Form2 form2 = new Form2();
                form2.Show();

                form2.textBox1.Text += "Liczba miast: ";
                form2.textBox1.Text += komi.ileMiast.ToString();
                form2.textBox1.Text += "\r\n";
                form2.textBox1.Text += "Tabela odległosci pomiędzy miastami: ";
                form2.textBox1.Text += "\r\n";
                for (int i = 0; i < komi.ileMiast; i++)
                {
                    for (int j = 0; j < komi.ileMiast; j++)
                    {
                        form2.textBox1.Text += String.Format("|{0,5} |", komi.dane[i][j]);
                    }
                    form2.textBox1.Text += "\r\n";
                }
                form2.textBox1.Text += "Trasa: ";
                form2.textBox1.Text += "\r\n";
                form2.textBox1.Text += komi.wyswietlTrase(komi.trasa);
            }
            else
                Blad();
                
        }

        private void btn_iteracyjna_Click(object sender, EventArgs e)
        {
            if (komi.ileMiast != 0)
            {
                Form3 form3 = new Form3(komi);
                form3.Show();

                form3.textBox_podstawowa.Text = komi.wyswietlTrase(komi.trasa);
                komi.trasa.CopyTo(komi.trasaBiezaca, 0);
                form3.textBox_biezaca.Text = komi.wyswietlTrase(komi.trasa);

                form3.textBox_dlugosc0.Text = komi.dlugoscTrasy(komi.trasa).ToString();
                form3.textBox_dlugosc1.Text = komi.dlugoscTrasy(komi.trasaBiezaca).ToString();
            }
            else
                Blad();
        }

        private void btn_wyrzarzanie_Click(object sender, EventArgs e)
        {
            if(komi.ileMiast != 0)
            {
                Form4 form4 = new Form4(komi);
                form4.Show();

                form4.textBox_podstawowa.Text = komi.wyswietlTrase(komi.trasa);
                komi.trasa.CopyTo(komi.trasaBiezaca, 0);
                form4.textBox_biezaca.Text = komi.wyswietlTrase(komi.trasa);

                form4.textBox_dlugosc0.Text = komi.dlugoscTrasy(komi.trasa).ToString();
                form4.textBox_dlugosc1.Text = komi.dlugoscTrasy(komi.trasaBiezaca).ToString();
            }
            else
                Blad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (komi.ileMiast != 0)
            {
                Form5 form5 = new Form5(komi);
                form5.Show();

                komi.trasa.CopyTo(komi.trasaDlaDwoch, 0);
                komi.trasaDlaDwoch[(komi.ileMiast + 1) / 2] = 0;
                for (int i = (komi.ileMiast + 1) / 2; i < komi.ileMiast + 1; i++)
                {
                    komi.trasaDlaDwoch[i + 1] = komi.trasa[i];
                }

                form5.textBox_podstawowa.Text = komi.wyswietlTrase(komi.trasaDlaDwoch);
                komi.trasaDlaDwoch.CopyTo(komi.trasaDlaDwochBiezaca, 0);
                form5.textBox_biezaca.Text = komi.wyswietlTrase(komi.trasaDlaDwochBiezaca);

                form5.textBox_dlugosc0.Text = komi.dlugoscTrasy2(komi.trasaDlaDwoch)[0].ToString();
                form5.textBox_dlugosc02.Text = komi.dlugoscTrasy2(komi.trasaDlaDwoch)[1].ToString();
                form5.textBox_dlugosc1.Text = komi.dlugoscTrasy2(komi.trasaDlaDwochBiezaca)[0].ToString();
                form5.textBox_dlugosc12.Text = komi.dlugoscTrasy2(komi.trasaDlaDwochBiezaca)[1].ToString();
            }
            else
                Blad();
        }

    }
}
