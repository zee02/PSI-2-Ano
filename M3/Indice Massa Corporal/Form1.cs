using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Indice_Massa_Corporal
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {

            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {

            double peso = Convert.ToDouble(nudPeso.Value);
            double altura = Convert.ToDouble(nudAltura.Value);

            Calculos imcc = new Calculos();

          
                if (txtIdade.Text != "")
                {

                    int idadee = Convert.ToInt32(txtIdade.Text);
                    imcc.Altura = altura;
                    imcc.Peso = peso;
                    imcc.Idadee = idadee;

                    if (idadee >= 18 && idadee <= 65 && radMasculino.Checked)
                    {
                    lblIMC.Text = imcc.iemc().ToString("F2");
                        lblClassificacao.Text = Convert.ToString(imcc.pesoo());
                        lblRisco.Text = Convert.ToString(imcc.riscoM());
                    }

                    else if (idadee >= 18 && idadee <= 65)
                    {

                    lblIMC.Text = imcc.iemc().ToString("F2");
                    lblClassificacao.Text = Convert.ToString(imcc.pesoo());
                        lblRisco.Text = Convert.ToString(imcc.riscoF());

                    }
                    else
                    MessageBox.Show("Insira uma idade maior de 18 e menor de 65");

                }
                else
                MessageBox.Show("Insere valores!");



            }

        private void BtnRepor_Click(object sender, EventArgs e)
        {
            txtIdade.Text = "";
            lblClassificacao.Text = "";
            lblIMC.Text = "";
            lblRisco.Text = "";
            nudAltura.Value = 1.50M;
            nudPeso.Value = 50;
            radMasculino.Checked = true;
        }
    }
}
        