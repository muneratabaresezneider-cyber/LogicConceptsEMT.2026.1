using Shared;
var answer = string.Empty;
var options = new List<string> { "s", "n" };


do
{
    Console.WriteLine("Ingrese dos numeros para ver si uno es multiplo de otro");
    var a = ConsoleExtension.GetInt("Ingrese el primer número: ");
    var b = ConsoleExtension.GetInt("Ingrese el segundo número: ");
    if (a % b == 0)
    {
        Console.WriteLine($"{a} es múltiplo de {b}");
    }
    else
    {
        Console.WriteLine($"{a} no es multiplo de {b}");
    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("has salido del programa.");

