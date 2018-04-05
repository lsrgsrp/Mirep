using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videos
{
    class Program
    {
        static void Main(string[] args) {

            int numero1 = 4;
            int numero2 = 8;
            double promedio = CalcularPromedio(numero1, numero2);
            Console.Read();    
        }

        private static double CalcularPromedio(int numero1, int numero2)
        {
            return (numero1 + numero2) / 2.0;
        }
    }
}
