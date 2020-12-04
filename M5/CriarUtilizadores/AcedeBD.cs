using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CriarUtilizadores
{
    class AcedeBD
    {
       public void Registo (ModeloBD modelo)
        {
            string strconnection = "server = localhost; port = 3307;" + "database=diagnostico; uid=root; pwd=root";

            try
            {
                MySqlConnection con = new MySqlConnection(strconnection);

                con.Open();

                string verifica = "select * from utilizador where " +
                    "nome = @nnome " +
                    "senha = @nsenha" + " and email = @nemail";

                MySqlCommand comandosve = new MySqlCommand(verifica, con);

                comandosve.Parameters.AddWithValue("@nnome", modelo.Nome);
                comandosve.Parameters.AddWithValue("@nsenha", modelo.Senha);
                comandosve.Parameters.AddWithValue("@nemail", modelo.Email);
                /* ou 
                 * string verifica = "select * from acesso where utilizador = ('" + modelo.Nome + 
                 * and palavrachave = ('" + modelo.Pw + "')";
                 * assim não precisavamos de usar parametros
                 */

                MySqlDataAdapter da = new MySqlDataAdapter(comandosve);

                DataTable tabela = new DataTable();

                da.Fill(tabela);

                comandosve.Dispose();

                if (tabela.Rows.Count == 1)
                {
                    System.Windows.Forms.MessageBox.Show("Já Existe");
                }
                else
                {
                    string inserir = "Insert INTO utilizador(nome, email, senha)" + "values('" + modelo.Nome + "' , '" + modelo.Email + "', '" + modelo.Senha+ "')";

                    MySqlCommand comandos = new MySqlCommand(inserir, con);


                    comandos.ExecuteNonQuery();

                    System.Windows.Forms.MessageBox.Show("Utilizador registado.", "", System.Windows.Forms.MessageBoxButtons.OK);

                    con.Close();

                }
            }
            catch (Exception erro)
            {
                System.Windows.Forms.MessageBox.Show("Não foi estabelecida ligação \n" + erro);
            }
            }
             
        }
    }

