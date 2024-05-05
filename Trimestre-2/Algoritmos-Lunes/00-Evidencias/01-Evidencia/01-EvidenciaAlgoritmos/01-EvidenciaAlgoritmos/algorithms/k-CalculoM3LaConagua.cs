using _01_EvidenciaAlgoritmos.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EvidenciaAlgoritmos.algorithms
{
    internal class k_CalculoM3LaConagua
    {
        public static void CalculoM3LaConagua()
        {
            //La CONAGUA requiere determinar el pago que debe realizar una persona por el total
            //de metros cúbicos que consume de agua. Realice un diagrama de flujo y
            //pseudocódigo que representen el algoritmo que permita determinar ese pago.

            string input;
            double valorKm, km;
            Console.WriteLine("Programa para determinar el cobro que tendra una persona por el total de metros cúbicos que consume de agua\n");

            Console.WriteLine("Por favor digite el valor del kilometro");
            input = Console.ReadLine();
            valorKm = Utils.ValidateNumber(input, false);

            Console.WriteLine("Por favor digite la cantidad de kilometros a recorrer");
            input = Console.ReadLine();
            km = Utils.ValidateNumber(input, false);



            Console.WriteLine($"\nEl valor a pagar es es -> {valorKm * km}");

            Utils.endAlgorithm(k_CalculoM3LaConagua.CalculoM3LaConagua);
        }
    }
}
