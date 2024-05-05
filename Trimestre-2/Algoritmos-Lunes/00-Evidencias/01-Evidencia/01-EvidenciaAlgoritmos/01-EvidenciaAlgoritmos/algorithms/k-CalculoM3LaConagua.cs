using _01_EvidenciaAlgoritmos.utils;
using System;

namespace _01_EvidenciaAlgoritmos.algorithms
{
    internal class k_CalculoM3LaConagua
    {
        public static void CalculoM3LaConagua()
        {
            // La CONAGUA requiere determinar el pago que debe realizar una persona por el total
            // de metros cúbicos que consume de agua. Realice un diagrama de flujo y
            // pseudocódigo que representen el algoritmo que permita determinar ese pago.
            string input;
            double valorM3, m3;
            Console.WriteLine("Programa para determinar el cobro que tendrá una persona por el total de metros cúbicos que consume de agua\n");

            Console.WriteLine("Por favor, digite el valor por metro cúbico");
            input = Console.ReadLine();
            valorM3 = Utils.ValidateNumber(input, false);

            Console.WriteLine("Por favor, digite la cantidad de metros cúbicos a consumir");
            input = Console.ReadLine();
            m3 = Utils.ValidateNumber(input, false);

            Console.WriteLine($"\nEl valor a pagar es -> {Utils.Rounded(valorM3 * m3)}");

            Utils.endAlgorithm(k_CalculoM3LaConagua.CalculoM3LaConagua);

        }
    }
}
