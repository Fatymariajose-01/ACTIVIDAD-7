﻿
public class Program
{
    private static List<int> numeros = new List<int>();
    static void EnseñarMenu()
    {
        MostrarMenu();
    }

    // Método para mostrar el menú
    static void MostrarMenu()
    {
        Console.WriteLine("Calculadora de estadísticas básicas");
        Console.WriteLine("1. Ingresar números");
        Console.WriteLine("2. Calcular y mostrar media");
        Console.WriteLine("3. Calcular y mostrar mediana");
        Console.WriteLine("4. Calcular y mostrar desviación estándar");
        Console.WriteLine("5. Salir");

        Console.Write("\nSeleccione una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                PedirNumeros();
                break;
            case 2:
                CalcularYMostrarMedia();
                break;
            case 3:
                CalcularYMostrarMediana();
                break;
            case 4:
                CalcularYMostrarDesviacionEstandar();
                break;
            case 5:
                Console.WriteLine("¡Hasta luego!");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opción no válida. Por favor, seleccione una opción del menú.");
                break;
        }

        MostrarMenu();
    }

    static void PedirNumeros()
    {
        Console.Write("Ingrese la cantidad de números a ingresar: ");
        int n = int.Parse(Console.ReadLine());

        numeros.Clear(); // Limpiar la lista antes de agregar nuevos números

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            int numero = int.Parse(Console.ReadLine());
            numeros.Add(numero);
        }

        Console.WriteLine("Números ingresados correctamente.");
    }
    public static void CalcularYMostrarMedia()
    {

        double media = CalcularMedia();
        Console.WriteLine($"La media de los números ingresados es: {media}");
    }
        public static double CalcularMedia()
        {
            return numeros.Average();
        }
    public static void CalcularYMostrarMediana()
    {
        double mediana = CalcularMediana();
        Console.WriteLine($"La mediana de los números ingresados es: {mediana}");
    }
    public static double CalcularMediana()
    {
        List<int> numerosOrdenados = numeros.OrderBy(num => num).ToList();
        int n = numerosOrdenados.Count;

        if (n % 2 == 0)
        {
            int medio1 = numerosOrdenados[n / 2 - 1];
            int medio2 = numerosOrdenados[n / 2];
            return (medio1 + medio2) / 2.0;
        }
        else
        {
            return numerosOrdenados[n / 2];
        }
    }
    public static double CalcularDesviacionEstandar()
    {
        double media = CalcularMedia();
        double sumatoriaCuadrados = numeros.Sum(num => Math.Pow(num - media, 2));
        double desviacionEstandar = Math.Sqrt(sumatoriaCuadrados / numeros.Count);

        return desviacionEstandar;
    }
    public static void CalcularYMostrarDesviacionEstandar()
    {
        if (numeros.Count == 0)
        {
            Console.WriteLine("No hay números ingresados. Por favor, ingrese números primero.");
            return;
        }

        double desviacionEstandar = CalcularDesviacionEstandar();
        Console.WriteLine($"La desviación estándar de los números ingresados es: {desviacionEstandar}");
    }
}
