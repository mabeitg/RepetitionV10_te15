using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepetitionV10_te15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSkapaFaktura_Click(object sender, EventArgs e)
        {
            tbxFaktura.Text = "Faktura till " + tbxKund.Text;
            tbxFaktura.Text += "\r\n"; //Ny rad!
            tbxFaktura.Text += "\r\n"; //Ny rad!

            tbxFaktura.Text += tbxTimmar.Text + " timmar a " +
                tbxTimpenning.Text + " kr: ";

            int antalTimmar, timpenning, kostnadExkl;

            antalTimmar = int.Parse(tbxTimmar.Text);
            timpenning = int.Parse(tbxTimpenning.Text);

            kostnadExkl = antalTimmar * timpenning;

            tbxFaktura.Text += kostnadExkl + " kr";

        }
    }
}
