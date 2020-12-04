using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        int x;
        DateTime dataAtual; //declaração do tipo de hora
        public Form1()
        {
           
            InitializeComponent();
            timer1.Start(); //inicializar o time
        }

        private void StatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            dataAtual = DateTime.Now; //data atual recebe a hora do sistema
            lblData.Text = "Data atual: " + dataAtual.ToLongDateString();
            lblData.Text += " Hora atual: " + dataAtual.ToLongTimeString();
        }

        private void BtnInsere_Click(object sender, EventArgs e)
        {
            if(txtNome.Text != "")
            {
                cmbNomes.Items.Add(txtNome.Text);
                txtNome.Text = "";
            }
        }

        private void BtnApaga_Click(object sender, EventArgs e)
        {
            cmbNomes.Items.Remove(txtNome.Text);
            txtNome.Text = "";
            txtIndice.Clear();
        }

        private void BtnLimpa_Click(object sender, EventArgs e)
        {
            cmbNomes.Items.Clear();
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(txtIndice.Text);
            if (x <= cmbNomes.Items.Count - 1)
            {
                MessageBox.Show(cmbNomes.Items[x].ToString());

            }
            else
                MessageBox.Show("Erro","Erro",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtIndice.Clear();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtIndice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CmbNomes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
