using Exercises.Logic;

try
{
    int option;
    do
    {
        option = Menu();
        switch (option)
        {
            case 1:
                Console.WriteLine("Ingrese la estructura de la viga: ");
                var stringBeam = new Beam(Console.ReadLine());

                break;
            case 2:
                Console.WriteLine("Ingrese la estructura del puente: ");
                var stringBridge = Console.ReadLine();
                break;
            default:
                Console.WriteLine("Fuck you. Opción no existe!!!!");
                break;
        }
    } while (option != 0);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
static int Menu()
{
    Console.WriteLine("¿Que desea construir?");
    Console.WriteLine("1. Una viga");
    Console.WriteLine("2. Un puente");
    Console.WriteLine("0. Salir");
    bool isValid = false;
    int option = 0;
    do
    {
        Console.Write("Digite su opción: ");
        var optionString = Console.ReadLine();
        if (!int.TryParse(optionString, out option))
        {
            Console.WriteLine("Opción inválida, solo use números.");
            isValid = false;
        }
        else
        {
            isValid = true;
        }
    } while (!isValid);
    return option;
}