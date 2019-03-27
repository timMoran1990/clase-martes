using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operaciones
{
   public class div
    {
        private double d1, d2, resultado;

        public double Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public double D2
        {
            get { return d2; }
            set { d2 = value; }
        }

        public double D1
        {
            get { return d1; }
            set { d1 = value; }
        }



        public double calcular()
        {
            resultado = d1 / d2;
            return resultado;
        }
    }
}
