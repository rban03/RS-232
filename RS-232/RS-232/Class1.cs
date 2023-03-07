using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Resources.ResXFileRef;

namespace RS_232
{


    public static class Class1
    {

        public static bool[][] lancuchNaBinar(string lancuch) // iteruje przez kazdą literke słowa
        {
            bool[][] slowaBinarne = new bool[lancuch.Length][];
            for (int i = 0; i < lancuch.Length; i++)
            {
                slowaBinarne[i] = znakNaSlowoBinarne(lancuch[i]);
            }
            return slowaBinarne;                    // tablica [][]
        }

        private static bool[] decToBin(int dec)
        {
            int buffD = dec;
            bool[] buffB = new bool[16];
            for (int i = 15; i >= 0; i--)
            {
                if (buffD % 2 == 1) buffB[i] = true;
                else buffB[i] = false;

                buffD /= 2;
            }
            return buffB;
        }
        private static bool[] odwrocTablice(bool[] tablica)
        {
            bool[] buff = new bool[tablica.Length];             // przepisuje wartość z końca tablicy na poczatek
            for (int i = 0; i < tablica.Length; i++)            // z tablicy [][] na tablice []
            {
                buff[i] = tablica[tablica.Length - 1 - i];
            }
            return buff;
        }

        public static bool[] znakNaSlowoBinarne(char znak)
        {
            int kodASCIIZnaku = (int)znak;
            bool[] bajtZnaku = new bool[8];                     // kazdy znak kodowany jest przez 8 bajtow
            bajtZnaku = odwrocTablice(decToBin(kodASCIIZnaku)); // przepisuje na bajtZnaku tablice []
            bool[] slowoBinarne = new bool[11];                 // zrobienie miejsca na bit stopu i startu
            slowoBinarne = dodajBityStopuIStartu(bajtZnaku);    // 

            return slowoBinarne;
        }

        private static bool[] dodajBityStopuIStartu(bool[] bajt)
        {
            bool[] znak = new bool[11]; //nowa tablica która ma 8 bitów + 1 startu + 2 stopu = 11
            znak[0] = false;
            for (int i = 0; i < 8; i++)
            {
                znak[i + 1] = bajt[i];      // przesunięcie tblicy o 1 bit
            }
            znak[9] = true;                 // dodanie 2 bitów na koncu 
            znak[10] = true;

            return znak;
        }

        private static string numberToText(bool[] number)
        {
            string tymcz = "";
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i]) tymcz += "1";
                else tymcz += "0";
            }
            return tymcz;
        }

        public static string numberToText(bool[][] number)
        {
            string buff = "";
            int i = 0;
            foreach (bool[] x in number)
            {
                buff += (numberToText(x) + "  ");
                if (i != 0 && i % 4 == 0)
                {
                    buff += "\r\n";
                }
            }
            return buff;
        }



        ////////////////////////////////////////////////////////////////////////




        public static string slowaBinarneNaLancuch(bool[][] slowaBinarne)
        {
            string buff = "";
            foreach (bool[] x in slowaBinarne)
            {
                buff += SlowoBinarneNaZnak(x);
            }
            return buff;
        }

        private static char SlowoBinarneNaZnak(bool[] slowoBinarne)
        {
            bool[] bajt = new bool[8];
            bajt = usunBityStopuIStartu(slowoBinarne);
            int kodASCIIZnaku = binToDec(odwrocTablice(bajt));
            char znak = (char)kodASCIIZnaku;
            return znak;
        }

        private static bool[] usunBityStopuIStartu(bool[] slowo)
        {
            bool[] bajt = new bool[8];
            for (int i = 0; i < 8; i++)
            {
                bajt[i] = slowo[i + 1];
            }
            return bajt;
        }

        private static int binToDec(bool[] bin)
        {
            int dec = 0;
            int n = 1;
            for (int i = bin.Length - 1; i >= 0; i--)
            {
                if (bin[i])
                {
                    dec += n;
                }
                n *= 2;
            }
            return dec;
        }

    }
}
