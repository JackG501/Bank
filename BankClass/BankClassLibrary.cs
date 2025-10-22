using System.Runtime.CompilerServices;

namespace BankClass
{
    public class Bank
    {
        

        
       public Bank(string accountName ="",decimal balance = 0.0m, string accountNumber ="123456789")
        {
            
        }


        private string accountName = "Jack"; 
        private decimal balance = 500m;
        private string accountNumber = "123456789";
        public string AccountName
        {
            set 
            {
                while (value.Length <= 0)
                {
                    value = value += "*";

                }
                this.accountName = value;
            }
            get
            {
                return this.accountName;
            }
        }

        public decimal Balance
        {
            set 
            {
                while (value <0)
                {
                    value = 0;                
                }
            }
            get
            {
                return this.balance;
            }
        }

        public string AccountNumber
        {
            set 
            {
                while (value.Length != 9)
                {
                    value = value+= "0";
                }
                this.accountNumber = value;
            }
            get
            {
                return this.accountNumber;
            }
        }

        // Methods

        public void Credit (decimal amount)
        {
            if (amount < 0.0m)
            {
                return;
            }
        }

        public void Debit (decimal amount)
        {
            if (amount < 0.0m)
            {
               return;
            }
        }

    }
}
    
