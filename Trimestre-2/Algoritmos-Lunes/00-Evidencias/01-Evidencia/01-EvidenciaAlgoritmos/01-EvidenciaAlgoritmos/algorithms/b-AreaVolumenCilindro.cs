using _01_EvidenciaAlgoritmos.utils;
using System;

namespace _01_EvidenciaAlgoritmos.algorithms
{
    internal class b_AreaVolumenCilindro
    {
        public static void AreaVolumenCilindro()
        {
            //Desarrolla un algoritmo (pseudocódigo) que permita determinar el área y volumen de un cilindro
            string input;
            double h = 0, r = 0, area = 0, volumen = 0;
            Console.WriteLine("Programa para determinar el area y el volumen de un cilindro\n");

            Console.WriteLine("Digite el radio del cilindro");
            input = Console.ReadLine();
            r = Utils.ValidateNumber(input, false);

            Console.WriteLine("Digite la altura del cilindro");
            input = Console.ReadLine();
            h = Utils.ValidateNumber(input, false);

            area = (2 * Math.PI * (Math.Pow(r, 2))) + (2 * Math.PI * r * h);
            volumen = Math.PI * Math.Pow(r, 2) * h;


            Console.WriteLine($"\nEl area del cilindro es -> {area}");
            Console.WriteLine($"El volumen del cilindro es -> {volumen}");
            Utils.endAlgorithm(b_AreaVolumenCilindro.AreaVolumenCilindro);

        }
    }
}
