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

namespace Projeto_orientado_com_Video
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("server = localhost; port = 3307;" + "database=revisao; uid=root; pwd=root ");


        MySqlCommand comando;

        private void Button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO users(fname,lname,age) VALUES('"+ txtPrim.Text + "', '" +txtUlt.Text + "', "+txtIdade.Text+")";
            executa(insertQuery);
            insereDGV();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            insereDGV();
        }

        public void insereDGV ()
        {
            string selectQuery = "SELECT * FROM users";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView_USERS.DataSource = table;
        }

        private void DataGridView_USERS_MouseClick(object sender, MouseEventArgs e)
        {
            txtID.Text = dataGridView_USERS.CurrentRow.Cells[0].Value.ToString();
            txtPrim.Text = dataGridView_USERS.CurrentRow.Cells[1].Value.ToString();
            txtUlt.Text = dataGridView_USERS.CurrentRow.Cells[2].Value.ToString();
            txtIdade.Text = dataGridView_USERS.CurrentRow.Cells[3].Value.ToString();
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

                if(comando.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executada");
                }

                else
                {
                    MessageBox.Show("Query não Executada");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeCon();
            }
        }

        private void DataGridView_USERS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string editarQuery = "UPDATE users SET fname ='" + txtPrim.Text+ "', lname = '"+txtUlt.Text+"', age="+txtIdade.Text+" WHERE id ="+int.Parse(txtID.Text);
            executa(editarQuery);
            insereDGV();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string eliminarQuery = "DELETE FROM users WHERE id = " + int.Parse(txtID.Text);
            executa(eliminarQuery);
            insereDGV();
        }

        private void BtnProcura_Click(object sender, EventArgs e)
        {
            MySqlDataReader mdr;
            string select = "SELECT * FROM users WHERE id = " + txtID.Text;
            comando = new MySqlCommand(select, connection);
            openCon();
            mdr = comando.ExecuteReader();

            if (mdr.Read())
            {
                txtPrim.Text = mdr.GetString("fname");
                txtUlt.Text = mdr.GetString("lname");
                txtIdade.Text = mdr.GetInt32("age").ToString();

            }
            else
            {
                MessageBox.Show("Utilizador não encontrado");
                txtID.Text = " ";
            }

            closeCon();
        }
    }
}
