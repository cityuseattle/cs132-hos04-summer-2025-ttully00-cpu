using System;

class Program
{
    static void Main(string[] args)
    {
        // Create new bank account with $1000 starting balance
        BankAccount account = new BankAccount(1000);

        // Deposit $500
        account.Deposit(500);

        // Withdraw $200
        account.Withdraw(200);

        // Display final balance
        account.DisplayBalance();
    }
}

