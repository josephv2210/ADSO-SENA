using _01_EvidenciaAlgoritmos.utils;
using System;

namespace _01_EvidenciaAlgoritmos.algorithms
{
    internal class o_CalcularValorCheque
    {
        public static void CalcularValorCheque()
        {
            // Una empresa desea determinar el monto de un cheque que debe proporcionar a
            // uno de sus empleados que tendrá que ir por equis número de días a la ciudad de
            // Monterrey; los gastos que cubre la empresa son: hotel, comida y 100.00 pesos
            // diarios para otros gastos. El monto debe estar desglosado para cada concepto.
            // Realice un diagrama de flujo y pseudocódigo que representen el algoritmo que
            // determine el monto del cheque.
            string input;
            double valorHotel, valorComida, cantidadDias, total, gastosDiarios = 100;
            Console.WriteLine("Programa para determinar el valor del cheque que se le tiene que dar al empleado\n");

            Console.WriteLine("Por favor, digite el costo del hotel");
            input = Console.ReadLine();
            valorHotel = Utils.ValidateNumber(input, false);

            Console.WriteLine("Por favor, digite el costo de la comida");
            input = Console.ReadLine();
            valorComida = Utils.ValidateNumber(input, false);

            Console.WriteLine("Por favor, digite la cantidad de días del viaje");
            input = Console.ReadLine();
            cantidadDias = Utils.ValidateNumber(input, false);

            total = valorHotel + valorComida + gastosDiarios;

            Console.WriteLine($"Costo hotel......... {valorHotel}");
            Console.WriteLine($"Costo comida........ {valorComida}");
            Console.WriteLine($"Otros gastos........ {gastosDiarios}");
            Console.WriteLine($".................... ----------------------");
            Console.WriteLine($".................... {Utils.Rounded(valorHotel + valorComida + gastosDiarios)}");


            Console.WriteLine($"\nEl valor del cheque es -> {Utils.Rounded(total * cantidadDias)}");

            Utils.endAlgorithm(o_CalcularValorCheque.CalcularValorCheque);

        }
    }
}
