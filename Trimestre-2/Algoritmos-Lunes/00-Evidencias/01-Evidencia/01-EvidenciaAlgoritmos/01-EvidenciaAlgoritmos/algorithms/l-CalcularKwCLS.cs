using _01_EvidenciaAlgoritmos.utils;
using System;

namespace _01_EvidenciaAlgoritmos.algorithms
{
    internal class l_CalcularKwCLS
    {
        public static void CalcularKwCLS()
        {
            // La compañía de luz y sombras (CLS) requiere determinar el pago que debe realizar
            // una persona por el consumo de energía eléctrica, la cual se mide en kilowatts (KW).
            // Realice un diagrama de flujo y pseudocódigo que representen el algoritmo que
            // permita determinar ese pago.
            string input;
            double valorKw, kw;
            Console.WriteLine("Programa para determinar el cobro que tendrá una persona por el consumo de energía eléctrica\n");

            Console.WriteLine("Por favor, digite el costo por kilowatts (KW)");
            input = Console.ReadLine();
            valorKw = Utils.ValidateNumber(input, false);

            Console.WriteLine("Por favor, digite la cantidad de kilowatts consumidos");
            input = Console.ReadLine();
            kw = Utils.ValidateNumber(input, false);

            Console.WriteLine($"\nEl valor a pagar es -> {Utils.Rounded(valorKw * kw)}");

            Utils.endAlgorithm(l_CalcularKwCLS.CalcularKwCLS);

        }
    }
}
