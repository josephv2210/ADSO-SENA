using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_sumar_dos_numeros
{
    internal class Program
    {
        static void Sum2Num()
        {
            //reciba dos numeros y los sume
            string name = "Juan", lastName = "Lopez";
            Console.WriteLine(name + " " + lastName);
            int num1 = 0, num2 = 0;
            Console.WriteLine("Ingrese un número");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("La suma de " + num1 + " + " + num2 + " es " + (num1 + num2));// concatenar 1
            Console.WriteLine($"La suma de {num1} + {num2} es {num1 + num2}");// concatenar 2
            Console.WriteLine("La suma de {0} + {1} es {2}", num1, num2, (num1 + num2));
            Console.ReadKey();
        }

        static void calcRectanguloArea()
        {
            int b = 0, a = 0;
            Console.WriteLine("Programa para calcular el área de un rectángulo");
            Console.WriteLine("Digite la base");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite la altura");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine($"El área del cuadrado con base {b} y altura {a} es {b * a}");
            Console.ReadKey();

        }

        static void prom()
        {
            int num1 = 0, num2 = 0;
            Console.WriteLine("Programa para calcular el área de un rectángulo");
            Console.WriteLine("Digite la base");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite la altura");
            num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"El área del cuadrado con base {b} y altura {a} es {b * a}");
            Console.ReadKey();
        }

        static void validateNumber(int num)
        {

        }

        static void Main(string[] args)
        {
            string input;
            //Sum2Num();
            //calcRectanguloArea();
            prom();
        }
    }
}
