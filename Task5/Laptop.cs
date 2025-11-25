using System;

public class Laptop : ElectronicDevice
{
    public Laptop(string brand, double price) : base(brand, price)
    {
    }

    public void TurnOnBattery()
    {
        Console.WriteLine($"{Brand} laptop is now running on battery power.");
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Laptop details -> Brand: {Brand}, Price: {Price}");
    }
}
