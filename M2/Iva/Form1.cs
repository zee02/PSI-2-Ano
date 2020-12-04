using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcula_Click(object sender, EventArgs e)
        {


            string nome = txtNome.Text;
            decimal valor = Convert.ToDecimal(txtValor.Text);
            string regiao = cmbRegiao.Text.ToString();


            decimal imposto = 0, total = 0;

            if (txtNome.Text != "" && txtValor.Text != "" && cmbRegiao.Text != "")
            {


                if (valor > 500)
                {
                    imposto = 0;
                }

                else
                {
                    switch (regiao)
                    {
                        case "Norte":
                            imposto = 40;
                            break;

                        case "Sul":
                            imposto = 30;
                            break;

                        case "Centro":
                            imposto = 50;
                            break;

                        default:
                            imposto = 15;
                            break;
                    }
                }
            }
            else
                MessageBox.Show("Insira valores!", "Aviso");

            total = valor + imposto;


            lblValorC.Text = valor.ToString("C");
            lblImposto2.Text = imposto.ToString("C");
            lblTotal2.Text = total.ToString("C");
            lblNome2.Text = nome;
        }

        private void BtnLimpa_Click(object sender, EventArgs e)
        {

            txtNome.Text = string.Empty;
            txtValor.Text = string.Empty;
            lblValorC.Text = string.Empty;
            lblImposto2.Text = string.Empty;
            lblTotal2.Text = string.Empty;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void BtnLimpa_Click_1(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtValor.Text = string.Empty;
            cmbRegiao.SelectedText = string.Empty;
            lblValorC.Text = string.Empty;
            lblImposto2.Text = string.Empty;
            lblTotal2.Text = string.Empty;
            lblNome2.Text = string.Empty;
        }

        private void Form1_Load_2(object sender, EventArgs e)
        {

        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
           
                btnCalcula.Enabled = true;
            
        }

        private void TxtValor_TextChanged(object sender, EventArgs e)
        {
           

        }
    }
  
    }

    
