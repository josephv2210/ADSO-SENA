using Condicionales.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales.CondicionesSimples
{
    internal class _03_calculeProductoDescuento
    {
        public static void calculeProductoDescuento()
        {
            // hacer un algoritmo que calcule el costo total de un producto teniendo en cuenta que 
            // si compra mas de 10 unidades tiene un descuento del 10% sino no tiene descuento
            // calcule el valor total

            string input;
            double costo, unidades, valor, descuento=0;

            Console.WriteLine("Programa para determinar el costo total de un producto\n");
            Console.WriteLine("Digite el costo del producto");
            input = Console.ReadLine();
            costo = Utils.ValidateNumber(input, false);

            Console.WriteLine("Digite la cantidad de productos a llevar");
            input = Console.ReadLine();
            unidades = Utils.ValidateNumber(input, false);

            valor = costo * unidades;

            Console.WriteLine($"\nCosto.....................{valor}");
            if (unidades > 10) 
            {
                descuento = valor * 0.1;
                Console.WriteLine($"Descuento................{-descuento}");
            }
            Console.WriteLine($"..........................----------------------");
            Console.WriteLine($"Total.....................{(valor - descuento)}");

            Utils.endAlgorithm(_03_calculeProductoDescuento.calculeProductoDescuento);
        }
    }
}
