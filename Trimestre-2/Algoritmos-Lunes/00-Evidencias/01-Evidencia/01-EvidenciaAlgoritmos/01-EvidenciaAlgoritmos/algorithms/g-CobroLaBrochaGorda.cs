using _01_EvidenciaAlgoritmos.utils;
using System;

namespace _01_EvidenciaAlgoritmos.algorithms
{
    internal class g_CobroLaBrochaGorda
    {
        public static void CobroLaBrochaGorda()
        {
            // Pinturas "La brocha gorda" requiere determinar cuánto cobrar por trabajos de
            // pintura. Considere que se cobra por m2 y realice un diagrama de flujo y
            // pseudocódigo que representen el algoritmo que le permita ir generando
            // presupuestos para cada cliente.
            string input;
            double valorM2, m2;
            Console.WriteLine("Programa para determinar el cobro por trabajo\n");

            Console.WriteLine("Por favor, digite el costo por metro cuadrado");
            input = Console.ReadLine();
            valorM2 = Utils.ValidateNumber(input, false);

            Console.WriteLine("Por favor, digite la cantidad de metros cuadrados a pintar");
            input = Console.ReadLine();
            m2 = Utils.ValidateNumber(input, false);

            Console.WriteLine($"\nEl valor a pagar es -> {Utils.Rounded(valorM2 * m2)}");

            Utils.endAlgorithm(g_CobroLaBrochaGorda.CobroLaBrochaGorda);
        }
    }
}
