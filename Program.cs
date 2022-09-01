using Microsoft.VisualBasic.FileIO;
using CapaDatos;

namespace TrabajoProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileArchivo fileArchivo = new FileArchivo();
            Estudiante estudiante;
            fileArchivo.DeserealizeEstudent();

            int opcion;
            do
            {
                Console.WriteLine("Opción 1: Agregar Estudiante");
                Console.WriteLine("Opción 2: Buscar Estudiante");
                Console.WriteLine("Opción 3: Mostrar Listado de Estudiantes");
                Console.WriteLine("Opción 4: Guardar el archivo");
                Console.WriteLine("Opción 5: Mostrar Información del Archivo");
                Console.WriteLine("Opción 6: Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        estudiante = new Estudiante();
                        Console.WriteLine("Ingrese el Nombre: ");
                        estudiante.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el Apellido: ");
                        estudiante.Apellido = Console.ReadLine();
                        Console.WriteLine("Ingrese el Grupo: ");
                        estudiante.Grupo = Console.ReadLine();
                        Console.WriteLine("Ingrese el Carnet: ");
                        estudiante.Carnet = Console.ReadLine();

                        fileArchivo.addEstudent(estudiante);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el carnet del estudiante: ");
                        fileArchivo.FindEstudiante(int.Parse(Console.ReadLine()));
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        fileArchivo.MostrarEstudiantes();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        fileArchivo.CrearArchivo();
                        Console.WriteLine("Se guardó el archivo");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:

                        break;
                }
            } while (opcion != 6);
        }
    }
}