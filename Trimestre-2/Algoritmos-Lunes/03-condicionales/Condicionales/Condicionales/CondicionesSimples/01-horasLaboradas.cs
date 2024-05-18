using Condicionales.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales.CondicionesSimples
{
    internal class horasLaboradas
    {
        public static void horaslaboradas()
        {
            //Hacer un algoritmo que lea las horas trabajadas el dia de hoy, si 
            //las horas son mas de 8 escriba usted es un esclavo

            string input;
            double horas;

            Console.WriteLine("Programa que determina si es un esclavo o no segun sus horas laboradas");
            Console.WriteLine("Por favor digite la cantidad de horas laboradas");
            input = Console.ReadLine();
            horas = Utils.ValidateNumber(input, false);

            if(horas > 8)
            {
                Console.WriteLine("Usted es un esclavo");
            }
            else
            {
                Console.WriteLine("Usted es un trabajador normal");
            }

        }
    }
}
