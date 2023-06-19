using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial
{
    public partial class BankAccount
    {
        public void TransferFunds(BankAccount target, decimal amount)
        {
            {
                if (amount <= 0)
                {
                    Console.WriteLine("The amount is less than 0");
                }
                else if (amount > _balance.Amount)
                {
                    Console.WriteLine("The amount on your account is insufficient");
                }

                Withdraw(amount);
                target.Deposit(amount);
                Console.WriteLine("The transaction was completed successfully");
            }
        }
    }
}
