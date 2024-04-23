using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HellowWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo desde C# ADSO 2873797");
            int a = 0, b = 0;
            string text;
            a = int.Parse(Console.ReadLine()); //leer
            b = int.Parse(Console.ReadLine());
            text = Console.ReadLine();
            Console.WriteLine(a + b);
            Console.WriteLine(text);
            Console.ReadKey(); //pausa
        }
    }
}
