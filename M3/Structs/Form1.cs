using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Structs
{
    public partial class Form1 : Form
    {
        int dors = 0;
       
        struct variaveis
        {
            public int dorsal;
            public string nome;
            public string clube;
            public string prova;

        }
         variaveis[] inscrições = new variaveis[10];

        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lblDorsal.Text = Convert.ToString(dors+1);
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
                if (cboProva.Text != "" && txtNome.Text != "" && cboClube.Text != "")
            {
                if (dors != 10)
                {
                    inscrições[dors].dorsal = dors + 1;
                    inscrições[dors].nome = txtNome.Text;
                    inscrições[dors].clube = cboClube.Text;
                    inscrições[dors].prova = cboProva.Text;


                    dors++;
                    cboProva.Text = "";
                    cboClube.Text = "";
                    txtNome.Text = string.Empty;
                    lblDorsal.Text = Convert.ToString(dors + 1);


                }
                else
                    MessageBox.Show("Não pode inserir mais do que 10 pessoas!");
                cboProva.Text = "";
                cboClube.Text = "";
                txtNome.Text = string.Empty;
            }
            else
                MessageBox.Show("Insira algo!");
            
        }

        private void BtnListagem_Click(object sender, EventArgs e)
        {
                FrmListagem formdesk = new FrmListagem();
                foreach (variaveis kappa in inscrições)
            {

                if (cboProva.Text == kappa.prova || cboProva.Text == "")
                {
                    formdesk.dgvGrelha.Rows.Add(kappa.dorsal, kappa.nome, kappa.clube, kappa.prova);

                }
                }
            
                
            formdesk.Show();
        }
    }
}
