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
    public class droga
    {
        private string sciezka;

        public int ileMiast = 0;
        public int[][] dane;

        public int[] trasa;
        public int[] trasaBiezaca;
        public int[] trasaNajkrotsza;

        public int[] trasaDlaDwoch;
        public int[] trasaDlaDwochBiezaca;
        public int[] trasaDlaDwochNajkrotsza;

        private Random rand;

        public droga()
        {
        }

        public droga(string track)
        {
            sciezka = track;
        }

        public void open(string track)
        {
            string[] data;
            StreamReader reader = new StreamReader(track);
            string line;

            ileMiast = Int32.Parse(reader.ReadLine());

            dane = new int[ileMiast][];
            for (int i = 0; i < ileMiast; i++)
                dane[i] = new int[ileMiast];
            trasa = new int[ileMiast + 1];
            trasaBiezaca = new int[ileMiast + 1];
            trasaNajkrotsza = new int[ileMiast + 1];
            trasaDlaDwoch = new int[ileMiast + 2];
            trasaDlaDwochBiezaca = new int[ileMiast + 2];
            trasaDlaDwochNajkrotsza = new int[ileMiast + 2];

            for (int i = 0; i < ileMiast; i++)
            {
                line = reader.ReadLine();
                data = line.Split(' ');
                for (int j = 0; j < ileMiast; j++)
                {
                    dane[i][j] = Int32.Parse(data[j]);
                }
            }

            line = reader.ReadLine();
            data = line.Split(' ');
            for (int i = 0; i < ileMiast; i++)
            {
                trasa[i] = Int32.Parse(data[i]);
                trasa[i + 1] = 0;
            }
        }

        public string wyswietlTrase(int[] route)
        {
            string track = "0 ";

            for (int i = 1; i < route.Length; i++)
            {
                track += route[i].ToString();
                track += " ";
            }

            return track;
        }

        public void swap(int[] route1)
        {
            rand = new Random();
            int x = rand.Next(1, ileMiast);
            int y = rand.Next(1, ileMiast);
            while (x == y) y = rand.Next(1, ileMiast);
            int tmp = route1[x];
            route1[x] = route1[y];
            route1[y] = tmp;
        }

        public void aswap(int[] route1)
        {
            rand = new Random();
            int x = rand.Next(1, ileMiast);
            int tmp = route1[x];
            int y;
            if (x < ileMiast - 1 && x > 1)
            {
                if (rand.Next(2) == 0) y = x + 1;
                else y = x - 1;
            }
            else if (x == ileMiast - 1) y = x - 1;
            else if (x == 1) y = x + 1;
            else y = x;

            route1[x] = route1[y];
            route1[y] = tmp;
        }

        public void ins(int[] route1)
        {
            rand = new Random();
            int x = rand.Next(1, ileMiast);
            int y = rand.Next(1, ileMiast);
            while (x == y) y = rand.Next(1, ileMiast);
            int tmp;
            if (x > y)
            {
                tmp = x;
                x = y;
                y = tmp;
            }
            tmp = route1[x];
            for (int i = x; i < y; i++)
                route1[i] = route1[i + 1];
            route1[y] = tmp;
        }

        public long znajdzNajkrotszaTrase(int[] route1, int ileIteracji, int jakametoda)
        {
            long suma = dlugoscTrasy(route1);
            long tmp;

            for (int i = 0; i < ileIteracji; i++)
            {
                switch (jakametoda)
                {
                    case 3:
                        ins(route1);
                        break;
                    case 2:
                        aswap(route1);
                        break;
                    case 1:
                        swap(route1);
                        break;
                    default:
                        ins(route1);
                        break;
                }
                tmp = dlugoscTrasy(route1);
                if (tmp < suma)
                {
                    suma = tmp;
                    route1.CopyTo(trasaBiezaca, 0);
                    trasaBiezaca.CopyTo(trasaNajkrotsza, 0);
                }
            }
            return suma;
        }

        public long dlugoscTrasy(int[] route0)
        {
            long suma = 0;
            for (int i = 0; i < ileMiast; i++)
            {
                suma += dane[route0[i]][route0[i + 1]];
            }
            return suma;
        }

        public long symulowaneWyzarzanie(int[] route1, double T0, double T2, double sigma, int jakametoda)
        {
            int[] trasaTmp = new int[ileMiast + 1];
            rand = new Random();
            double x;
            double p;
            long delta;

            while (T0 > T2)
            {
                route1.CopyTo(trasaTmp, 0);
                switch (jakametoda)
                {
                    case 3:
                        ins(trasaTmp);
                        break;
                    case 2:
                        aswap(trasaTmp);
                        break;
                    case 1:
                        swap(trasaTmp);
                        break;
                    default:
                        ins(trasaTmp);
                        break;
                }

                delta = dlugoscTrasy(route1) - dlugoscTrasy(trasaTmp);

                if (delta < 0)
                {
                    route1.CopyTo(trasaNajkrotsza, 0);
                }
                else
                {
                    x = rand.NextDouble();
                    p = Math.Exp(-delta / T0);
                    if (x < p)
                    {
                        route1.CopyTo(trasaNajkrotsza, 0);
                    }
                    else
                    {
                        trasaTmp.CopyTo(trasaNajkrotsza, 0);
                        trasaTmp.CopyTo(route1, 0);
                    }
                }
                T0 = T0 / (1 + sigma * T0);
            }
            trasaNajkrotsza.CopyTo(trasaBiezaca,0);
            return dlugoscTrasy(trasaNajkrotsza);
        }

        public void ins2(int[] route1)
        {
            rand = new Random();
            int x = rand.Next(1, ileMiast + 1);
            int y = rand.Next(1, ileMiast + 1);
            while (x == y) y = rand.Next(1, ileMiast + 1);
            int tmp;
            if (x > y)
            {
                tmp = x;
                x = y;
                y = tmp;
            }
            tmp = route1[x];
            for (int i = x; i < y; i++)
                route1[i] = route1[i + 1];
            route1[y] = tmp;
        }

        public long[] dlugoscTrasy2(int[] route0)
        {
            long[] suma = new long[2];
            suma[0] = 0;
            suma[1] = 0;
            int flaga = 0;

            for (int i = 0; i < ileMiast; i++)
            {
                if (flaga == 0)
                    suma[0] += dane[route0[i]][route0[i + 1]];
                else if (flaga == 1)
                    suma[1] += dane[route0[i]][route0[i + 1]];
                if (route0[i + 1] == 0)
                    flaga = 1;
            }

            return suma;
        }

        public long[] symulowaneWyzarzanie2(int[] route1, double T0, double T2, double sigma)
        {
            int[] trasaTmp = new int[ileMiast + 2];
            rand = new Random();
            double x;
            double p;
            long delta;
            long[] dlugosci0 = new long[2];
            long[] dlugosci1 = new long[2];

            while (T0 > T2)
            {
                route1.CopyTo(trasaTmp, 0);
                ins2(trasaTmp);

                dlugosci0 = dlugoscTrasy2(trasaTmp);
                dlugosci1 = dlugoscTrasy2(route1);

                if (dlugosci0[0] > dlugosci0[1])
                    delta = dlugosci1[0] - dlugosci0[0];
                else
                    delta = dlugosci1[1] - dlugosci0[1];

                if (delta < 0)
                {
                    route1.CopyTo(trasaDlaDwochNajkrotsza, 0);
                }
                else
                {
                    x = rand.NextDouble();
                    p = Math.Exp(-delta / T0);
                    if (x < p)
                    {
                        route1.CopyTo(trasaDlaDwochNajkrotsza, 0);
                    }
                    else
                    {
                        trasaTmp.CopyTo(trasaDlaDwochNajkrotsza, 0);
                        trasaTmp.CopyTo(route1, 0);
                    }
                }
                T0 = T0 / (1 + sigma * T0);
            }
            trasaDlaDwochNajkrotsza.CopyTo(trasaDlaDwochBiezaca, 0);
            return dlugoscTrasy2(trasaDlaDwochNajkrotsza);
        }

        public long[] autostrojenie2(float zmienna)
        {
            int[] trasaTmp = new int[ileMiast + 2];
            rand = new Random();
            double x;
            double p;
            long delta = 0;
            long deltamax = 0;
            long[] dlugosci0 = new long[2];
            long[] dlugosci1 = new long[2];
            double T0;
            trasaDlaDwoch.CopyTo(trasaDlaDwochBiezaca, 0);

            for (int i = 0; i < 0.5 * ileMiast * ileMiast; i++)
            {
                trasaDlaDwochBiezaca.CopyTo(trasaTmp, 0);
                //ins2();

                dlugosci0 = dlugoscTrasy2(trasaTmp);
                dlugosci1 = dlugoscTrasy2(trasaDlaDwochBiezaca);

                if (dlugosci0[0] > dlugosci0[1])
                    delta = dlugosci1[0] - dlugosci0[0];
                else
                    delta = dlugosci1[1] - dlugosci0[1];

                if (Math.Abs(delta) > Math.Abs(deltamax))
                    deltamax = delta;
            }
            T0 = -deltamax / Math.Log(0.9, Math.E);

            trasaDlaDwoch.CopyTo(trasaDlaDwochBiezaca, 0);
            while (T0 > 0.001)
            {
                for (int i = 0; i < 0.5 * ileMiast * ileMiast; i++)
                {
                    trasaDlaDwochBiezaca.CopyTo(trasaTmp, 0);
                    //ins2();

                    dlugosci0 = dlugoscTrasy2(trasaTmp);
                    dlugosci1 = dlugoscTrasy2(trasaDlaDwochBiezaca);

                    if (dlugosci0[0] > dlugosci0[1])
                        delta = dlugosci1[0] - dlugosci0[0];
                    else
                        delta = dlugosci1[1] - dlugosci0[1];


                    if (delta < 0)
                    {
                        trasaDlaDwochBiezaca.CopyTo(trasaDlaDwochNajkrotsza, 0);
                    }
                    else
                    {
                        x = rand.NextDouble();
                        p = Math.Exp(-delta / T0);
                        if (x < p)
                        {
                            trasaDlaDwochBiezaca.CopyTo(trasaDlaDwochNajkrotsza, 0);
                        }
                        else
                        {
                            trasaTmp.CopyTo(trasaDlaDwochNajkrotsza, 0);
                            trasaTmp.CopyTo(trasaDlaDwochBiezaca, 0);
                        }
                    }
                }
                T0 = T0 / (1 + 0.99 * T0);
            }


            return dlugoscTrasy2(trasaDlaDwochNajkrotsza);
        }
    }
}