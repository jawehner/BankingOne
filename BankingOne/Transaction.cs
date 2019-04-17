using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingOne
{
    public class Transaction
    {
        public decimal Amount { get; set; }
    }

    public Transaction(decimal amount)
    {
        this.Amount = amount;
    }
}
