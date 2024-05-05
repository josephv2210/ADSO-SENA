using _01_EvidenciaAlgoritmos.utils;
using System;

namespace _01_EvidenciaAlgoritmos.algorithms
{
    internal class c_AreaTriangulo
    {
        public static void AreaTriangulo()
        {
            // Realice un diagrama de flujo y pseudocódigo que representen el algoritmo para obtener el área de un triángulo.
            string input;
            double h = 0, b = 0;
            Console.WriteLine("Programa para determinar el área de un triángulo\n");

            Console.WriteLine("Digite la base del triángulo");
            input = Console.ReadLine();
            b = Utils.ValidateNumber(input, false);

            Console.WriteLine("Digite la altura del triángulo");
            input = Console.ReadLine();
            h = Utils.ValidateNumber(input, false);

            Console.WriteLine($"\nEl área es {Utils.Rounded((b * h) / 2)}");

            Utils.endAlgorithm(c_AreaTriangulo.AreaTriangulo);
        }
    }
}
