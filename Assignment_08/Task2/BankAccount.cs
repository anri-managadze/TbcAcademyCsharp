using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public partial class BankAccount
    {
        private string _accountNumber;
        private string _accountHolderName;
        private StructCurrency _balance;

        public BankAccount(string accountName, string name, decimal amount, string currency) {
            _accountNumber = accountName;
            _accountHolderName = name;
            _balance = new StructCurrency(amount,currency);
        }
        public string AccountNumber 
        {
            get
            {
                return _accountNumber;
            }
            set
            {
                 _accountNumber = value;
            }
        }
        public StructCurrency Balance 
        {
            get 
            {
                return _balance;
            }
            set 
            { 
                _balance = value; 
            }
        }
        public string AccountHolderName
        {
            get
            {
                return _accountHolderName;
            }
            set
            {
                _accountHolderName = value;
            }
        }

        public void Deposit(decimal amount)
        {
            _balance.Amount += amount;
        }
        public void Withdraw(decimal amount)
        {
            _balance.Amount -= amount;
        }
        public void BalanceCheck()
        {
            Console.WriteLine(_balance);
        }
    }
}
