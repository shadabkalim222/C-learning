using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.OopPrinciples.Encapsulation {
    public class BankAccount {
        private decimal balance;

        public BankAccount(decimal initialBalance) {
            this.balance = initialBalance;
        }

        public void Deposit(decimal amount) {
            if (amount <= 0) {
                throw new ArgumentException("Deposit amount must be positive");
            }

            this.balance += amount;
        }

        public decimal GetBalance() {
            return balance;
        }

        public void Withdraw(decimal amount) {
            if (amount <= 0) {
                throw new ArgumentException("Withdrawal amount must be positive");
            }

            if (amount > balance) {
                throw new InvalidOperationException("Insufficient funds");
            }

            this.balance -= amount;
        }
    }
}