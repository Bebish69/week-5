using System;

class Program
{
    static void Main(string[] args)
    {
        ElectronicsStore store = new ElectronicsStore();

        Laptop laptop = new Laptop("Lenovo", 120000);
        Smartphone phone = new Smartphone("Oppo", 90000);

        store.AddDevice(laptop);
        store.AddDevice(phone);

        Console.WriteLine();
        store.ShowAllDeviceDetails();

        Console.ReadLine();
    }
}
