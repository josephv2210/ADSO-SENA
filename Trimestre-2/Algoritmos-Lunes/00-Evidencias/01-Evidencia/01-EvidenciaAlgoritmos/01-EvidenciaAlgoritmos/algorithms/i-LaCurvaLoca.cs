using _01_EvidenciaAlgoritmos.utils;
using System;

namespace _01_EvidenciaAlgoritmos.algorithms
{
    internal class i_LaCurvaLoca
    {
        public static void LaCurvaLoca()
        {
            // La compañía de autobuses "La curva loca" requiere determinar el costo que tendrá
            // el boleto de un viaje sencillo, esto basado en los kilómetros por recorrer y en el costo
            // por kilómetro. Realice un diagrama de flujo y pseudocódigo que representen el
            // algoritmo para tal fin.
            string input;
            double valorKm, km;
            Console.WriteLine("Programa para determinar el costo que tendrá el boleto de un viaje sencillo\n");

            Console.WriteLine("Por favor, digite el valor del kilómetro");
            input = Console.ReadLine();
            valorKm = Utils.ValidateNumber(input, false);

            Console.WriteLine("Por favor, digite la cantidad de kilómetros a recorrer");
            input = Console.ReadLine();
            km = Utils.ValidateNumber(input, false);

            Console.WriteLine($"\nEl valor a pagar es -> {Utils.Rounded(valorKm * km)}");

            Utils.endAlgorithm(i_LaCurvaLoca.LaCurvaLoca);

        }
    }
}
