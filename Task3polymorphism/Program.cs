using System;

class Program
{
    static void Main(string[] args)
    {
        NepaliTeacher nepali = new NepaliTeacher { Name = "Kushal" };
        EnglishTeacher english = new EnglishTeacher { Name = "Sagar" };

        Console.WriteLine($"Nepali teacher name: {nepali.Name}");
        nepali.Teaching();
        nepali.SalaryInfo();

        Console.WriteLine();

        Console.WriteLine($"English teacher name: {english.Name}");
        english.Teaching();
        english.SalaryInfo();

        Console.ReadLine();
    }
}
