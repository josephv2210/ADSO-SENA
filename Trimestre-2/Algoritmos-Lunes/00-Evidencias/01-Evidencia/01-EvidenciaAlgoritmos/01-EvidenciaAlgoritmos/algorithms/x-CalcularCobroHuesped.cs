using _01_EvidenciaAlgoritmos.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EvidenciaAlgoritmos.algorithms
{
    internal class x_CalcularCobroHuesped
    {
        public static void CalcularCobroHuesped()
        {
            // El hotel "Cama Arena" requiere determinar lo que le debe cobrar a un huésped por
            // su estancia en una de sus habitaciones. Realice un diagrama de flujo y pseudocódigo
            // que representen el algoritmo para determinar ese cobro.

            string input;
            double valorDia, dias;
            Console.WriteLine("Programa para determinar el cobro que tendrá un huésped por su estancia\n");

            Console.WriteLine("Por favor, digite el costo por día");
            input = Console.ReadLine();
            valorDia = Utils.ValidateNumber(input, false);

            Console.WriteLine("Por favor, digite la cantidad de días que pasó el huésped");
            input = Console.ReadLine();
            dias = Utils.ValidateNumber(input, false);

            Console.WriteLine($"\nEl valor a pagar es -> {Utils.Rounded(valorDia * dias)}");

            Utils.endAlgorithm(x_CalcularCobroHuesped.CalcularCobroHuesped);

        }
    }
}
