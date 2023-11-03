using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_validacion
{
    internal class Calculadora
    {
         
        double n1;
        double n2;

        
        public double N1 { get => n1; set => n1 = value; }
        public double N2 { get => n2; set => n2 = value; }


   
        public double Suma()
        {
            double sumar = this.N1 + this.N2;
            return (sumar);
        }

        public double Resta()
        {
            double Resta = this.N1 - this.N2;
            return (Resta);
        }


        public double Division()
        {
            double Dividir = this.N1 / this.N2;
            return (Dividir);
        }



        public double Multiplicacion()
        {
            double resultado = this.n1 * this.n2;
            return (resultado);
        }
    }
}
