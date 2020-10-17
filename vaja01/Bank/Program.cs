using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            var account = new BankAccount("Jure", 1000);
            var account2 = new BankAccount("Lovro", 5000);

            System.Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} EUR.");
            System.Console.WriteLine($"Account {account2.Number} was created for {account2.Owner} with {account2.Balance} EUR.");
  
            account.MakeWithdrawal(150, DateTime.Now, "Tipkovnica");
            account2.MakeDeposit(1500, DateTime.Now, "Izplačilo plače");

            //novo stanje po vseh transakcijah računa
            System.Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} EUR.");
            System.Console.WriteLine($"Account {account2.Number} was created for {account2.Owner} with {account2.Balance} EUR.");
        }
    }
}
