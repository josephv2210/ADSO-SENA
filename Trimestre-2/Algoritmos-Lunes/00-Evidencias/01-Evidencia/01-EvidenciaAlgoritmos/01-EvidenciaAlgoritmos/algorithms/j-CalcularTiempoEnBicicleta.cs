using _01_EvidenciaAlgoritmos.utils;
using System;

namespace _01_EvidenciaAlgoritmos.algorithms
{
    internal class j_CalcularTiempoEnBicicleta
    {
        public static void CalcularTiempoEnBicicleta()
        {
            // Se requiere determinar el tiempo que tarda una persona en llegar de una ciudad a
            // otra en bicicleta, considerando que lleva una velocidad constante. Realice un
            // diagrama de flujo y pseudocódigo que representen el algoritmo para tal fin.
            string input;
            double distancia, velocidad;
            Console.WriteLine("Programa para determinar el tiempo que le toma a una persona llegar de una ciudad a otra\n");

            Console.WriteLine("Por favor, digite la distancia entre una ciudad y la otra en km");
            input = Console.ReadLine();
            distancia = Utils.ValidateNumber(input, false);

            Console.WriteLine("Por favor, digite la velocidad de la bicicleta en km/h");
            input = Console.ReadLine();
            velocidad = Utils.ValidateNumber(input, false);

            Console.WriteLine($"\nEl tiempo estimado de viaje es -> {Utils.Rounded(distancia / velocidad)} horas");

            Utils.endAlgorithm(j_CalcularTiempoEnBicicleta.CalcularTiempoEnBicicleta);

        }

    }
}
