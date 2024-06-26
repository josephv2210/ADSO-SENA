﻿using _01_EvidenciaAlgoritmos.utils;
using System;

namespace _01_EvidenciaAlgoritmos.algorithms
{
    internal class e_AgeCalculator
    {
        public static void AgeCalculator()
        {
            // Una empresa que contrata personal requiere determinar la edad de las personas que solicitan trabajo, pero cuando se les realiza la entrevista sólo se les pregunta el año en que nacieron. 
            // Realice el diagrama de flujo y pseudocódigo que representen el algoritmo para solucionar este problema.
            string input;
            int today = DateTime.Now.Year;
            double birthYear;
            Console.WriteLine("Programa para determinar la edad de las personas\n");

            Console.WriteLine("Digite el año de nacimiento");
            input = Console.ReadLine();
            birthYear = Utils.ValidateNumber(input, false);

            while (today - birthYear < 0)
            {
                Console.WriteLine("El año dado no puede ser mayor al año actual");
                Console.WriteLine("Por favor, digite el año de nacimiento nuevamente");
                input = Console.ReadLine();
                birthYear = Utils.ValidateNumber(input, false);
            }

            Console.WriteLine($"\nLa edad es -> {today - birthYear}");

            Utils.endAlgorithm(e_AgeCalculator.AgeCalculator);
        }
    }
}
