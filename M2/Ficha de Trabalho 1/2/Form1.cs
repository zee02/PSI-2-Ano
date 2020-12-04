using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcula_Click(object sender, EventArgs e)
        {
            double consumo = 0, value = 0, cr, kms, preco;
            if (txtConsumo.Text != "")
            {
                cr = Convert.ToDouble(txtConsumo.Text);
                kms = Convert.ToDouble(txtKms.Text);
                preco = Convert.ToDouble(txtPreco.Text);


                consumo = (100 * cr) / kms;
                value = consumo * preco;

                lblRegisto.Text = consumo.ToString();
                lblValorG.Text = value.ToString("C2");
            }
            else
                MessageBox.Show("Insira alguma coisa!");
        }
    }
}
