using System;

public class BankAccount
{
    private double balance;

    // Constructor to set initial balance
    public BankAccount(double startingBalance)
    {
        balance = startingBalance;
    }

    // Method to deposit money
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: ${amount}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    // Method to withdraw money
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrew: ${amount}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
    }

    // Method to show current balance
    public void DisplayBalance()
    {
        Console.WriteLine($"Current balance: ${balance}");
    }
}
