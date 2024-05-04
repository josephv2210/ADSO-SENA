using _01_EvidenciaAlgoritmos.utils;
using System;

namespace _01_EvidenciaAlgoritmos.algorithms
{
    internal class a_hipotenusaTriangulo
    {
        public static void HipotenusaTriangulo()
        {
            // Realice el pseudocódigo de un programa que sirva para determinar la hipotenusa de un triángulo rectángulo
            string input;
            double a = 0, b = 0;
            Console.WriteLine("Programa para para determinar la hipotenusa de un triángulo rectángulo\n");

            Console.WriteLine("Digite el lado a del triangulo");
            input = Console.ReadLine();
            a = Utils.ValidateNumber(input, false);

            Console.WriteLine("Digite el lado b del triangulo");
            input = Console.ReadLine();
            b = Utils.ValidateNumber(input, false);

            Console.WriteLine($"\nLa hipotenusa del triangulo rectangulo es {Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2)))}");

            Utils.endAlgorithm(a_hipotenusaTriangulo.HipotenusaTriangulo);
        }
    }
}
