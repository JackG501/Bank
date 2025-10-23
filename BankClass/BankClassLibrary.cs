using System.Runtime.CompilerServices;

namespace BankClass
{
    public class Bank
    {



        public Bank(string accountName = "", decimal balance = 0.0m, string accountNumber = "12345678")
        {
            this.AccountName = accountName;
            this.Balance = balance;
            this.AccountNumber = accountNumber;

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
                while (value < 0)
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
                    value = value += "0";
                }
                this.accountNumber = value;
            }
            get
            {
                return this.accountNumber;
            }
        }

        public string AccountInfo()
        {
            return $"{AccountName}, {AccountName}, {Balance:C}";
        }

        // Methods

        public void Credit(decimal amount)
        {
            if (amount < 0.0m)
            {
                Balance += amount;
                Console.WriteLine($"{amount} has been Creditted. New Balance {Balance}");
            }
            else
            {
                Console.WriteLine("Incorrect amount credited, It must be possitive");
            }
        }

        public virtual  Debit(decimal amount)
        {
            if (amount < 0.0m)
            {
                Console.WriteLine("Amount must be greater than zero.");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Amount exceeded balance.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"{amount} has been debitted. Your new Balance is {Balance}");
            }
            {
               
            }

        }
    }
}

    
