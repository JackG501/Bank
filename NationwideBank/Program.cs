using BankClass;
using System.Security.Principal;

Bank myBank = new Bank();
myBank.AccountName = "Jacks";
myBank.AccountNumber = "9876543";
myBank.Balance = 500m;

static void AccountDetails(Bank bank)
{
    Console.WriteLine($"Account Name: {bank.AccountName}");
    Console.WriteLine($"Account Number: {bank.AccountNumber}");
    Console.WriteLine(bank.AccountInfo);
}
AccountDetails(myBank);

static void Despotccompletion(Bank bank) 
{
    Console.WriteLine("Despoting");
    bank.Debit(200m);
    Console.WriteLine("The updated account is: ");
    Console.WriteLine(bank.AccountInfo());
} 
Despotccompletion(myBank);

