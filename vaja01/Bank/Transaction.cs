using System;
using System.Collections;
namespace Bank {
    public class Transaction {
        public string Notes { get; }
        public decimal Amount { get; }

        public DateTime Date { get; }

        public Transaction(decimal amount, DateTime date, string note) {
            this.Notes = note;
            this.Amount = amount;
            this.Date = date;
        }
    }
}