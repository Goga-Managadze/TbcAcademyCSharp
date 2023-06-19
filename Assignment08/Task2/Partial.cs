using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial
{
    public partial class BankAccount
    {
        private string _AccountNumber;
        private string _AccountHolderName;
        private CurrencyStruct _balance;
     
        public string AccountNumber
        {
            get
            {
                return _AccountNumber;
            }
            set
            {
                _AccountNumber = value;
            }
        }

        public string AccountHolderName
        {
            get
            {
                return _AccountHolderName;
            }
            set
            {
                _AccountHolderName = value;
            }
        }
        public CurrencyStruct Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        public BankAccount(string AccountNumber, string AccountHolderName, string Currency, decimal Amount) {
            _AccountNumber = AccountNumber;
            _AccountHolderName = AccountHolderName;
            _balance = new CurrencyStruct(Currency,Amount);
        }
        public void Deposit(decimal amount)
        {
            _balance.Amount += amount;   
            Console.WriteLine("Amount: " +  _balance.Amount);
        }

        public void Withdraw(decimal amount)
        {
            _balance.Amount -= amount;
            Console.WriteLine("Amount: " + _balance.Amount);
        }

        public void BalanceCheck()
        {
                Console.WriteLine($"Currency: {Balance.Currency}, Amount: {Balance.Amount}");
        }
    }
}