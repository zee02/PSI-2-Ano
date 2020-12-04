using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex5
{
    public partial class Calculadora : Form
    {
        int num1, num2, result = 0, tab,mult;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void LblNumero2_Click(object sender, EventArgs e)
        {

        }

        private void TcrlMulti_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TcrlDivisao_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void TcrlSub_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtInsere1.Text != "" || txtInsere2.Text != "")
            {
                {

                    if (rbtSoma.Checked)
                    {
                        num1 = int.Parse(txtInsere1.Text);
                        num2 = int.Parse(txtInsere2.Text);
                        result = (num1 + num2);
                        txtResult.Text = Convert.ToString(result);
                    }

                    if (rbtDivisao.Checked)
                    {
                        num1 = int.Parse(txtInsere1.Text);
                        num2 = int.Parse(txtInsere2.Text);
                        result = (num1 / num2);
                        txtResult.Text = Convert.ToString(result);
                    }
                    if (rbtMulti.Checked)
                    {
                        num1 = int.Parse(txtInsere1.Text);
                        num2 = int.Parse(txtInsere2.Text);
                        result = (num1 * num2);
                        txtResult.Text = Convert.ToString(result);
                    }
                    if (rbtSub.Checked)
                    {
                        num1 = int.Parse(txtInsere1.Text);
                        num2 = int.Parse(txtInsere2.Text);
                        result = (num1 - num2);
                        txtResult.Text = Convert.ToString(result);

                    }
                }
            }
            else
                MessageBox.Show("Insira 2 números!");
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtInsere1.Clear();
            txtInsere2.Clear();
            txtResult.Clear();
            rbtDivisao.Checked = false;
            rbtMulti.Checked = false;
            rbtSoma.Checked = false;
            rbtSub.Checked = false;


        }

        private void TabCalc_Click(object sender, EventArgs e)
        {

        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void BtnTablimpa_Click(object sender, EventArgs e)
        {
            rtxtAparece.Text = String.Empty;
            txtTabInsere.Text = String.Empty;
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTabInsere_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnTabcalcula_Click(object sender, EventArgs e)
        {
            if (txtTabInsere.Text != "")
            {
                int tabuada = 0;
            tab = Convert.ToInt32(txtTabInsere.Text);
            for (int x = 0; x <= 10; x++)
            {
                tabuada = tab * x;
                rtxtAparece.Text += tab + "x" + x + "=" + tabuada + "\n";
            }
           }
            else
                MessageBox.Show("Insira 2 números!");
        }
    

        private void TxtInsere1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtInsere2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnMultLimpa_Click(object sender, EventArgs e)
        {
            rtxtMostra.Text = String.Empty;
            txtMultInsere.Text = String.Empty;
        }

        private void BtnMultLimpa_Click_1(object sender, EventArgs e)
        {
            rtxtMostra.Text = String.Empty;
            txtMultInsere.Text = String.Empty;
        }

        private void TxtInsere2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TxtResult_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TxtInsere1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void BtxCalc_Click(object sender, EventArgs e)
        {
            if (txtMultInsere.Text != "")
            {
                int eh = 0;
                mult = Convert.ToInt32(txtMultInsere.Text);
                for (int x = 1; x <= 10; x++)
                {
                    eh = mult * x;
                    rtxtMostra.Text += "Múltiplos " + "=" + eh + "\n";
                }
            }
            else
                MessageBox.Show("Insira número!");
        }

        private void TxtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void TcrlSoma_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
