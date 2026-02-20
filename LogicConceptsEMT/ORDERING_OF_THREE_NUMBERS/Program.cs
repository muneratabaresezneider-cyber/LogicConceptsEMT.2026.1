Console.Write("Ingrese primer numero: ");
var number1Int = int.Parse(Console.ReadLine()!);
Console.Write("Ingrese segundo numero: ");
var number2Int = int.Parse(Console.ReadLine()!);
Console.Write("Ingrese tercer numero: ");
var number3Int = int.Parse(Console.ReadLine()!);

// Calcular mayor y menor usando Math, el del medio se obtiene por la suma
int mayor = Math.Max(number1Int, Math.Max(number2Int, number3Int));
int menor = Math.Min(number1Int, Math.Min(number2Int, number3Int));
int medio = number1Int + number2Int + number3Int - mayor - menor;

Console.WriteLine($"El numero mayor es: {mayor}");
Console.WriteLine($"El numero del medio es: {medio}");
Console.WriteLine($"El numero menor es: {menor}");
// Mostrar información para verificar qué ejecutable/proyecto se está corriendo
Console.WriteLine($"Ejecutable actual: {Environment.ProcessPath ?? System.Diagnostics.Process.GetCurrentProcess().MainModule?.FileName}");
Console.WriteLine($"Directorio base: {AppContext.BaseDirectory}");
Console.WriteLine("Presione una tecla para salir...");
Console.ReadKey();
