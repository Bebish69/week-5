using System;

public class Vehicle
{
    public string Brand { get; set; }
    public double Speed { get; set; }

    public void Start()
    {
        Console.WriteLine($"{Brand} is now starting up.");
    }

    public void Stop()
    {
        Console.WriteLine($"{Brand} is now shutting down.");
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Current speed: {Speed} km/h");
    }
}
