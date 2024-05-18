using _02_EvideciaAlgoritmos.algorithms;
using System;

namespace _02_EvideciaAlgoritmos
{
    internal class Program
    {
        static void menu()
        {
            int option;
            do
            {
                Console.WriteLine("Bienvenido a la evidencia de aprendizaje 2 sobre algoritmos");
                Console.WriteLine("\nA continuación, el menú de los algoritmos:");
                Console.WriteLine("\n1. Derecho al voto");
                Console.WriteLine("2. Sueldo semanal");
                Console.WriteLine("3. Compra de regalo");
                Console.WriteLine("4. Cobro estacionamiento");
                Console.WriteLine("5. Menor de tres personas");
                Console.WriteLine("6. Costo con descuento");
                Console.WriteLine("7. Becas estudiantiles");
                Console.WriteLine("8. Bono mensual");
                Console.WriteLine("9. Poliza de seguros");
                Console.WriteLine("10. Vacaciones la tortuga");
                Console.WriteLine("11. Bono antiguedad");
                Console.WriteLine("12. Sueldo semanal");
                Console.WriteLine("13. Viaje de estudios");
                Console.WriteLine("14. Calificación a notas");

                Console.WriteLine("0. Salir");

                Console.WriteLine("\nDigite el algoritmo seleccionado");

                option = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (option)
                {
                    case 1:
                        _1_derechoVoto.DerechoVoto();
                        break;
                    case 2:
                        _2_sueldoSemanal.SueldoSemanal();
                        break;
                    case 3:
                        _3_comprarRegalo.ComprarRegalo();
                        break;
                    case 4:
                        _4_cobroEstacionamiento.CobroEstacionamiento();
                        break;
                    case 5:
                        _5_menorDeTres.MenorDeTres();
                        break;
                    case 6:
                        _6_costoConDescuento.CostoConDescuento();
                        break;
                    case 7:
                        _7_becasEstudiantiles.BecasEstudiantiles();
                        break;
                    case 8:
                        _8_bonoMensual.BonoMensual();
                        break;
                    case 9:
                        _9_polizaSeguro.PolizaSeguro();
                        break;
                    case 10:
                        _10_vacacionesLaTortuga.VacacionesLaTortuga();
                        break;
                    case 11:
                        _11_bonoAntiguedad.BonoAntiguedad();
                        break;
                    case 12:
                        _12_sueldoSemanal.SueldoSemanal();
                        break;
                    case 13:
                        _13_viajeEstudios.ViajeEstudios();
                        break;
                    case 14:
                        _14_calificacionNotas.CalificacionNotas();
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
