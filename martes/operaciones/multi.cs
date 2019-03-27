using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operaciones
{
    public class multi
    {
        private double m1, m2, resultado;

        public double M2
        {
            get { return m2; }
            set { m2 = value; }
        }



        public double Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public double M1
        {
            get { return m1; }
            set { m1 = value; }
        }




        public double calcular()
        {
            resultado = m1 * m2;
            return resultado;
        }
    }
}