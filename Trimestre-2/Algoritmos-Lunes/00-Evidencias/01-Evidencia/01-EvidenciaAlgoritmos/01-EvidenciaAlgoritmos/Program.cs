using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EvidenciaAlgoritmos
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

            Console.WriteLine($"El area es {(b * h) / 2}");
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

            Console.WriteLine($"La cantidad de dolases que puede comprar con {Mx} son -> {Mx / valConversionMxUsd} ");
            Console.ReadKey();
        }

        static void AgeCalculator()
        {
            //Una empresa que contrata personal requiere determinar la edad de las personas que solicitan trabajo, pero cuando se les realiza la entrevista sólo se les pregunta el año en que nacieron. 
            //Realice el diagrama de flujo y pseudocódigo que representen el algoritmo para solucionar este problema.
            string input;
            int today = DateTime.Now.Year;
            double birdthYear;
            Console.WriteLine("Programa para determinar la edad de las personas");

            Console.WriteLine("Digite el año de nacimiento");
            input = Console.ReadLine();
            birdthYear = ValidateNumber(input, false);

            while (today - birdthYear < 0)
            {
                Console.WriteLine("El año dado no puede ser mayor al año actual");
                Console.WriteLine("Por favor digite el año de nacimiento nuevamente");
                input = Console.ReadLine();
                birdthYear = ValidateNumber(input, false);
            }

            Console.WriteLine($"La edad es -> {today - birdthYear}");

            Console.ReadKey();
        }

        static void parking()
        {
            //Un estacionamiento requiere determinar el cobro que debe aplicar a las personas
            //que lo utilizan. Considere que el cobro es con base en las horas que lo disponen y
            //que las fracciones de hora se toman como completas y realice un diagrama de flujo
            //y pseudocódigo que representen el algoritmo que permita determinar el cobro.

            string input;
            double valorHora, horas;
            Console.WriteLine("Programa para determinar el cobro por hora de un parqueadero");

            Console.WriteLine("Por favor digite el valor de la hora");
            input = Console.ReadLine();
            valorHora = ValidateNumber(input, false);

            Console.WriteLine("Por favor digite la cantidad de horas que duro el vehiculo en el parqueadero");
            input = Console.ReadLine();
            horas = ValidateNumber(input, false);



            Console.WriteLine($"El valor a pagar es es -> {valorHora * horas}");

            Console.ReadKey();
        }

        static void cobroLaBrochaGorda()
        {
            //Pinturas "La brocha gorda" requiere determinar cuánto cobrar por trabajos de
            //pintura. Considere que se cobra por m2 y realice un diagrama de flujo y
            //pseudocódigo que representen el algoritmo que le permita ir generando
            //presupuestos para cada cliente.

            string input;
            double valorM2, m2;
            Console.WriteLine("Programa para determinar el cobro por trabajo");

            Console.WriteLine("Por favor digite el costo por metro cuadrado");
            input = Console.ReadLine();
            valorM2 = ValidateNumber(input, false);

            Console.WriteLine("Por favor digite la cantidad de metros cuadrados a pintar");
            input = Console.ReadLine();
            m2 = ValidateNumber(input, false);



            Console.WriteLine($"El valor a pagar es es -> {valorM2 * m2}");

            Console.ReadKey();
        }

        static double ValidateNumber(string input, bool negativeAcept)
        {
            double num;

            if (double.TryParse(input, out num))
            {
                num = double.Parse(input);

                if (negativeAcept || num > 0)
                {
                    return num;
                }
                else
                {
                    Console.WriteLine("Número inválido, el número no puede ser negativo. Ingrese uno nuevo:");
                    string newInput = Console.ReadLine();
                    return ValidateNumber(newInput, negativeAcept);
                }
            }
            else
            {
                Console.WriteLine("Número inválido. Ingrese uno nuevo:");
                string newInput = Console.ReadLine();
                return ValidateNumber(newInput, negativeAcept);
            }
        }


        static void Main(string[] args)
        {
            //HipotenusaTriangulo();
            //AreaVolumenCilindro();
            //AreaTriangulo();
            //MxToUsd();
            // AgeCalculator();
            //parking();
            cobroLaBrochaGorda();

            //Escribir -> Console.WriteLine
            //Leer -> a = float.Parse(Console.ReadLine)



        }
    }
}

