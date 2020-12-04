using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriarUtilizadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCria_Click(object sender, EventArgs e)
        {
            if(txtUti.Text!= string.Empty && txtUti.Text != string.Empty && txtEmail.Text != string.Empty)
            {
                //instanciar ModeloBD
                ModeloBD novoutilizador = new ModeloBD();

                novoutilizador.Nome = txtUti.Text; 
                novoutilizador.Email = txtEmail.Text;
                novoutilizador.Senha = txtPass.Text;
               

                //instanciar AcedeBD
                AcedeBD acesso = new AcedeBD();

                //Registar utilizador
                acesso.Registo(novoutilizador);

                limpacontrolos();
            }
        }

        private void BtnFecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpacontrolos()
        {
            txtPass.Text = "";
            txtUti.Text = "";
            txtEmail.Text = "";
        }
    }
}
