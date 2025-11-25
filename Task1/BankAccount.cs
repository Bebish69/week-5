using System;

public class BankAccount
{
    private string accountNumber;
    private double balance;

    public string AccountNumber
    {
        get { return accountNumber; }
    }

    public double Balance
    {
        get { return balance; }
        private set
        {
            if (value <= 0)
            {
                Console.WriteLine("Balance must be greater than zero. Previous balance remains unchanged.");
            }
            else
            {
                balance = value;
            }
        }
    }

    public BankAccount(string accountNumber, double initialBalance)
    {
        this.accountNumber = accountNumber;

        if (initialBalance <= 0)
        {
            Console.WriteLine("Initial balance has to be positive. Setting balance to 1.");
            this.balance = 1;
        }
        else
        {
            this.balance = initialBalance;
        }
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount should be more than zero.");
            return;
        }

        balance += amount;
        Console.WriteLine($"Added {amount} to account. Updated balance: {balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal amount should be more than zero.");
            return;
        }

        if (amount > balance)
        {
            Console.WriteLine("Insufficient funds for this withdrawal.");
            return;
        }

        balance -= amount;
        Console.WriteLine($"Deducted {amount} from account. Updated balance: {balance}");
    }
}
