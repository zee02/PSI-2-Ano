using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio
{
    public partial class InsereValores : Form
    {
        public InsereValores()
        {
            InitializeComponent();
        }



        public void InsereValores_Load(object sender, EventArgs e)
        {
            InsereValores carros = new InsereValores();

            carros.StartPosition = FormStartPosition.CenterScreen;
        }

        private void cmbTipo_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void cmbTipo_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void CmbTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtRegisto_TextChanged(object sender, EventArgs e)
        {

        }

        private void MtbAno_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TxtMarcas_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtMarcas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtCateg_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void TxtComb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRegisto.Text = "";
            mtbAno.Text = "";
            txtModelo.Text = "";
            txtMarcas.Text = "";
            mtbCili.Text = "";
            mtbPreco.Text = "";
            cmbCateg.SelectedIndex = -1;
            cmbComb.SelectedIndex = -1;
            cmbTipo.SelectedIndex = -1;
        }
    }
}
