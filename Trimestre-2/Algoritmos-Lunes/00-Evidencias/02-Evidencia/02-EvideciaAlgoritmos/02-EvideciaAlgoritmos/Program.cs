using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EvideciaAlgoritmos
{
    internal class Program
    {
        static void menu()
        {
            int option;
            do
            {
                Console.WriteLine("Bienvenido a la evidencia de aprendizaje sobre algoritmos");
                Console.WriteLine("\nA continuación, el menú de los algoritmos:");
                Console.WriteLine("\na. Hipotenusa del triángulo");
                Console.WriteLine("b. Área y volumen de un cilindro");
                Console.WriteLine("c. Área de un triángulo");
                Console.WriteLine("d. Pesos mexicanos a dólar");
                Console.WriteLine("e. Calculadora de edad");
                Console.WriteLine("f. Cobro de un parqueadero");
                Console.WriteLine("g. Cobrar por M2 de trabajo");
                Console.WriteLine("h. Hipotenusa del triángulo 2");
                Console.WriteLine("i. Cobro del boleto de un viaje");
                Console.WriteLine("j. Determinar el tiempo de viaje de una ciudad a otra");
                Console.WriteLine("k. Cobro del consumo total de m^3 ");
                Console.WriteLine("l. Cobro del consumo de energía eléctrica");
                Console.WriteLine("m. Cobro final del producto");
                Console.WriteLine("n. Ahorro de una persona en un año");
                Console.WriteLine("o. Determinar el cobro de un cheque");
                Console.WriteLine("p. Potencia eléctrica del circuito");
                Console.WriteLine("q. Pseudocódigo preparar torta");
                Console.WriteLine("r. Pseudocódigo confeccionar una prenda");
                Console.WriteLine("s. Pseudocódigo preparar un pastel");
                Console.WriteLine("t. Área de un cuadrado");
                Console.WriteLine("u. Promedio de los exámenes de un alumno");
                Console.WriteLine("v. Cálculo del tiempo vivido");
                Console.WriteLine("w. Cobro costo de la llamada");
                Console.WriteLine("x. Cobro huésped");

                Console.WriteLine("0. Salir");
                
                Console.WriteLine("\nDigite el algoritmo seleccionado");

                option = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (option)
                {
                    case 1:
                        //a_hipotenusaTriangulo.HipotenusaTriangulo();
                        break;
                    case 2:
                        //b_AreaVolumenCilindro.AreaVolumenCilindro();
                        break;
                    
                    default:
                        Console.WriteLine("\nOpción incorrecta, por favor digite una nueva\n");
                        break;
                }

            } while (option != 0);
        }

        static void Main(string[] args)
        {
            menu();
        }
    }
}
