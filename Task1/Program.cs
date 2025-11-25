using System;

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount("ACC696969", 1000);

        Console.WriteLine($"Account number: {account.AccountNumber}");
        Console.WriteLine($"Opening balance: {account.Balance}");

        account.Deposit(500);
        account.Withdraw(400);

        Console.WriteLine($"Closing balance: {account.Balance}");

        Console.ReadLine();
    }
}
