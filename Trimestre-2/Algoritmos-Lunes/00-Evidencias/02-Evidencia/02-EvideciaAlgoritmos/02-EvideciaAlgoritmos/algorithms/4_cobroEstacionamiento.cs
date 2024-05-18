using _02_EvideciaAlgoritmos.utils;
using System;

namespace _02_EvideciaAlgoritmos.algorithms
{
    internal class _4_cobroEstacionamiento
    {
        public static void CobroEstacionamiento()
        {
            /*El dueño de un estacionamiento requiere un diagrama de flujo con el algoritmo que le
            permita determinar cuánto debe cobrar por el uso del estacionamiento a sus clientes. Las
            tarifas que se tienen son las siguientes: Las dos primeras horas a $5.00 c/u. Las siguientes
            tres a $4.00 c/u. Las cinco siguientes a $3.00 c/u. Después de diez horas el costo por cada
            una es de dos pesos.*/

            double horas, total=0;
            string input;

            Console.WriteLine("Programa para determinar cúanto debe cobrar por el uso del estacionamiento");
            Console.WriteLine("Por favor digite la cantidad de horas que estuvo en el parqueadero");
            input = Console.ReadLine();
            horas = Utils.ValidateNumber(input, false);

            if(horas <= 2)
            {
                total = horas * 5;
            }
            else
            {
                total = total + (3 * 4);
                if(horas <= 10)
                {
                    total = total + ((horas - 5) * 3);
                }
                else
                {
                    total = total + (5 * 3) + ((horas - 10) * 2);
                }
            }

            Console.WriteLine($"El valor total a pagar es {total}");

            Utils.endAlgorithm(_4_cobroEstacionamiento.CobroEstacionamiento);
        }
    }
}
