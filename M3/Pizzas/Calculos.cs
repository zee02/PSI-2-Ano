using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pizzas
{
    class Calculos
    {
        string tipo;
        string tamanho;
        int numero;
        
        public string Tipo { get => tipo; set => tipo = value; }
        public string Tamanho { get => tamanho; set => tamanho = value; }

        public int Numero { get => numero; set => numero = value; }

        public double CalcularValor()
        {
            double calc = 0.0;


            switch (tamanho)

            {
                case "Individual":
                    {
                        switch (tipo)
                        {
                            case "Fina":
                                calc = 4.9 + Numero * 1.0;
                                break;

                            case "Pan":
                                calc = 5.85 + Numero * 1.0;
                                break;

                            case "Rolling":
                                calc = 15.6 + Numero * 1.0;
                                break;
                        }
                        break;
                    }
               case "Media":
                    switch (tipo)
                    {
                        case "Fina":
                            calc = 8.55 + Numero * 1.7;
                            break;

                        case "Pan":
                            calc = 9.65 + Numero * 1.7;
                            break;

                        case "Rolling":
                            calc = 15.6 + Numero * 1.7;
                            break;
                    }
                    break;

                case "Familiar":
                    switch (tipo)
                    {
                        case "Fina":
                            calc = 12.40 + Numero * 2.2;
                            break;

                        case "Pan":
                            calc = 13.65 + Numero * 2.2;
                            break;

                        case "Rolling":
                            calc = 15.6 + Numero * 2.2;
                            break;
                    }
                    break;
            }
            return calc;
        }

    }
}




   

