using System;
using System.Collections.Generic;
using TP1;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClubDeportivo club = new ClubDeportivo();

            while (true)
            {
                Console.WriteLine("Bienvenido al sistema de gestión del club deportivo.");
                Console.WriteLine("1. Alta de socio");
                Console.WriteLine("2. Alta de actividad");
                Console.WriteLine("3. Inscripcion de socio en actividad");
                Console.WriteLine("4. Salir");
                Console.Write("Ingrese una opción: ");

                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        // Alta socio
                        Console.Write("Ingrese el nombre del socio: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese el número de identificación: ");
                        int numeroIdentificacion;
                        while (!int.TryParse(Console.ReadLine(), out numeroIdentificacion))
                        {
                            Console.WriteLine("El ID de socio debe ser un número entero. Por favor, intente nuevamente.");
                            Console.Write("Ingrese el número de identificación: ");
                        }
                        string respuestaAltaSocio = club.AltaSocio(nombre, numeroIdentificacion);
                        Console.WriteLine(respuestaAltaSocio);
                        Console.WriteLine();
                        break;
                    case 2:
                        // Alta actividad
                        Console.Write("Ingrese el nombre de la actividad: ");
                        string nombreActividad = Console.ReadLine();
                        Console.Write("Ingrese el cupo total de la actividad: ");
                        int cupoTotal = int.Parse(Console.ReadLine());
                        string respuestaAltaActividad = club.AltaActividad(nombreActividad, cupoTotal);
                        Console.WriteLine(respuestaAltaActividad);
                        Console.WriteLine();
                        break;

                    case 3:
                        //Inscribir socio en actividad
                        Console.Write("Ingrese el id del socio: ");
                        int idSocio;
                        while (!int.TryParse(Console.ReadLine(), out idSocio))
                        {
                            Console.WriteLine("El ID de socio debe ser un número entero. Por favor, intente nuevamente.");
                        }

                        Console.Write("Ingrese la actividad: ");
                        string actividad = Console.ReadLine();
                        string respuestaInscripcion = club.InscribirSocioEnActividad(idSocio, actividad);
                        Console.WriteLine(respuestaInscripcion);
                        Console.WriteLine();
                        break;
                    case 4:
                        //Salir
                        Console.WriteLine("Saliendo del programa...");
                        return;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }
    }
}
