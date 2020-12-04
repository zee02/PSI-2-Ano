using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        int idade, cont = 0, soma, maior = 0, menor = 0;
        double media;
        bool saida;
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtIdade_TextChanged(object sender, EventArgs e)
        {
            txtIdade.Focus();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {

            idade = Convert.ToInt32(txtIdade.Text);

            //if (txtIdade.Text != "" && idade > 0)

            saida = int.TryParse(txtIdade.Text, out idade);
            if (saida && idade > 0)
            {


                cont++;

                lblPessoa2.Text = cont.ToString();

                soma += idade;

                media = (double)soma / (double)cont;

                lblIdades2.Text = media.ToString("N1");

                if (cont == 1)
                {
                    menor = idade;
                    maior = idade;

                }
                else
                {
                    if (idade > maior)
                    {
                        maior = idade;

                    }

                    if (idade < menor)
                    {
                        menor = idade;

                    }
                }
                lblNova2.Text = Convert.ToString(menor);
                lblVelha2.Text = Convert.ToString(idade);
            }
            else
                MessageBox.Show("Idade inválida!!");

            txtIdade.Text = string.Empty;
        }
    }
}

     