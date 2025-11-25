using System;

public class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Car engine has been turned on.");
    }

    public override void StopEngine()
    {
        Console.WriteLine("Car engine has been turned off.");
    }
}
