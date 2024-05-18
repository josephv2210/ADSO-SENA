using _02_EvideciaAlgoritmos.utils;
using System;

namespace _02_EvideciaAlgoritmos.algorithms
{
    internal class _13_viajeEstudios
    {
        public static void ViajeEstudios()
        {
            /*Realice un algoritmo para determinar el sueldo semanal de un trabajador con base en las
            horas trabajadas y el pago por hora, considerando que después de las 40 horas cada hora se
            considera como excedente y se paga el doble. Construya el diagrama de flujo, el
            pseudocódigo y el diagrama N/ S.*/

            double horas, pagoHora, extras;
            string input;

            Console.WriteLine("Programa para determinar el sueldo semanal");
            Console.WriteLine("Por favor digite la cantidad de horas");
            input = Console.ReadLine();
            horas = Utils.ValidateNumber(input, false);

            Console.WriteLine("Por favor digite el pago de la hora");
            input = Console.ReadLine();
            pagoHora = Utils.ValidateNumber(input, false);

            Utils.endAlgorithm(_13_viajeEstudios.ViajeEstudios);
        }
    }
}
