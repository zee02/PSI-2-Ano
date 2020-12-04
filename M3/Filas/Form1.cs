using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filas
{
    public partial class Form1 : Form
    {
        Queue<string> pessoas = new Queue<string>();
        public Form1()
        {
            
            InitializeComponent();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            if (txtNomes.Text != "")
            {
               
                pessoas.Enqueue(txtNomes.Text);

                txtNomes.Text = string.Empty;

                inserir();
            }
            else
                MessageBox.Show("Insira alguma coisa");
     
        }

        private void BtnAtendido_Click(object sender, EventArgs e)
        {
            if (lstNomes.Items.Count > 0)
            {
                pessoas.Dequeue();
            }
        }

        private void inserir()
        {
            lstNomes.Items.Clear();

            foreach (string nome in pessoas)
            {
                
                lstNomes.Items.Add(nome);
            }

           
        }

        private void BtnActualiza_Click(object sender, EventArgs e)
        {
            inserir();
        }
    }
}
