using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales.utils
{
    internal class Utils
    {
        public static double ValidateNumber(string input, bool negativeAcept)
        {
            double num;

            if (double.TryParse(input, out num))
            {
                num = double.Parse(input);

                if (negativeAcept || num > 0)
                {
                    return num;
                }
                else
                {
                    Console.WriteLine("Número inválido, el número no puede ser negativo. Ingrese uno nuevo:");
                    string newInput = Console.ReadLine();
                    return ValidateNumber(newInput, negativeAcept);
                }
            }
            else
            {
                Console.WriteLine("Número inválido. Ingrese uno nuevo:");
                string newInput = Console.ReadLine();
                return ValidateNumber(newInput, negativeAcept);
            }
        }

        public delegate void funcionDeProcesamiento();

        public static void endAlgorithm(funcionDeProcesamiento function)
        {
            string option;
            Console.WriteLine();
            Console.WriteLine("Ha terminado la ejecución del algoritmo, ¿Deseas ejecutarlo nuevamente?");
            Console.WriteLine("\nDigita 'Si' para repetir el programa");
            Console.WriteLine("Presiona 'Enter' para volver al menu principal");
            option = Console.ReadLine();
            if (option == "Si" || option == "si" || option == "Sí" || option == "sí")
            {
                Console.Clear();
                function();
            }
            else
            {
                Console.Clear();

            }

        }

        public static double Rounded(double value)
        {
            return Math.Round(value, 2);
        }
    }
}
