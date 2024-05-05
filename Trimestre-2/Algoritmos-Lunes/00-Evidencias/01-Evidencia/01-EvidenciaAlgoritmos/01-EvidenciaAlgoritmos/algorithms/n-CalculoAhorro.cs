using _01_EvidenciaAlgoritmos.utils;
using System;

namespace _01_EvidenciaAlgoritmos.algorithms
{
    internal class n_CalculoAhorro
    {
        public static void CalculoAhorro()
        {
            // Realice un diagrama de flujo y pseudocódigo que representen el algoritmo para
            // determinar cuánto dinero ahorra una persona en un año si considera que cada
            // semana ahorra el 15% de su sueldo (considere cuatro semanas por mes y que no
            // cambia el sueldo).
            string input;
            double sueldo;
            Console.WriteLine("Programa para determinar cuánto ahorra una persona en un año\n");

            Console.WriteLine("Por favor, digite el valor total del sueldo");
            input = Console.ReadLine();
            sueldo = Utils.ValidateNumber(input, false);

            Console.WriteLine($"\nCantidad ahorrada semanalmente -> {Utils.Rounded(sueldo * 0.15)}");
            Console.WriteLine($"\nEl valor ahorrado en un año es -> {Utils.Rounded((sueldo * 0.15) * 4 * 12)}");

            Utils.endAlgorithm(n_CalculoAhorro.CalculoAhorro);

        }
    }
}
