using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indice_Massa_Corporal
{
    

    class Calculos
    {
        private double imc;
        private double peso;
        private double altura;
        private double saude;
        private int idadee;
        string retorna;
        string retornariscoM;
        string retornariscoF;
        public double Imc { get => imc; set => imc = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Saude { get => saude; set => saude = value; }
        public double Altura { get => altura; set => altura = value; }
        public int Idadee { get => idadee; set => idadee = value; }

        public double iemc()
        {

            imc = peso / (altura * altura);

            return imc;
        }

        public string pesoo()
        {
            

            if (iemc() <= 18.5)
            {
                retorna = "Peso Baixo";
            }

            else if (iemc() <= 24.9)
            {
                retorna = "Peso ideal";
            }

            else if (iemc() <= 29.9)
            {
                retorna = "Obesidade Leve";
            }

            else if (iemc() <= 39.9)
            {
                retorna = "Obesidade Moderada";
            }

            else if (iemc() >= 40)
            {
                retorna = "Obesidade Severa";
            }


            return retorna;
        }

        public string riscoM()
        {
            if (iemc() >= 17.9 && iemc() <= 18.5)
            {
                retornariscoM = "Baixo Risco";
            }

            if (iemc() >= 18.6 && iemc() <= 24.9)
            {
                retornariscoM = "Sem Risco";
            }

            if (iemc() >= 25.0 && iemc() <= 27.7)
            {
                retornariscoM = "Risco Moderado";
            }

            if (iemc() >= 27.8)
            {
                retornariscoM = "Risco Elevado";
            }

            


            return retornariscoM;
        }

        public string riscoF()
        {
            if (iemc() >= 15.0 && iemc() <= 17.9)
            {
                retornariscoF = "Baixo Risco";
            }

            if (iemc() >= 18.0 && iemc() <= 24.9)
            {
                retornariscoF = "Sem Risco";
            }

            if (iemc() >= 25.0 && iemc() <= 27.2)
            {
                retornariscoF = "Risco Moderado";
            }

            if (iemc() >= 27.3)
            {
                retornariscoF = "Risco Elevado";
            }




            return retornariscoF;
        }
    }
}
