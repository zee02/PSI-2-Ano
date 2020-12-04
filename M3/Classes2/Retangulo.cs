using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class Retangulo
    {
        public double largura;
        public double altura;
        



        public double Area()
        {

            return altura * largura;
        }

        public double perimetro()
        {

            return 2*(altura + largura);
        }

        public double diagonal()
        {
            double d ;

           return d = Math.Sqrt(altura * altura) + (largura * largura);
           

        }
    }

}
