using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        int lado1, lado2, lado3;
        bool triangulo = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVerifica_Click(object sender, EventArgs e)
        {
            if (lado1 + lado2 >= lado3 && lado3 + lado2 >= lado1 && lado3 + lado1 >= lado2)
            {
                triangulo = true;

            }

            else if (triangulo == false)
            {
                lblResultado.Text = ("As medidas usadas não formam um triângulo");
            }

            if (txtLado1.Text != "" || txtLado2.Text  != "" || txtLado3.Text != "")
            {
                if (txtLado1.Text !=  txtLado2.Text && txtLado2.Text != txtLado3.Text && txtLado3.Text != txtLado1.Text) 
                {
                    lblResultado.Text = "Triângulo escaleno";
                }
                if(txtLado1.Text == txtLado2.Text || txtLado2.Text == txtLado3.Text || txtLado3.Text == txtLado1.Text)
                {
                    lblResultado.Text = "Triângulo isósceles";

                }
                lado1 = Convert.ToInt32(txtLado1.Text);
                lado2 = Convert.ToInt32(txtLado2.Text);
                lado3 = Convert.ToInt32(txtLado3.Text);

                if (lado1 <= 0 || lado2 <= 0 || lado2 <= 0)
                {
                    lblResultado.Text = "Não é um triângulo";
                }
               
                if(lado1 + lado2 <= lado3 || lado2 + lado3 <= lado1 || lado1 + lado3 <= lado2)
                {
                    lblResultado.Text = "Não é um triângulo";
                }
            }
        }
    }
}
