using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usama
{
    class BankAccount
    {
        private long accountNumber;
        private int balance;

        public BankAccount()
        {

        }
        public BankAccount(long accountNumber, int balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }
        public void Deposit(int amount)
        {
            if (amount < 0)
            {
                return;
            }
            balance += amount;
        }
        public void Withdraw(int amount)
        {

            if (amount < 0 || balance<=0 || amount>balance) {
                return;

            }
            balance -= amount;
        }
        public int GetBalance()
        {
            return balance;
        }
    }
}
