using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Clientes
    {
        private string email;
        private int contribuinte;
        private string morada;
        private string nome;
        private string localidade;
        private string postal;
        private int telefone;

        public string Email { get => email; set => email = value; }
        public int Contribuinte { get => contribuinte; set => contribuinte = value; }
        public string Morada { get => morada; set => morada = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Localidade { get => localidade; set => localidade = value; }
        public string Postal { get => postal; set => postal = value; }
        public int Telefone { get => telefone; set => telefone = value; }
    }

    class Particular: Clientes
    {

    }

    class Empresa: Clientes
    {
        private int cae;

        public int Cae { get => cae; set => cae = value; }
    }
}
