using _01_EvidenciaAlgoritmos.utils;
using System;

namespace _01_EvidenciaAlgoritmos.algorithms
{
    internal class m_CalcularPrecioArticulo
    {
        public static void CalcularPrecioArticulo()
        {
            // Realice un diagrama de flujo y pseudocódigo que representen el algoritmo para
            // determinar cuánto pagará finalmente una persona por un artículo equis,
            // considerando que tiene un descuento de 20%, y debe pagar 15% de IVA (debe
            // mostrar el precio con descuento y el precio final).
            double valorProducto, descuento, iva;
            string input;

            Console.WriteLine("Programa para determinar el cobro final de un producto que tiene un descuento del 20% y debe pagar un 15% de IVA");
            Console.WriteLine("Por favor, digite el costo del producto");

            input = Console.ReadLine();
            valorProducto = Utils.ValidateNumber(input, false);
            descuento = valorProducto * 0.2;
            iva = (valorProducto - descuento) * 0.15;

            Console.WriteLine($".......................................... {valorProducto}");
            Console.WriteLine($"20% de descuento.......................... {descuento}");
            Console.WriteLine($"15% de IVA................................ {iva}");
            Console.WriteLine($".......................................... ----------------------");
            Console.WriteLine($".......................................... {valorProducto - descuento + iva}");

            Utils.endAlgorithm(m_CalcularPrecioArticulo.CalcularPrecioArticulo);
        }
    }
}
