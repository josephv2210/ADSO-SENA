using _01_EvidenciaAlgoritmos.utils;
using System;

namespace _01_EvidenciaAlgoritmos.algorithms
{
    internal class p_CalcularPotenciaElectrica
    {
        public static void CalcularPotenciaElectrica()
        {
            // Se desea calcular la potencia eléctrica de un circuito según la figura 2.6. 
            // Realice un diagrama de flujo y el pseudocódigo que representen el algoritmo 
            // para resolver el problema. Considere que: P = V * I y V = R * I.

            string input;
            double I, V, P;
            const double R = 4;
            Console.WriteLine("Programa para determinar la potencia eléctrica del circuito\n");
            Console.WriteLine("Resistencia de 4 ohmios");

            Console.WriteLine("Por favor, digite la corriente");
            input = Console.ReadLine();
            I = Utils.ValidateNumber(input, false);

            V = I * R;
            P = V * I;

            Console.WriteLine($"\nVoltaje en voltios -> {Utils.Rounded(V)}");
            Console.WriteLine($"\nPotencia eléctrica en watts -> {Utils.Rounded(P)}");

            Utils.endAlgorithm(p_CalcularPotenciaElectrica.CalcularPotenciaElectrica);

        }
    }
}
