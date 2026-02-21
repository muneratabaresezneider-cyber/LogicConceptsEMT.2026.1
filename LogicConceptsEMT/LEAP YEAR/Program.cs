using Shared;
var answer = string.Empty;
var options = new List<string> { "s", "n" };


do
{
    var correntYear = DateTime.Now.Year;
    var message = string.Empty;
    Console.WriteLine("Averigua si el Año es biciesto o no");
    var year = ConsoleExtension.GetInt("Ingrese Año: ");

    if (year == correntYear)
    {
        message = "es";
    }
    else if (year > correntYear)
    {
        message = "será";
    }
    else
    {
        message = "fue";
    }
    if (year % 4 == 0)
    {
        if (year % 100 == 0)
        {
            if (year % 400 == 0)
            {
                Console.WriteLine($"{year} si {message} un año bisiesto");
            }else
            {
                Console.WriteLine($"{year} no {message} un año bisiesto");
            }
        }
        else
        {      
            Console.WriteLine($"{year} si {message} un año bisiesto"); 
        }
    }else
    {
        Console.WriteLine($"{year} no {message} un año bisiesto");
    }   
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("has salido del programa.");

