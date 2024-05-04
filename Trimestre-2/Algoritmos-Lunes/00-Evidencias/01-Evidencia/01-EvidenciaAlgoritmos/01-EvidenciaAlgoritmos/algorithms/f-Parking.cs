using _01_EvidenciaAlgoritmos.utils;
using System;

namespace _01_EvidenciaAlgoritmos.algorithms
{
    internal class f_Parking
    {
        public static void Parking()
        {
            //Un estacionamiento requiere determinar el cobro que debe aplicar a las personas
            //que lo utilizan. Considere que el cobro es con base en las horas que lo disponen y
            //que las fracciones de hora se toman como completas y realice un diagrama de flujo
            //y pseudocódigo que representen el algoritmo que permita determinar el cobro.

            string input;
            double valorHora, horas;
            Console.WriteLine("Programa para determinar el cobro por hora de un parqueadero");

            Console.WriteLine("Por favor digite el valor de la hora");
            input = Console.ReadLine();
            valorHora = Utils.ValidateNumber(input, false);

            Console.WriteLine("Por favor digite la cantidad de horas que duro el vehiculo en el parqueadero");
            input = Console.ReadLine();
            horas = Utils.ValidateNumber(input, false);



            Console.WriteLine($"El valor a pagar es es -> {valorHora * horas}");

            Console.ReadKey();
        }
    }
}
