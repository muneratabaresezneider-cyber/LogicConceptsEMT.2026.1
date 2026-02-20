using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.WriteLine("Programa para determinar el numero mayor entre tres numeros");
    Console.Write("Ingrese primer numero: ");
    var number1String = Console.ReadLine();
    var number1Int = int.Parse(number1String!);
    Console.Write("Ingrese segundo numero: ");
    var number2String = Console.ReadLine();
    var number2Int = int.Parse(number2String!);
    Console.Write("Ingrese tercer numero: ");
    var number3String = Console.ReadLine();
    var number3Int = int.Parse(number3String!);
    if (number1Int > number2Int && number1Int > number3Int)
    {
        Console.WriteLine($"El numero mayor es: {number1Int}");
    }
    if (number2Int > number1Int && number2Int > number3Int)
    {
        Console.WriteLine($"El numero mayor es: {number2Int}");
    }
    if (number3Int > number1Int && number3Int > number2Int)
    {
        Console.WriteLine($"El numero mayor es: {number3Int}");
    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Game Over.");