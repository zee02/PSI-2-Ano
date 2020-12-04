using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício_Métodos
{
    public partial class Form1 : Form
    {
        int numeros;
        public Form1()
        {
          
            InitializeComponent();
          
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            
            if (txtInserir.Text != "")
            {
                numeros = Convert.ToInt32(txtInserir.Text);

                lstItems.Items.Add(numeros);
                txtInserir.Text = string.Empty;
                txtInserir.Focus();

            }
            else MessageBox.Show("Insira alguma coisa!");
        }
            public int calcular(params int[] valores)
        {
            int soma = 0;
            foreach (int numeros2 in valores)
            
               
                soma += numeros2;
                
            return soma;
            
        }

        private void BtnCalcula_Click(object sender, EventArgs e)
        {
            int[] numero = new int[lstItems.Items.Count];
            for (int i =0;i <= lstItems.Items.Count-1; i++)
            {
                numero[i] = int.Parse(lstItems.Items[i].ToString());

            }
            int maior = numero.Max();
            int menor = numero.Min();
            double average = numero.Average();

            lblMax.Text = maior.ToString();
            lblMin.Text = menor.ToString();
            lblMedia.Text = average.ToString("N1");

            lblTotal.Text = calcular(numero).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
