using _01_EvidenciaAlgoritmos.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EvidenciaAlgoritmos.algorithms
{
    internal class h_HipotenusaTriangulo2
    {
        public static void HipotenusaTriangulo2()
        {
            //. Se requiere determinar la hipotenusa de un triángulo rectángulo. ¿Cómo sería el
            //diagrama de flujo y el pseudocódigo que representen el algoritmo para obtenerla?
            //Recuerde que por Pitágoras se tiene que: C2 = A2 + B2 . 2.7
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
