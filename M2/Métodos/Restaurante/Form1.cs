using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class Form1 : Form
    {
       double adultos, criancas, dieta,total,sinal,pagamento;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            limpar();

        }
    private void limpar()
        {
            lblAdultos.Text = 0.ToString("C2");
            lblCriancas.Text = 0.ToString("C2");
            lblDieta.Text = 0.ToString("C2");


            nudAdultos.Value = 0;
            nudCriancas.Value = 0;
            nudDieta.Value = 0;

            lblPagamento.Text = string.Empty;
            lblPreco.Text = string.Empty;
            lblSinal.Text = string.Empty;


            cboEmenta.SelectedIndex = -1;
        }

        private void LblPreco_Click(object sender, EventArgs e)
        {

        }

        private void NudAdultos_ValueChanged(object sender, EventArgs e)
        {
            adultos = ValorEmenta(cboEmenta.Text, "adultos", (int)nudAdultos.Value);
            lblAdultos.Text = adultos.ToString("C2");
        }

        private void NudCriancas_ValueChanged(object sender, EventArgs e)
        {
            criancas = ValorEmenta(cboEmenta.Text, "criancas", (int)nudCriancas.Value);
            lblCriancas.Text= criancas.ToString("C2");
        }

        private void NudDieta_ValueChanged(object sender, EventArgs e)
        {
            dieta = ValorEmenta(cboEmenta.Text, "dieta", (int)nudDieta.Value);
            lblDieta.Text = dieta.ToString("C2");
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (cboEmenta.Text != "")
            {
                total = adultos + criancas + dieta;
                lblPreco.Text = total.ToString("C2");


                sinal = total * 0.3;
                lblSinal.Text = sinal.ToString("C2");


                pagamento = total - sinal;
                lblPagamento.Text = pagamento.ToString("C2");
            }
            else
                MessageBox.Show("Selecione valores!", "Aviso");
            nudAdultos.Value = 0;
            nudCriancas.Value = 0;
            nudDieta.Value = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            limpar();
        }
        private double ValorEmenta(string ementa, string tipopessoa, int quant)
        {
            ementa = cboEmenta.Text.ToString();
            double valor = 0;
            switch (ementa)
            {
                case "Deluxe":
                    if (tipopessoa == "adultos")
                    {
                        valor = quant * 90;
                        lblAdultos.Text = Convert.ToString(valor);
                    }
                    if (tipopessoa == "criancas")
                    {
                      
                        valor = quant * 40;
                        lblCriancas.Text = Convert.ToString(valor);
                    }
                    break;

                case "Portuguesa":
                    if (tipopessoa == "adultos")
                    {

                       
                        valor = quant * 100;
                        lblAdultos.Text = Convert.ToString(valor);
                    }
                    if (tipopessoa == "criancas")
                    {
                    
                        valor = quant * 70;
                        lblCriancas.Text = Convert.ToString(valor);
                    }
                    break;


                case "Prestígio":
                    if (tipopessoa == "adultos")
                    {
                        valor = quant * 75;
                        lblAdultos.Text = Convert.ToString(valor);
                    }
                    if (tipopessoa == "criancas")
                    {
                        valor = quant * 33;
                        lblCriancas.Text = Convert.ToString(valor);
                    }
                    break;

                case "Rodízio":
                    if (tipopessoa == "adultos")
                    {      
                        valor = quant * 120;
                        lblAdultos.Text = Convert.ToString(valor);
                    }
                    if (tipopessoa == "criancas")
                    {     
                        valor = quant * 45;
                        lblCriancas.Text = Convert.ToString(valor);
                    }
                    break;

                case "Soberba":
                    if (tipopessoa == "adultos")
                    { 
                        valor = quant * 95;
                        lblAdultos.Text = Convert.ToString(valor);
                    }
                    if (tipopessoa == "criancas")
                    {
                        valor = quant * 45;
                        lblCriancas.Text = Convert.ToString(valor);
                    }
                    break;

            }
            if (tipopessoa == "dieta")
            {
                valor = quant * 56;
            }
            
            return valor;
        }
    }
}
