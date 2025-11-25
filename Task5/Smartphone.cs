using System;

public class Smartphone : ElectronicDevice
{
    public Smartphone(string brand, double price) : base(brand, price)
    {
    }

    public void EnableCamera()
    {
        Console.WriteLine($"{Brand} smartphone camera feature is now active.");
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Smartphone details -> Brand: {Brand}, Price: {Price}");
    }
}
