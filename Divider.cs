public class Divider
{
    public static void EnterKey()
    {
        Console.WriteLine("Press <Enter> to continue :)\n");
        while (Console.ReadKey().Key != ConsoleKey.Enter) {}
    }
}