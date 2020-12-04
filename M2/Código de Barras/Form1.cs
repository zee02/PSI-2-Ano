using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Código_de_Barras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mtxtPais.Focus();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private int Controlo (string codigo)
        {
            int digitoControlo = 0, soma = 0, resto = 0;

            for (int posicao = 0; posicao <= 11; posicao++)
            {
                if (posicao % 2 == 0) soma += int.Parse(codigo[posicao].ToString());
                else soma += int.Parse(codigo[posicao].ToString()) * 3;
            }

            resto = soma % 10;

            if (resto == 0) digitoControlo = 0;
            else digitoControlo = 10 - resto;

            return digitoControlo;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (mtxtPais.MaskCompleted == true && mtxtEmpresa.MaskCompleted == true && mtxtProduto.MaskCompleted == true)
            {
                string controlo = mtxtPais.Text + mtxtEmpresa.Text + mtxtProduto.Text ;
                lblControlo.Text = Controlo(controlo).ToString();

                lblBarras.Text = controlo.ToString() + lblControlo.Text;
            }
            else
                MessageBox.Show("Insira todos os números!");


        }

        private void MtxtPais_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }
    }

}
