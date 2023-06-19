using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial
{
    public struct CurrencyStruct
    {
        private string _currency;
        private decimal _amount;

        public string Currency
        {
            get { return _currency; }

            set { _currency = value; }
        }

        public decimal Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        public CurrencyStruct(string currency, decimal amount)
        {
            _currency = currency;
            _amount = amount;
        }

    }
}
