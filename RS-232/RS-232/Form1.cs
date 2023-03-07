using System.CodeDom.Compiler;
using System.IO.Pipes;
using System.Net.NetworkInformation;
using System.Text;

namespace RS_232
{
    public partial class Form1 : Form
    {

        private bool[][] lancuch;
        Odbiornik odbiornik = new Odbiornik();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cnv_Click(object sender, EventArgs e)
        {
            binaryTxT.Text = "";

            lancuch = Class1.lancuchNaBinar(ASCIITxT.Text);
            binaryTxT.Text = Class1.numberToText(lancuch);

        }

        private void ASCIITxT_TextChanged(object sender, EventArgs e)
        {
            if (ASCIITxT.Text.Equals("")) cnv.Enabled = false;
            else cnv.Enabled = true;
            odbiornik.binaryTxT.Text = "";
        }

        private void send_Click(object sender, EventArgs e)
        {
            odbiornik.lancuch = lancuch;
            odbiornik.binaryTxT.Text = Class1.numberToText(odbiornik.lancuch);
            odbiornik.Show();
        }

        private void binaryTxT_TextChanged(object sender, EventArgs e)
        {
            if (binaryTxT.Text.Equals("")) send.Enabled = false;
            else send.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}