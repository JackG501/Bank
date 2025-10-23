using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClass
{
    public class CurrentAccount:Bank
    {
        public decimal overdraft (get; set;) = 400m;
        {
            this.AccountName = accountName;
        }

        public decimal Debit(decimal amount)
        {
           return amount;
        }
    }
}
