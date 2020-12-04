using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pizzas
{
    public partial class Form1 : Form
    {
       
       Calculos coisox = new Calculos();
        int cont = 0;
        public Form1()
        {
         
            InitializeComponent();
        }

        public void BtnAdicionar_Click(object sender, EventArgs e)
        {
            cont = dgvIngredientes.Rows.Count;

            if (cont >= 1)
            {
                btnFinalizar.Enabled = true;
            }

            

            coisox.Tipo = Convert.ToString(cboMassa.SelectedItem);
            coisox.Tamanho = Convert.ToString(cboTamanho.SelectedItem);

            coisox.Numero = 0;

            string ingre;

            ingre = Convert.ToString(cboIngredientes.SelectedItem);

            if (cboIngredientes.Text != "")
            {

                dgvIngredientes.Rows.Add(ingre);
                cboIngredientes.Items.Remove(ingre);
            }

            else
                MessageBox.Show("Insira algum ingrediente!");

           if (cont == 4)
            {
                btnAdicionar.Enabled = false;
            }

        }

        public void Ingredientes()
        {
            cboIngredientes.Items.Add("Ananás");
            cboIngredientes.Items.Add("Atum");
            cboIngredientes.Items.Add("Azeitonas");
            cboIngredientes.Items.Add("Bacon");
            cboIngredientes.Items.Add("Camarão");
            cboIngredientes.Items.Add("Carne de Vaca");
            cboIngredientes.Items.Add("Cebola");
            cboIngredientes.Items.Add("Chouriço");
            cboIngredientes.Items.Add("Cogumelos");
            cboIngredientes.Items.Add("Feta");
            cboIngredientes.Items.Add("Fiambre");
            cboIngredientes.Items.Add("Frango");
            cboIngredientes.Items.Add("Milho");
            cboIngredientes.Items.Add("Molho BBQ");
            cboIngredientes.Items.Add("Molho Picante");
            cboIngredientes.Items.Add("Mozzarella");
            cboIngredientes.Items.Add("Parmesão");
            cboIngredientes.Items.Add("Pepperoni");
            cboIngredientes.Items.Add("Pimentos");
            cboIngredientes.Items.Add("Tomate");

        }

 

        private void Form1_Load(object sender, EventArgs e)
        {
            Ingredientes();
            btnFinalizar.Enabled = false;

        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {

            coisox.Tamanho = cboTamanho.Text;
            coisox.Tipo = cboMassa.Text;
            coisox.Numero = cont;
            lblTotal.Text = coisox.CalcularValor().ToString("F2");
        }

       


        private void BtnRepor_Click_1(object sender, EventArgs e)
        {
            dgvIngredientes.Rows.Clear();
            cboIngredientes.SelectedIndex = -1;
            cboMassa.SelectedIndex = -1;
            cboTamanho.SelectedIndex = -1;
            lblTotal.Text = "";
            btnAdicionar.Enabled = true;
            btnFinalizar.Enabled = false;
            Ingredientes();
        }
    }
    
}
