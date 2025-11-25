using System;
class Program
{
    static void Main(string[] args)
    {
        Car car = new Car
        {
            Brand = "Mercedes",
            Speed = 120,
            Seats = 5
        };

        Motorcycle bike = new Motorcycle
        {
            Brand = "Buggati",
            Speed = 80,
            HasCarrier = true
        };

        car.Start();
        car.DisplayInfo();
        car.Stop();

        Console.WriteLine();

        bike.Start();
        bike.DisplayInfo();
        bike.Stop();

        Console.ReadLine();
    }
}
