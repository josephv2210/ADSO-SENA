using _01_EvidenciaAlgoritmos.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EvidenciaAlgoritmos.algorithms
{
    internal class v_CalculoVivido
    {
        public static void CalculoVivido()
        {
            // Realice un diagrama de flujo y pseudocódigo que representen el algoritmo para
            // determinar aproximadamente cuántos meses, semanas, días y horas ha vivido una
            // persona.

            int today = DateTime.Now.Year;
            string input;
            double anio, aniosVividos, mesesVividos, semanasVividos, diasVividos, horasVividos;

            Console.WriteLine("Programa para determinar la edad de las personas\n");
            Console.WriteLine("Digite el año de nacimiento");
            input = Console.ReadLine();
            anio = Utils.ValidateNumber(input, false);

            while (today - anio < 0)
            {
                Console.WriteLine("El año dado no puede ser mayor al año actual");
                Console.WriteLine("Por favor, digite el año de nacimiento nuevamente");
                input = Console.ReadLine();
                anio = Utils.ValidateNumber(input, false);
            }

            aniosVividos = (today - anio);
            mesesVividos = aniosVividos * 12;
            semanasVividos = mesesVividos * 4;
            diasVividos = semanasVividos * 7;
            horasVividos = diasVividos * 24;

            Console.WriteLine($"Años vividos........... {aniosVividos}");
            Console.WriteLine($"Meses vividos.......... {mesesVividos}");
            Console.WriteLine($"Semanas vividas.......... {semanasVividos}");
            Console.WriteLine($"Días vividos........... {diasVividos}");
            Console.WriteLine($"Horas vividas.......... {horasVividos}");

            Utils.endAlgorithm(v_CalculoVivido.CalculoVivido);

        }
    }
}
