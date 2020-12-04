using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CriarUtilizadores
{
    class ModeloBD
    {
        private int id;
        private string nome;
        private string senha;
        private string email;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Email { get => email; set => email = value; }
    }
}
