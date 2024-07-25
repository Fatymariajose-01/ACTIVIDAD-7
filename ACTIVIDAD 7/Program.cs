
public class Program
{
    private static List<int> numeros = new List<int>();
    static void Main()
    {
        try { 
        MostrarMenu();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Algo ocurrió :/ detalles: {ex.Message}");           
        }
    }

    // Método para mostrar el menú
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

    static void PedirNumeros()
    {
        try
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
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingrese un número válido para la cantidad de números.");
           Console.ReadKey();
        }
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
        try
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
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Error: No hay suficientes números ingresados para calcular la mediana.");
            return 0;
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
    public static void CalcularYMostrarModa()
    {
        if (numeros.Count == 0)
        {
            Console.WriteLine("No hay números ingresados. Por favor, ingrese números primero.");
            return;
        }

        List<int> moda = CalcularModa();

        if (moda.Count == 1)
        {
            Console.WriteLine($"La moda de los números ingresados es: {moda[0]}");
        }
        else
        {
            Console.WriteLine("Las modas de los números ingresados son:");
            foreach (var item in moda)
            {
                Console.WriteLine(item);
            }
        }
    }
    public static List<int> CalcularModa()
    {
        var conteoNumeros = numeros.GroupBy(x => x)
                                   .OrderByDescending(g => g.Count())
                                   .Select(g => new { Numero = g.Key, Frecuencia = g.Count() });

        int maxFrecuencia = conteoNumeros.First().Frecuencia;

        return conteoNumeros.Where(x => x.Frecuencia == maxFrecuencia)
                            .Select(x => x.Numero)
                            .ToList();
    }

}
