using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Exercicio
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        InsereValores carros = new InsereValores();


        MySqlConnection connection = new MySqlConnection("server = localhost; port = 3306;" + "database=carros; uid=root; pwd=root ");

        MySqlCommand comando;



        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Olá! Por favor clique no botão Visualizar para conseguir inserir dados. Obrigado1", "Antes de começar...", MessageBoxButtons.OK);
            carros.Show();
            
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
           

            if (string.IsNullOrEmpty(carros.mtbAno.Text) || string.IsNullOrEmpty(carros.cmbCateg.Text) || string.IsNullOrEmpty(carros.cmbComb.Text) || string.IsNullOrEmpty(carros.txtMarcas.Text) || string.IsNullOrEmpty(carros.txtModelo.Text) || string.IsNullOrEmpty(carros.mtbPreco.Text) || string.IsNullOrEmpty(carros.cmbTipo.Text) || string.IsNullOrEmpty(carros.mtbCili.Text))
            {
                MessageBox.Show("Tens de inserir todos os campos antes de guardar!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                
                string insertQuery = "INSERT INTO encomenda(Marca,Modelo,Categoria,Combustivel,Cilindrada,Tipo,Ano,Preco) VALUES('" + carros.txtMarcas.Text + "', '" + carros.txtModelo.Text + "', '" + carros.cmbCateg.Text + "', '" + carros.cmbComb.Text + "', " + carros.mtbCili.Text + ", '" + carros.cmbTipo.Text + "', " + carros.mtbAno.Text + ", " + carros.mtbPreco.Text + ")";
                executa(insertQuery);
                insereDGV();

                verifica();
                carros.txtRegisto.Text = "";
                carros.mtbAno.Text = "";
                carros.txtModelo.Text = "";
                carros.txtMarcas.Text = "";
                carros.mtbPreco.Text = "";
                carros.mtbCili.Text = "";
                carros.cmbCateg.SelectedIndex = -1;
                carros.cmbComb.SelectedIndex = -1;
                carros.cmbTipo.SelectedIndex = -1;



            }
        }
        public void insereDGV()
        {

            string selectQuery = "SELECT * FROM encomenda";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dgvMostraa.DataSource = table;
        }

        private void DgvMostraa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        public void openCon()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeCon()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void executa(string query)
        {
            try
            {
                openCon();
                comando = new MySqlCommand(query, connection);

                if (comando.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executada");
                }

                else
                {
                    MessageBox.Show("Query não Executada");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeCon();
            }
        }

        private void BtnAltera_Click(object sender, EventArgs e)
        {
           

            if (carros.txtRegisto.Text != "")
            {
      
                carros.txtRegisto.Enabled = true;
                string editarQuery = "UPDATE encomenda SET Marca ='" + carros.txtMarcas.Text + "', Modelo = '" + carros.txtModelo.Text + "', Categoria= '" + carros.cmbCateg.Text + "', Combustivel = '" + carros.cmbComb.Text + "', Cilindrada = " + carros.mtbCili.Text + ", Tipo = '" + carros.cmbTipo.Text + "', Ano = " + carros.mtbAno.Text + ", Preco = " + carros.mtbPreco.Text + " WHERE registo =" + int.Parse(carros.txtRegisto.Text);
                executa(editarQuery);
                insereDGV();

                verifica();
                carros.txtRegisto.Text = "";
                carros.mtbAno.Text = "";
                carros.txtModelo.Text = "";
                carros.txtMarcas.Text = "";
                carros.mtbCili.Text = "";
                carros.mtbPreco.Text = "";
                carros.cmbCateg.SelectedIndex = -1;
                carros.cmbComb.SelectedIndex = -1;
                carros.cmbTipo.SelectedIndex = -1;
               
            }
            else
                MessageBox.Show("Antes de alterares, tens de passar os dados para o outro form, clicando nos mesmos!", "Aviso!", MessageBoxButtons.OK);
        }

        private void BtnElimina_Click(object sender, EventArgs e)
        {
            

            if (carros.txtRegisto.Text != "")
            {
               
                string eliminarQuery = "DELETE FROM encomenda WHERE registo = " + int.Parse(carros.txtRegisto.Text);
                executa(eliminarQuery);
                insereDGV();

                verifica();
                carros.txtRegisto.Text = "";
                carros.mtbAno.Text = "";
                carros.txtModelo.Text = "";
                carros.txtMarcas.Text = "";
                carros.mtbCili.Text = "";
                carros.mtbPreco.Text = "";
                carros.cmbCateg.SelectedIndex = -1;
                carros.cmbComb.SelectedIndex = -1;
                carros.cmbTipo.SelectedIndex = -1;
              

            }
            else
                MessageBox.Show("Antes de eliminares, tens de passar os dados para o outro form, clicando nos mesmos!", "Aviso!", MessageBoxButtons.OK);

        }

        private void BtnVisualiza_Click(object sender, EventArgs e)
        {
          
            insereDGV();
            btnGuardar.Enabled = true;
            btnVisualiza.Enabled = false;
            carros.mtbAno.Enabled = true;
            carros.cmbCateg.Enabled = true;
            carros.mtbCili.Enabled = true;
            carros.cmbComb.Enabled = true;
            carros.txtMarcas.Enabled = true;
            carros.txtModelo.Enabled = true;
            carros.mtbPreco.Enabled = true;
            carros.cmbTipo.Enabled = true;
            verifica();

           

        }

        private void dgvMostraa_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMostraa_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {


            carros.txtRegisto.Text = dgvMostraa.CurrentRow.Cells[0].Value.ToString();
            carros.txtMarcas.Text = dgvMostraa.CurrentRow.Cells[1].Value.ToString();
            carros.txtModelo.Text = dgvMostraa.CurrentRow.Cells[2].Value.ToString();
            carros.cmbCateg.Text = dgvMostraa.CurrentRow.Cells[3].Value.ToString();
            carros.cmbComb.Text = dgvMostraa.CurrentRow.Cells[4].Value.ToString();
            carros.mtbCili.Text = dgvMostraa.CurrentRow.Cells[5].Value.ToString();
            carros.cmbTipo.Text = dgvMostraa.CurrentRow.Cells[6].Value.ToString();
            carros.mtbAno.Text = dgvMostraa.CurrentRow.Cells[7].Value.ToString();
            carros.mtbPreco.Text = dgvMostraa.CurrentRow.Cells[8].Value.ToString();
        }


        public void verifica()
        {
            if (dgvMostraa.Rows.Count == 0)
            {
                btnAltera.Enabled = false;
                btnElimina.Enabled = false;

            }
            else
            {
                btnElimina.Enabled = true;
                btnAltera.Enabled = true;
            }

        }

    }
}

