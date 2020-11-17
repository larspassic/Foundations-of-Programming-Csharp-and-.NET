using System;

class BankAccount
{
    // create the balance field
    private double balance;

    //create a constructor
    public BankAccount()
    {
        // start with a zero balance
        balance = 0;
    }

    //create the deposit function
    public void Deposit(double amount)
    {
        balance = balance + amount;
    }

    // create the withdrawal function
    public void Withdrawal(double amount)
    {
        balance = balance - amount;
    }

    //create an accessing function to find what your current balance is
    public decimal GetBalance() // returns the balance in decimal
    {
        //Use casting to convert float balance as decimal
        return (decimal)balance;
    }
}

class Program
{
    static void Main()
    {
        BankAccount acct = new BankAccount();

        acct.Deposit(200);
        acct.Withdrawal(40);

        Console.WriteLine("The final balance is {0:c}", acct.GetBalance());

        Console.ReadLine();
    }
}