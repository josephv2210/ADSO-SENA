﻿using _01_EvidenciaAlgoritmos.algorithms;
using System;

namespace _01_EvidenciaAlgoritmos
{
    internal class Program
    {
        static void menu()
        {
            string option;
            do
            {
                Console.WriteLine("Bienvenido a la evidencia de aprendizaje sobre algoritmos");
                Console.WriteLine("\nA continuación el menú de los algoritmos");
                Console.WriteLine("\na. Hipotenusa del triangulo");
                Console.WriteLine("b. Area y volumen de un cilindro");
                Console.WriteLine("c. Area de un triangulo");
                Console.WriteLine("d. Pesos mexicanos a dolar");
                Console.WriteLine("e. Calculador de edad");
                Console.WriteLine("f. Cobro de un parqueadero");
                Console.WriteLine("g. Cobrar por M2 de trabajo");
                Console.WriteLine("h. Hipotenusa del triangulo 2");
                Console.WriteLine("i. Hipotenusa del triangulo");
                Console.WriteLine("j. Hipotenusa del triangulo");
                Console.WriteLine("k. Hipotenusa del triangulo");
                Console.WriteLine("l. Hipotenusa del triangulo");
                Console.WriteLine("m. Hipotenusa del triangulo");
                Console.WriteLine("n. Hipotenusa del triangulo");
                Console.WriteLine("o. Hipotenusa del triangulo");
                Console.WriteLine("p. Hipotenusa del triangulo");
                Console.WriteLine("q. Hipotenusa del triangulo");
                Console.WriteLine("r. Hipotenusa del triangulo");
                Console.WriteLine("s. Hipotenusa del triangulo");
                Console.WriteLine("t. Hipotenusa del triangulo");
                Console.WriteLine("u. Hipotenusa del triangulo");
                Console.WriteLine("v. Hipotenusa del triangulo");
                Console.WriteLine("w. Hipotenusa del triangulo");
                Console.WriteLine("x. Hipotenusa del triangulo");


                Console.WriteLine("salir");

                Console.WriteLine("\nDigite el algoritmo seleccionado");

                option = Console.ReadLine();
                Console.Clear();

                switch (option)
                {
                    case "a":
                        a_hipotenusaTriangulo.HipotenusaTriangulo();
                        break;
                    case "b":
                        b_AreaVolumenCilindro.AreaVolumenCilindro();
                        break;
                    case "c":
                        c_AreaTriangulo.AreaTriangulo();
                        break;
                    case "d":
                        d_MxToUsd.MxToUsd();
                        break;
                    case "e":
                        e_AgeCalculator.AgeCalculator();
                        break;
                    case "f":
                        f_Parking.Parking();
                        break;
                    case "g":
                        g_CobroLaBrochaGorda.CobroLaBrochaGorda();
                        break;
                    case "h":
                        h_HipotenusaTriangulo2.HipotenusaTriangulo2();
                        break;
                    case "i":
                        i_LaCurvaLoca.LaCurvaLoca();
                        break;
                    case "j":
                        break;
                    case "k":
                        break;
                    case "l":
                        break;
                    case "m":
                        break;
                    case "n":
                        break;
                    case "o":
                        break;
                    case "p":
                        break;
                    case "q":
                        break;
                    case "r":
                        break;
                    case "s":
                        break;
                    case "t":
                        break;
                    case "u":
                        break;
                    case "v":
                        break;
                    case "w":
                        break;
                    case "x":
                        break;
                    default:
                        Console.WriteLine("\nOpción incorrecta, por favor digite una nueva\n");
                        break;
                }

            } while (option != "salir");
        }

        static void Main(string[] args)
        {
            menu();
        }
    }
}

