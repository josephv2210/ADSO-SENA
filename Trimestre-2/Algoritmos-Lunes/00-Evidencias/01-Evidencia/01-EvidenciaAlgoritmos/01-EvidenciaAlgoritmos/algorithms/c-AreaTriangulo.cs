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
            Console.WriteLine("Programa para determinar el area de un triangulo\n");

            Console.WriteLine("Digite la base del triangulo");
            input = Console.ReadLine();
            b = Utils.ValidateNumber(input, false);

            Console.WriteLine("Digite la altura del triangulo");
            input = Console.ReadLine();
            h = Utils.ValidateNumber(input, false);

            Console.WriteLine($"\nEl area es {(b * h) / 2}");

            Utils.endAlgorithm(c_AreaTriangulo.AreaTriangulo);

        }
    }
}
