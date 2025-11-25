
public class Printer
{
    public void Print(string message)
    {
        Console.WriteLine("Text output: " + message);
    }

    public void Print(int number)
    {
        Console.WriteLine("Numeric output: " + number);
    }

    public void Print(string message, int count)
    {
        Console.WriteLine($"Repeating '{message}' {count} time(s):");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"{i + 1}: {message}");
        }
    }
}
