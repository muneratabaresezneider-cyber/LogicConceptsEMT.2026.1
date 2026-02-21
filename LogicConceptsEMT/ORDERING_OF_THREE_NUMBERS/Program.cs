
using Shared;
var answer = string.Empty;
var options = new List<string> { "s", "n" };


do
{
    Console.WriteLine("Ingrese tres números diferntes para ordenarlos de mayor a menor");
    var a = ConsoleExtension.GetInt("Ingrese el primer número: ");
    var b = ConsoleExtension.GetInt("Ingrese el segundo número: ");
    if (a == b)
    {
        Console.WriteLine("Los números deben ser diferentes, intente de nuevo");
        continue;
    }
    var c = ConsoleExtension.GetInt("Ingrese el tercer número: ");
    if (a == c || b == c)
    {
        Console.WriteLine("Los números deben ser diferentes, intente de nuevo");
        continue;
    }
    if (a > b && a > c)
    {
        if (b > c)
        {
            Console.WriteLine($"El numero mayor es {a}, el numero del medio es {b} y el numero menor es {c}");
        }
        else
        {
            Console.WriteLine($"El numero mayor es {a}, el numero del medio es {c} y el numero menor es {b}");
        }
    }
    else if (b > a && b > c)
    {
        if (a > c)
        {
            Console.WriteLine($"El numero mayor es {b}, el numero del medio es {a} y el numero menor es {c}");
        }
        else
        {
            Console.WriteLine($"El numero mayor es {b}, el numero del medio es {c} y el numero menor es {a}");
        }
    }
    else if (c > a && c > b)
    {
        if (a > b)
        {
            Console.WriteLine($"El numero mayor es {c}, el numero del medio es {a} y el numero menor es {b}");
        }
        else
        {
            Console.WriteLine($"El numero mayor es {c}, el numero del medio es {b} y el numero menor es {a}");
        }
    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("has salido del programa.");






