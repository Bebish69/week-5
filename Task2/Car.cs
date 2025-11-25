using System;

public class Car : Vehicle
{
    public int Seats { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Car -> Brand: {Brand}, Top speed: {Speed} km/h, Seats available: {Seats}");
    }
}
