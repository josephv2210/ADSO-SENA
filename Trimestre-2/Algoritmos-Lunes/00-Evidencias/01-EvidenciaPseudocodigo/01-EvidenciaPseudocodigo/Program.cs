using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EvidenciaPseudocodigo
{
    internal class Program
    {
        static void HipotenusaTriangulo()
        {
            // Realice el pseudocódigo de un programa que sirva para determinar la hipotenusa de un triángulo rectángulo
            string input;
            double a = 0, b = 0;
            Console.WriteLine("Programa para para determinar la hipotenusa de un triángulo rectángulo");

            Console.WriteLine("Digite el lado a del triangulo");
            input = Console.ReadLine();
            a = ValidateNumber(input, false);

            Console.WriteLine("Digite el lado b del triangulo");
            input = Console.ReadLine();
            b = ValidateNumber(input, false);

            Console.WriteLine($"La hipotenusa del triangulo rectangulo es {Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2)))}");
            Console.ReadKey();
        }
        
        static void AreaVolumenCilindro()
        {
            //Desarrolla un algoritmo (pseudocódigo) que permita determinar el área y volumen de un cilindro
            string input;
            double h = 0, r = 0, area = 0, volumen = 0;
            Console.WriteLine("Programa para determinar el area y el volumen de un cilindro");

            Console.WriteLine("Digite el radio del cilindro");
            input = Console.ReadLine();
            r = ValidateNumber(input, false);

            Console.WriteLine("Digite la altura del cilindro");
            input = Console.ReadLine();
            h = ValidateNumber(input, false);

            area = (2 * Math.PI * (Math.Pow(r, 2))) + (2 * Math.PI * r * h);
            volumen = Math.PI * Math.Pow(r, 2) * h;


            Console.WriteLine($"El area del cilindro es -> {area}");
            Console.WriteLine($"El volumen del cilindro es -> {volumen}");
            Console.ReadKey();
        }

        static void AreaTriangulo()
        {
            // Realice un diagrama de flujo y pseudocódigo que representen el algoritmo para obtener el área de un triángulo.
            string input;
            double h = 0, b = 0;
            Console.WriteLine("Programa para determinar el area de un triangulo");

            Console.WriteLine("Digite la base del triangulo");
            input = Console.ReadLine();
            b = ValidateNumber(input, false);

            Console.WriteLine("Digite la altura del triangulo");
            input = Console.ReadLine();
            h = ValidateNumber(input, false);

            Console.WriteLine($"El area es {(b*h)/2}");
            Console.ReadKey();
        }
        
        static void MxToUsd()
        {
            // Una empresa importadora desea determinar cuántos dólares puede adquirir con equis cantidad de dinero mexicano. Realice un diagrama de flujo y pseudocódigo que representen el algoritmo para tal fin.
            string input;
            double valConversionMxUsd = 17.16, Mx = 0;
            Console.WriteLine("Programa para calcular cuantos dolares puedes adquirir con pesos mexicanos");

            Console.WriteLine("Digite la cantidad de pesos mexicanos");
            input = Console.ReadLine();
            Mx = ValidateNumber(input, false);

            Console.WriteLine($"La cantidad de dolases que puede comprar con {Mx} son -> {Mx/valConversionMxUsd} ");
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
                        ValidateNumber(newInput, negativeAcept);
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
            //HipotenusaTriangulo();
            //AreaVolumenCilindro();
            //AreaTriangulo();
            //MxToUsd();
            
            //Escribir -> Console.WriteLine
            //Leer -> a = float.Parse(Console.ReadLine)



        }
    }
}
