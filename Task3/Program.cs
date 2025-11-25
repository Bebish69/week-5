class Program
{
    static void Main(string[] args)
    {
        Printer printer = new Printer();

        printer.Print("Hello World");
        printer.Print(123);
        printer.Print("Repeat me", 3);

        Console.ReadLine();
    }
}
