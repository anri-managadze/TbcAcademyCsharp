using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public struct StructCurrency
    {
        private string _currency;
        private decimal _amount;

        public StructCurrency(string currency, decimal amount)
        {
            _amount = amount;
            _currency = currency;
        }

        public string Currency { 
            get 
            { return _currency; 
            }
            set
            {
                _currency = value;
            }
        }

        public decimal Amount { 
            get 
            { return _amount; 
            }
            set { 
                _amount = value; 
            }
        }
    }
}
