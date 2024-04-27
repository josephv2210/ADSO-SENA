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

        static void CalcRectanguloArea()
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

        static void Prom()
        {
            string input;
            double num1 = 0, num2 = 0, num3 = 0;
            //Console.WriteLine("Programa para calcular el área de un rectángulo");

            Console.WriteLine("Digite el primer numero");
            input = Console.ReadLine();
            num1 = ValidateNumber(input, false);

            Console.WriteLine("Digite el segundo numero");
            input = Console.ReadLine();
            num2 = num3 = ValidateNumber(input, false);

            Console.WriteLine("Digite el tercer numero");
            input = Console.ReadLine();
            num3 = ValidateNumber(input, false);



            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite la altura");
            //num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"El promedio es {(num1+num2+num3)/3}");
            Console.ReadKey();
        }

        static double ValidateNumber(string input, bool negativeAcept)
        {
            
            double num;

            if (double.TryParse(input, out num))
            {
                num = double.Parse(input);

                if (negativeAcept)
                {
                    return num;
                }
                else
                {
                    if (num > 0)
                    {
                        return num;
                    }
                    else
                    {
                        string newInput;
                        Console.WriteLine("Número invalido, el número no puede ser negativo digite uno nuevo");
                        newInput = Console.ReadLine();
                        ValidateNumber(newInput, negativeAcept)



                    }
                }
            }
            else
            {
                string newInput;
                Console.WriteLine("Número invalido, digite uno nuevo");
                newInput = Console.ReadLine();
                ValidateNumber(newInput, negativeAcept);
            }
            return 0;
        }

        static void Main(string[] args)
        {
           
            //Sum2Num();
            //CalcRectanguloArea();
            Prom();
        }
    }
}
