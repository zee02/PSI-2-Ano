using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCriar_Click(object sender, EventArgs e)
        {
            if (txtTitular.Text != "" || txtSaldo.Text != "" || txtConta.Text != "")
            {
                Conta_Bancária X = new Conta_Bancária();

                X.Numeroconta = int.Parse(txtConta.Text);
                X.NomeTitular1 = txtTitular.Text;
                X.Saldo1 = int.Parse(txtSaldo.Text);

                MessageBox.Show("Conta Criada!", "Conta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
             else
            MessageBox.Show("Insira Tudo!", "Conta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        }
    }
}
