using _01_EvidenciaAlgoritmos.utils;
using System;

namespace _01_EvidenciaAlgoritmos.algorithms
{
    internal class h_HipotenusaTriangulo2
    {
        public static void HipotenusaTriangulo2()
        {
            // Se requiere determinar la hipotenusa de un triángulo rectángulo. ¿Cómo sería el
            // diagrama de flujo y el pseudocódigo que representen el algoritmo para obtenerla?
            // Recuerde que por Pitágoras se tiene que: C^2 = A^2 + B^2.
            string input;
            double a = 0, b = 0;
            Console.WriteLine("Programa para determinar la hipotenusa de un triángulo rectángulo\n");

            Console.WriteLine("Digite el lado a del triángulo");
            input = Console.ReadLine();
            a = Utils.ValidateNumber(input, false);

            Console.WriteLine("Digite el lado b del triángulo");
            input = Console.ReadLine();
            b = Utils.ValidateNumber(input, false);

            Console.WriteLine($"\nLa hipotenusa del triángulo rectángulo es {Utils.Rounded(Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2))))}");

            Utils.endAlgorithm(h_HipotenusaTriangulo2.HipotenusaTriangulo2);

        }
    }
}
