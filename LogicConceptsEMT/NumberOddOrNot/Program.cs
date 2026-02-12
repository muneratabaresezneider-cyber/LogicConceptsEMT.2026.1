var numberString = string.Empty;
do
{
    Console.Write("Ingrese un Numero o 'S' para salir: ");
    numberString = Console.ReadLine();
    var numberInt = 0;
    if (int.TryParse(numberString, out numberInt))
    { 
        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"El Numero {numberInt}, es par");
        }
        else
        {
            Console.WriteLine("El Numero es impar");
        }
    }
    

}while (numberString != "S");
