using System;

public class Motorcycle : Vehicle
{
    public bool HasCarrier { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Motorcycle -> Brand: {Brand}, Speed: {Speed} km/h, Carrier attached: {HasCarrier}");
    }
}
