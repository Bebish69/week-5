using System;
using System.Collections.Generic;

public class ElectronicsStore
{
    private List<ElectronicDevice> devices = new List<ElectronicDevice>();

    public void AddDevice(ElectronicDevice device)
    {
        devices.Add(device);
        Console.WriteLine($"{device.Brand} has been added to the store inventory.");
    }

    public void RemoveDevice(ElectronicDevice device)
    {
        if (devices.Remove(device))
        {
            Console.WriteLine($"{device.Brand} has been removed from the store inventory.");
        }
        else
        {
            Console.WriteLine("The specified device is not available in the store.");
        }
    }

    public void ShowAllDeviceDetails()
    {
        Console.WriteLine("=== Devices currently available in the store ===");

        foreach (ElectronicDevice device in devices)
        {
            device.ShowInfo();

            if (device is Laptop laptop)
            {
                laptop.TurnOnBattery();
            }
            else if (device is Smartphone phone)
            {
                phone.EnableCamera();
            }

            Console.WriteLine();
        }
    }
}
