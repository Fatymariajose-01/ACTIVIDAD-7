using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Funciones
    {
        private static List<int> numeros = new List<int>();
        static void Main()
        {
            try
            {
                MostrarMenu();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Algo ocurrió :/ detalles: {ex.Message}");
            }
        }


    static void MostrarMenu()
    {
        Console.Clear();
        Console.WriteLine("Calculadora de operaciones estadísticas básicas");
        Console.WriteLine("1. Ingresar números");
        Console.WriteLine("2. Calcular y mostrar media");
        Console.WriteLine("3. Calcular y mostrar mediana");
        Console.WriteLine("4. Calcular y mostrar la moda");
        Console.WriteLine("5. Calcular y mostrar desviación estándar");
        Console.WriteLine("6. Salir");

        Console.Write("\nSeleccione una opción: ");
        try
        {
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    PedirNumeros();
                    Console.ReadKey();
                    break;
                case 2:
                    CalcularYMostrarMedia();
                    Console.ReadKey();
                    break;
                case 3:
                    CalcularYMostrarMediana();
                    Console.ReadKey();
                    break;
                case 4:
                    CalcularYMostrarModa();
                    Console.ReadKey();
                    break;
                case 5:
                    CalcularYMostrarDesviacionEstandar();
                    Console.ReadKey();
                    break;
                case 6:
                    Console.WriteLine("Adiós :)!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción del menú.");
                    Console.ReadKey();
                    break;
            }

            MostrarMenu();
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingrese un número válido.");
            Console.ReadKey();
        }
    }


}
