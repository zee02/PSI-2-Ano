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

namespace Ex6
{
    public partial class TryParse : Form
    {
        int num;
        public TryParse()
        {
            InitializeComponent();
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            if (txtInsere.Text != "")
            {
                bool result;
                int x;
                result = int.TryParse(txtInsere.Text, out x); //Converte para inteiro e retorna "True"
                Console.WriteLine(result);
                txtParse.Text = Convert.ToString(result);
            }
            else
                MessageBox.Show("Insira 2 números!");
        }

            private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtInsere_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtInsere.Clear();
            txtParse.Clear();
        }

        private void LblInserir_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_Click_1(object sender, EventArgs e)
        {
            txtInsere.Clear();
            txtParse.Clear();
        }

        private void TxtInsere_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TxtParse_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnFechar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
