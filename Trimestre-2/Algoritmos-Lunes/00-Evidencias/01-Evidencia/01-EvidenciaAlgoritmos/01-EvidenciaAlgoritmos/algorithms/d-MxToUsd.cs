using _01_EvidenciaAlgoritmos.utils;
using System;

namespace _01_EvidenciaAlgoritmos.algorithms
{
    internal class d_MxToUsd
    {
        public static void MxToUsd()
        {
            // Una empresa importadora desea determinar cuántos dólares puede adquirir con equis cantidad de dinero mexicano. Realice un diagrama de flujo y pseudocódigo que representen el algoritmo para tal fin.
            string input;
            double valConversionMxUsd = 17.16, Mx = 0;
            Console.WriteLine("Programa para calcular cuantos dolares puedes adquirir con pesos mexicanos");

            Console.WriteLine("Digite la cantidad de pesos mexicanos");
            input = Console.ReadLine();
            Mx = Utils.ValidateNumber(input, false);

            Console.WriteLine($"La cantidad de dolases que puede comprar con {Mx} son -> {Mx / valConversionMxUsd} ");
            Console.ReadKey();
        }
    }
}
