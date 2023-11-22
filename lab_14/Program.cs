using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] edades = new int[1000];
            bool[] vacunado = new bool[1000];
            int contador = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine("Encuesta Covid-19");
                Console.WriteLine("================================");
                Console.WriteLine("1: Realizar Encuesta");
                Console.WriteLine("2: Mostrar Datos de la encuesta");
                Console.WriteLine("3: Mostrar Resultados");
                Console.WriteLine("4: Buscar Personas por edad");
                Console.WriteLine("5: Salir");
                Console.WriteLine("================================");
                Console.Write("Ingrese una opción: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("===================================");
                        Console.WriteLine("Encuesta de vacunación");
                        Console.WriteLine("===================================");
                        Console.Write("¿Qué edad tienes?: ");
                        int edad = int.Parse(Console.ReadLine());
                        edades[contador] = edad;

                        Console.WriteLine("Te has vacunado");
                        Console.WriteLine("1: Sí");
                        Console.WriteLine("2: No");
                        Console.WriteLine("===================================");
                        Console.Write("Ingrese una opción: ");
                        int opcionVacuna = int.Parse(Console.ReadLine());
                        vacunado[contador] = opcionVacuna == 1;

                        contador++;

                        Console.Clear();
                        Console.WriteLine("===================================");
                        Console.WriteLine("Encuesta de vacunación");
                        Console.WriteLine("===================================");
                        Console.WriteLine();
                        Console.WriteLine("¡Gracias por participar!");
                        Console.WriteLine();
                        Console.WriteLine("===================================");
                        Console.WriteLine("Presione una tecla ...");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("===================================");
                        Console.WriteLine("Datos de la encuesta");
                        Console.WriteLine("===================================");
                        Console.WriteLine();
                        Console.WriteLine("ID    | Edad | Vacunado");
                        Console.WriteLine("=======================");
                        for (int i = 0; i < contador; i++)
                        {
                            Console.WriteLine($"{i.ToString("D4")}  |  {edades[i].ToString("D2")}  |   {(vacunado[i] ? "Si" : "No")}");
                        }
                        Console.WriteLine();
                        Console.WriteLine("===================================");
                        Console.WriteLine("Presione una tecla para regresar ...");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("===================================");
                        Console.WriteLine("Resultados de la encuesta");
                        Console.WriteLine("===================================");
                        Console.WriteLine();
                        int vacunados = 0;
                        int noVacunados = 0;
                        int[] categoriasEdad = new int[6];

                        for (int i = 0; i < contador; i++)
                        {
                            if (vacunado[i])
                                vacunados++;
                            else
                                noVacunados++;

                            if (edades[i] >= 1 && edades[i] <= 20)
                                categoriasEdad[0]++;
                            else if (edades[i] >= 21 && edades[i] <= 30)
                                categoriasEdad[1]++;
                            else if (edades[i] >= 31 && edades[i] <= 40)
                                categoriasEdad[2]++;
                            else if (edades[i] >= 41 && edades[i] <= 50)
                                categoriasEdad[3]++;
                            else if (edades[i] >= 51 && edades[i] <= 60)
                                categoriasEdad[4]++;
                            else if (edades[i] > 60)
                                categoriasEdad[5]++;
                        }

                        Console.WriteLine($"{vacunados} personas se han vacunado");
                        Console.WriteLine($"{noVacunados} personas no se han vacunado");
                        Console.WriteLine();
                        Console.WriteLine("Existen:");
                        Console.WriteLine($"{categoriasEdad[0]} personas entre 01 y 20 años");
                        Console.WriteLine($"{categoriasEdad[1]} personas entre 21 y 30 años");
                        Console.WriteLine($"{categoriasEdad[2]} personas entre 31 y 40 años");
                        Console.WriteLine($"{categoriasEdad[3]} personas entre 41 y 50 años");
                        Console.WriteLine($"{categoriasEdad[4]} personas entre 51 y 60 años");
                        Console.WriteLine($"{categoriasEdad[5]} personas de más de 61 años");
                        Console.WriteLine();
                        Console.WriteLine("===================================");
                        Console.WriteLine("Presione una tecla para regresar ...");
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("===================================");
                        Console.WriteLine("Buscar a personas por edad");
                        Console.WriteLine("===================================");
                        Console.Write("¿Qué edad quieres buscar?: ");
                        int edadBusqueda = int.Parse(Console.ReadLine());

                        int vacunadosBusqueda = 0;
                        int noVacunadosBusqueda = 0;

                        for (int i = 0; i < contador; i++)
                        {
                            if (edades[i] == edadBusqueda)
                            {
                                if (vacunado[i])
                                    vacunadosBusqueda++;
                                else
                                    noVacunadosBusqueda++;
                            }
                        }

                        Console.WriteLine();
                        Console.WriteLine($"{vacunadosBusqueda} se vacunaron");
                        Console.WriteLine($"{noVacunadosBusqueda} no se vacunaron");
                        Console.WriteLine();
                        Console.WriteLine("===================================");
                        Console.WriteLine("Presione una tecla para regresar ...");
                        Console.ReadKey();
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        Console.WriteLine("===================================");
                        Console.WriteLine("Presione una tecla para continuar ...");
                        Console.ReadKey();
                        break;
                }
            }


        }

    }
}
