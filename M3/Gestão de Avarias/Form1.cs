using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestão_de_Avarias
{
    public partial class Form1 : Form
    {
        string avar;
        struct modelos
        { 
            public string modelo;
            public string avaria;
            public string data;
        }
        
        Queue<modelos> teste = new Queue <modelos>();
        modelos registo;

        public Form1()
        {

            InitializeComponent();
        }

        private void LstbAvaria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            avar = Convert.ToString(lstbAvaria.SelectedItem);

            

            registo.modelo = txtModelo.Text;
            registo.data = dtpData.Text;
            registo.avaria = avar;
           

            teste.Enqueue(registo);

            dgvDados.Rows.Add(registo.data, registo.modelo, registo.avaria);

            txtModelo.Text = string.Empty;

        }

        private void BtnReparado_Click(object sender, EventArgs e)
        {

        
             teste.Dequeue();

            limpar();

        }

        private void limpar()
        {
            dgvDados.Rows.Clear();

            foreach (modelos nome in teste)
            {
                dgvDados.Rows.Add(nome.data, nome.modelo, nome.avaria);
            }
        }
    }
}
