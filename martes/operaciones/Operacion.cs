using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operaciones
{
    public class Operacion
    {
        private double v1, v2, resultado;

        public double V2
        {
            get { return v2; }
            set { v2 = value; }
        }

        public double V1
        {
            get { return v1; }
            set { v1 = value; }
        }

        public double Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public double calcular()
        {
            resultado = v1 + v2;
            return resultado;
        }
         
            
         
    }
}
