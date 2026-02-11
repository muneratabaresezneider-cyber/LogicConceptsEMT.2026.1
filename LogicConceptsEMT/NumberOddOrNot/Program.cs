do
{
    Console.Write("Ingrese un Numero: ");
    var numberString = Console.ReadLine();
    var numberInt = int.Parse(numberString!);
    if (numberInt % 2 == 0)
    {
        Console.WriteLine($"El Numero {numberInt}, es par");
    }
    else
    {
        Console.WriteLine("El Numero es impar");
    }

}while (true);
