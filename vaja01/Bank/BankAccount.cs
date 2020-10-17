using System;
using System.Collections.Generic;

namespace Bank
{
    public class BankAccount {
        public int Number { get; set; }

        public string Owner { get; set; }

        private List<Transaction> allTransactions = new List<Transaction>();

        public decimal Balance { 
            get{
                decimal balance = 0;
                foreach (var item in allTransactions) {
                    balance += item.Amount;
                }
                return balance;
            }
        }
    
        private static int accountNumberSeed = 1234567890;

        public BankAccount (string name, decimal initialBalance) {  //konstruktor funkcije
            this.Owner = name;
            this.MakeDeposit(initialBalance, DateTime.Now, "Initial Deposit.");     //datum in ura trenutka ko ustvarimo objekt
            //this.Balance = initialBalance;
            this.Number = accountNumberSeed;
            accountNumberSeed ++;    
        }

        public void MakeDeposit(decimal amount, DateTime date, string note) {
            if (amount <= 0){
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive!");
            }

            var deposit = new Transaction(amount, DateTime.Now, note);
            allTransactions.Add(deposit);   //deposit dodam na seznam vseh transakcij
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note) {
            if (amount <= 0){
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive!");
            }

            if (Balance - amount <= 0){
                throw new InvalidOperationException("Not sufficient funds for this withdrawal.");
            }

            var withdrawal = new Transaction(amount, DateTime.Now, note);
            allTransactions.Add(withdrawal);   //withdrawal dodam na seznam vseh transakcij
        }
    }
}