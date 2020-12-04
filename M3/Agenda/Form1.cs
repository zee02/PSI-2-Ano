using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {
        List<Particular> listaparticular = new List <Particular>();
        List<Empresa> listaempresa = new List<Empresa>();
        


        public Form1()
        { 
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
        
        }

        private void TsbNovo_Click(object sender, EventArgs e)
        {
            BarraMenu(true);
            AtivarControlos(true);
            if(radEmpresas.Checked)
            {
                VerControlos(true);
            }

            radEmpresas.Enabled = false;
            radParticulares.Enabled = false;
        }

        public void VerControlos(bool estado)
        {
            lblCAE.Visible = estado;
            mtxtCAE.Visible = estado;
        }

        public void BarraMenu(bool estadomenu)
        {
            tsbCancelar.Enabled = estadomenu;
            tsbGuardar.Enabled = estadomenu;
            tsbNovo.Enabled = !estadomenu;
            tsbListar.Enabled = !estadomenu;
    }
        public void AtivarControlos(bool estadocontrolos)
        {
            txtEmail.Enabled = estadocontrolos;
            txtLocalide.Enabled = estadocontrolos;
            txtMorada.Enabled = estadocontrolos;
            txtNome.Enabled = estadocontrolos;

            mtxtContribuinte.Enabled = estadocontrolos;
            mtxtCP.Enabled = estadocontrolos;
            mtxtTelefone.Enabled = estadocontrolos;
        }
        public void Limpar()
        {
            txtEmail.Clear();
            txtLocalide.Clear();
            txtMorada.Clear();
            txtNome.Clear();

            mtxtCAE.Clear();
            mtxtContribuinte.Clear();
            mtxtCP.Clear();
            mtxtTelefone.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtivarControlos(false);
            BarraMenu(false);
          
        }

        private void TsbCancelar_Click(object sender, EventArgs e)
        {
            AtivarControlos(false);
            BarraMenu(false);
            Limpar();

            VerControlos(false);

            radEmpresas.Enabled = true;
            radParticulares.Enabled = true;
        }

        private void TsbGuardar_Click(object sender, EventArgs e)
        {

            if (txtNome.Text != "" && mtxtTelefone.MaskCompleted) {

                if (radParticulares.Checked)
                {

                    Particular clientesx = new Particular();

                    clientesx.Nome = Convert.ToString(txtNome.Text);
                    clientesx.Morada = Convert.ToString(txtMorada.Text);
                    clientesx.Localidade = Convert.ToString(txtLocalide.Text);
                    clientesx.Email = Convert.ToString(txtEmail.Text);
                    clientesx.Telefone = Convert.ToInt32(mtxtTelefone.Text);
                    clientesx.Postal = Convert.ToString(mtxtCP.Text);

                    if (mtxtContribuinte.MaskCompleted)
                    {
                        clientesx.Contribuinte = Convert.ToInt32(mtxtContribuinte.Text);
                    }
                    else
                        clientesx.Contribuinte = 0;

                    listaparticular.Add(clientesx);
                }

                else if 
                          (radEmpresas.Checked)
                {

                    Empresa clientesx = new Empresa();
                    clientesx.Nome = Convert.ToString(txtNome.Text);
                    clientesx.Morada = Convert.ToString(txtMorada.Text);
                    clientesx.Localidade = Convert.ToString(txtLocalide.Text);
                    clientesx.Email = Convert.ToString(txtEmail.Text);
                    clientesx.Telefone = Convert.ToInt32(mtxtTelefone.Text);

                    if (mtxtCAE.MaskCompleted)
                    {
                        clientesx.Cae = Convert.ToInt32(mtxtCAE.Text);
                    }
                    else
                        clientesx.Cae = 0;


                    if (mtxtContribuinte.MaskCompleted)
                    {
                        clientesx.Contribuinte = Convert.ToInt32(mtxtContribuinte.Text);
                    }
                    else
                        clientesx.Contribuinte = 0;

                    clientesx.Postal = Convert.ToString(mtxtCP.Text);

                    listaempresa.Add(clientesx);
                }
               
                
        }

            else MessageBox.Show("Insira pelo menos um nome e um telefone!");


            tsbCancelar.PerformClick();
        }

        private void TsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TsbListar_Click(object sender, EventArgs e)
        {
            FrmListar listar = new FrmListar();


            if (radParticulares.Checked)
            {
                foreach (Particular kappa1 in listaparticular)
                {
                    listar.dgvLista.Rows.Add(kappa1.Nome, kappa1.Telefone);
                    
                }
            }
            if (radEmpresas.Checked)
            {
                foreach (Empresa kappa2 in listaempresa)
                {
                    listar.dgvLista.Rows.Add(kappa2.Nome, kappa2.Telefone);
                   
                   
                }
            }

            listar.Show();
        }
    }
}
