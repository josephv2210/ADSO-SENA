using _01_EvidenciaAlgoritmos.algorithms;
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
                        j_CalcularTiempoEnBicicleta.CalcularTiempoEnBicicleta();
                        break;
                    case "k":
                        k_CalculoM3LaConagua.CalculoM3LaConagua();
                        break;
                    case "l":
                        l_CalcularKwCLS.CalcularKwCLS();
                        break;
                    case "m":
                        m_CalcularPrecioArticulo.CalcularPrecioArticulo();
                        break;
                    case "n":
                        n_CalculoAhorro.CalculoAhorro();
                        break;
                    case "o":
                        o_CalcularValorCheque.CalcularValorCheque();
                        break;
                    case "p":
                        p_CalcularPotenciaElectrica.CalcularPotenciaElectrica();
                        break;
                    case "q":
                        q_PrepararTorta.PrepararTorta();
                        break;
                    case "r":
                        r_ConfeccionarPrenda.ConfeccionarPrenda();
                        break;
                    case "s":
                        s_PrepararPastel.PrepararPastel();
                        break;
                    case "t":
                        t_AreaCuadrado.AreaCuadrado();
                        break;
                    case "u":
                        u_PromedioAlumno.PromedioAlumno();  
                        break;
                    case "v":
                        v_CalculoVivido.CalculoVivido();
                        break;
                    case "w":
                        w_CalcularCostoLlamada.CalcularCostoLlamada();
                        break;
                    case "x":
                        x_CalcularCobroHuesped.CalcularCobroHuesped();  
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

