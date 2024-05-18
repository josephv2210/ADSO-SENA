using _02_EvideciaAlgoritmos.utils;
using System;

namespace _02_EvideciaAlgoritmos.algorithms
{
    internal class _3_comprarRegalo
    {
        public static void ComprarRegalo()
        {
            /*El 14 de febrero una persona desea comprarle un regalo al ser querido que más aprecia
            en ese momento, su dilema radica en qué regalo puede hacerle, las alternativas que tiene
            son las siguientes: Regalo Costo Tarjeta $10.00 o menos Chocolates $11.00 a $100.00 Flores
            $101.00 a $250.00 Anillo Más de $251.00 Se requiere un diagrama de flujo con el algoritmo
            que ayude a determinar qué regalo se le puede comprar a ese ser tan especial por el día del
            amor y la amistad.*/

            double presupuesto;
            string input, regalo;

            Console.WriteLine("Programa para determinar el regalo segun el presupuesto");
            Console.WriteLine("Por favor digite el presupuesto");
            input = Console.ReadLine();
            presupuesto = Utils.ValidateNumber(input, false);

            if (presupuesto <= 10)
            {
                regalo = " una tarjeta";
            }
            else if (presupuesto <= 100)
            {
                regalo = " unos chocolates";
            }
            else if (presupuesto <= 250)
            {
                regalo = " unas flores";
            }
            else
            {
                regalo = " un anillo";
            }

            Console.WriteLine($"El mejor regalo para su presupuesto es{regalo}");

            Utils.endAlgorithm(_3_comprarRegalo.ComprarRegalo);
        }
    }
}
