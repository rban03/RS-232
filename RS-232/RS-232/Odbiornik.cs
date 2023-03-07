using MaterialSkin.Controls;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RS_232
{
    public partial class Odbiornik : Form
    {

        public bool[][] lancuch;
        String[] grube = new string[] { "debil", "cymbał", "dałn", "ćwok" };




        public Odbiornik()
        {
            InitializeComponent();
        }

        private void Odbiornik_Load(object sender, EventArgs e)
        {

        }

        private void binaryTxT_TextChanged(object sender, EventArgs e)
        {

        }

        private void cnv_Click(object sender, EventArgs e)
        {
            string buff = Class1.slowaBinarneNaLancuch(lancuch);

            if (grube.Contains(buff))
            {
                string buff2 = "";
                for (int i = 0; i < buff.Length; i++)
                {
                    buff2 += "*";
                }
                finalTxt.Text = buff2;
            }
            else
                finalTxt.Text = buff;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
