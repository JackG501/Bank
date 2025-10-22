using System.Runtime.CompilerServices;

namespace BankClass
{
    public class Bank
    {
        

        
       public Bank(string accountName ="",decimal balance = 0.0m, string accountNumber ="123456789")
        {
            
        }


        private string accountName; 
        private decimal balance;
        private string accountNumber;
        public string AccountName
        {
            set 
            {
                while (value.Length <= 0)
                {
                    value = value += "This is invalid Account name";

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
                this.AccountNumber = value;
            }
            get
            {
                return this.accountNumber;
            }
        }

        // Methods

        public void Debit (decimal amount)
        {
            if (amount > this.balance)
            {
                Console.WriteLine("Insufficient funds.");
            }
            else
            {
                this.balance -= amount;
            }
        }

    }
}
    
