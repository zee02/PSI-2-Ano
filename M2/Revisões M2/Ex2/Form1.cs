using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPontuar_Click(object sender, EventArgs e)
        {
            txtMarca.Focus();

            //Verificar se a marca e o modelo estão preenchidos
            if (txtMarca.Text != "" && txtModelo.Text != "")
            {
                //Criar novo registo
                ListViewItem Novo = new ListViewItem(txtMarca.Text);
                Novo.SubItems.Add(txtModelo.Text);
                Novo.SubItems.Add(Calcular().ToString());
                //Adicionar o registo à lista
                lstVeiculos.Items.Add(Novo);


                //Limpar caixa de texto
                txtMarca.ResetText();
                txtModelo.ResetText();

                //Colocar o cursor no primeiro controlo
                txtMarca.Focus();

            }
            else
            {
                MessageBox.Show("Preenche todos os campos!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            foreach (Object controlo in grbAvaliacao.Controls)
            {
                if (controlo is ComboBox)
                {
                    ((ComboBox)controlo).Text = "0";
                }
            }
            txtMarca.Text = string.Empty;
            txtModelo.Text = string.Empty;

        }

        private void PreencherCombos()
        {
            //Para todos os controlos da GroupBox
            foreach (Object controlo in grbAvaliacao.Controls)
            {
                if (controlo is ComboBox)
                {
                    for (int ctd = 0; ctd <= 5; ctd++)
                    {
                        //Converter para combobox e adicionar o valor ctd
                        ((ComboBox)controlo).Items.Add(ctd);
                    }
                    ((ComboBox)controlo).Text = "0"; //predefinir o valor
                }
            }
        }
        //método retorno
        private string Calcular()
        {
            int soma = 0;
            string mensagem = "";

            //Para todos os controlos do GroupBox
            foreach (Object controlo in grbAvaliacao.Controls)
            {
                //Verificar se a Combobox está vazia
                if (controlo is ComboBox)
                {
                    soma += int.Parse(((ComboBox)controlo).Text);
                }
            }
            if (soma <= 5) mensagem = "Fraco";
            else if (soma <= 10) mensagem = "Insuficiente";
            else if (soma <= 15) mensagem = "Suficiente";
            else if (soma <= 20) mensagem = "Bom";
            else if (soma <= 25) mensagem = "Muito Bom";
            else if (soma <= 30) mensagem = "Excelente";

            return mensagem; //Devolver o resultado
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            PreencherCombos();
        }


    }   
}
