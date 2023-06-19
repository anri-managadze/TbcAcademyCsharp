using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public partial class BankAccount
    {
        public void TransferFunds(BankAccount target, decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("The amount is less than 0");  
            }else if(amount > _balance.Amount)
            {
                Console.WriteLine("The amount is insufficient");
            }else if (Balance.Amount == 0)
            { 
                Console.WriteLine("The amount is 0 ");
            }
            else
            {
                Withdraw(amount);
                target.Deposit(amount);
                BalanceCheck();
                Console.WriteLine("The transaction is successful");
            }

          
        }
    }
}
