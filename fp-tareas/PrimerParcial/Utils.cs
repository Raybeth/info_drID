class Utils
{
    public static string LeerString(string mensaje)
    {
        Console.WriteLine(mensaje);
        return Console.ReadLine() ?? "";
    }

    public static void MostrarError(string mensaje)
    {
        var colorOriginal = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(mensaje);
        Console.ForegroundColor = colorOriginal;
        Console.ReadKey();

    }
}