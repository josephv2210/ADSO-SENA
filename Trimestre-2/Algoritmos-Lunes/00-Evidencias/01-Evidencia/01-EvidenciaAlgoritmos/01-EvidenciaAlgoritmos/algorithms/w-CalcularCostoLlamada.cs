using _01_EvidenciaAlgoritmos.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EvidenciaAlgoritmos.algorithms
{
    internal class w_CalcularCostoLlamada
    {
        public static void CalcularCostoLlamada()
        {
            // Se requiere un algoritmo para determinar el costo que tendrá realizar una llamada
            // telefónica con base en el tiempo que dura la llamada y en el costo por minuto.
            // Represente la solución mediante el diagrama de flujo y pseudocódigo.

            string input;
            double valorMinuto, minutos;
            Console.WriteLine("Programa para determinar el costo de realizar una llamada telefónica\n");

            Console.WriteLine("Por favor, digite el costo por minuto");
            input = Console.ReadLine();
            valorMinuto = Utils.ValidateNumber(input, false);

            Console.WriteLine("Por favor, digite la cantidad de minutos consumidos");
            input = Console.ReadLine();
            minutos = Utils.ValidateNumber(input, false);

            Console.WriteLine($"\nEl valor a pagar es -> {Utils.Rounded(valorMinuto * minutos)}");

            Utils.endAlgorithm(w_CalcularCostoLlamada.CalcularCostoLlamada);

        }
    }
}
