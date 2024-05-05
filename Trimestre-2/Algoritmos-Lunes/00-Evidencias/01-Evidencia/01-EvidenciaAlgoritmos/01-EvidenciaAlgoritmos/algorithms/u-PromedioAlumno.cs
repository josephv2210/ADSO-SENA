using _01_EvidenciaAlgoritmos.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EvidenciaAlgoritmos.algorithms
{
    internal class u_PromedioAlumno
    {
        public static void PromedioAlumno()
        {
            // Realice el diagrama de flujo y pseudocódigo que representen el algoritmo para
            // determinar el promedio que obtendrá un alumno considerando que realiza tres
            // exámenes, de los cuales el primero y el segundo tienen una ponderación del 25%,
            // mientras que el tercero del 50%.

            string input;
            double Examen1, Examen2, Examen3;
            Console.WriteLine("Programa para calcular el promedio del estudiante\n");

            Console.WriteLine("Digite la nota del primer examen");
            input = Console.ReadLine();
            Examen1 = Utils.ValidateNumber(input, false);

            Console.WriteLine("Digite la nota del segundo examen");
            input = Console.ReadLine();
            Examen2 = Utils.ValidateNumber(input, false);

            Console.WriteLine("Digite la nota del tercer examen");
            input = Console.ReadLine();
            Examen3 = Utils.ValidateNumber(input, false);

            Console.WriteLine($"\nEl promedio del alumno es -> {Utils.Rounded((Examen1 * 0.25) + (Examen2 * 0.25) + (Examen3 * 0.5))}");

            Utils.endAlgorithm(u_PromedioAlumno.PromedioAlumno);

        }
    }
}
