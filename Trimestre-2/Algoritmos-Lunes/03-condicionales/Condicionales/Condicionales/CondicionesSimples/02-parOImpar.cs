using Condicionales.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales.CondicionesSimples
{
    internal class _02_parOImpar
    {
        public static void parImpar()
        {
            string input;
            double num;
            
            Console.WriteLine("Programa para determinar si un numero es par o impar");
            Console.WriteLine("Digite el número");
            input = Console.ReadLine();

            num = Utils.ValidateNumber(input, true);

            if (num % 2 == 0)
            {
                Console.WriteLine("Es par");
            } 
            else
            {
                Console.WriteLine("Es impar");
            }

            Utils.endAlgorithm(_02_parOImpar.parImpar);
        }
    }
}
