using _01_EvidenciaAlgoritmos.utils;
using System;

namespace _01_EvidenciaAlgoritmos.algorithms
{
    internal class t_AreaCuadrado
    {
        public static void AreaCuadrado()
        {
            // Realice el diagrama de flujo y pseudocódigo que representen el algoritmo para
            // encontrar el área de un cuadrado.
            string input;
            double lado;
            Console.WriteLine("Programa para determinar el área de un cuadrado\n");

            Console.WriteLine("Por favor, digite el lado en cm");
            input = Console.ReadLine();
            lado = Utils.ValidateNumber(input, false);

            Console.WriteLine($"\nEl área del cuadrado es -> {Utils.Rounded(lado * lado)} cm^2");

            Utils.endAlgorithm(t_AreaCuadrado.AreaCuadrado);
        }
    }
}
