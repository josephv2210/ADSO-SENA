using _02_EvideciaAlgoritmos.utils;
using System;

namespace _02_EvideciaAlgoritmos.algorithms
{
    internal class _1_derechoVoto
    {
        public static void DerechoVoto()
        {
            //Realice un algoritmo para determinar si una persona puede votar con base en su edad en
            //las próximas elecciones. Construya el diagrama de flujo, el pseudocódigo y el diagrama N/S.

            string input;
            double edad;

            System.Console.WriteLine("Programa para determinar si una persona puede votar o no");
            System.Console.WriteLine("Digite su edad");
            input = Console.ReadLine();
            edad = Utils.ValidateNumber(input, false);
            if (edad >= 18)
            {
                System.Console.WriteLine("Puede votar");
            }
            else
            {
                System.Console.WriteLine("No puede votar");
            }
            Utils.endAlgorithm(_1_derechoVoto.DerechoVoto);

        }
    }
}
