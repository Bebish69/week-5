using System;

public class Bike : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Bike engine has been started.");
    }

    public override void StopEngine()
    {
        Console.WriteLine("Bike engine has been stopped.");
    }
}
