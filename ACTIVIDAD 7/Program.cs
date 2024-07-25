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
    Console.WriteLine("5. Mostrar números ingresados");
    Console.WriteLine("6. Salir");

    Console.Write("\nSeleccione una opción: ");
    int opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            //PedirNumeros();
            break;
        case 2:
            //CalcularYMostrarMedia();
            break;
        case 3:
            //CalcularYMostrarMediana();
            break;
        case 4:
            //CalcularYMostrarDesviacionEstandar();
            break;
        case 5:
            //MostrarNumerosIngresados();
            break;
        case 6:
            Console.WriteLine("¡Hasta luego!");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opción no válida. Por favor, seleccione una opción del menú.");
            break;
    }

    MostrarMenu(); 
}
