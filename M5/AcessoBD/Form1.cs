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

namespace AcessoBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //guardar o caminho numa string
            string strconnection = "server = localhost;port=3307;" + "database=coiso; uid=root; pwd=root";

            try //caso tudo corra bem fica neste bloco
            {
                //instanciar com a string de conexão
                MySqlConnection con = new MySqlConnection(strconnection);

                //abre database
                con.Open();

                MessageBox.Show("A ligação foi estabelecida");


                con.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi estabelecida\n" + erro);
            }

        }
    }
}
