/*    qus 1
To create a banking system in C# using a generic collection list, you can follow these steps:
Create a BankAccount class with the following properties:
AccountNumber (int)
AccountHolderName (string)
Balance (double)

Create a Bank class with the following properties:
BankName (string)
Accounts (List<BankAccount>)

Implement the following methods in the Bank class:
AddAccount(BankAccount account): Adds a new account to the Accounts list.
GetAccount(int accountNumber): Returns the account with the specified account number.
GetAllAccounts(): Returns a list of all accounts in the bank.
Deposit(int accountNumber, double amount): Deposits the specified amount into the account with the specified account number.
Withdraw(int accountNumber, double amount): Withdraws the specified amount from the account with the specified account number)


Implement a simple console application to test the Bank class.*/





using System;
using System.Collections.Generic;

class BankAccount
{
    public int AccountNumber { get; set; }
    public string AccountHolderName { get; set; }
    public double Balance { get; set; }
}

class Bank
{
    public string BankName { get; set; }
    public List<BankAccount> Accounts { get; set; }

    public Bank(string bankName)
    {
        BankName = bankName;
        Accounts = new List<BankAccount>();
    }

    public void AddAccount(BankAccount account)
    {
        Accounts.Add(account);
    }

    public BankAccount GetAccount(int accountNumber)
    {
        return Accounts.Find(account => account.AccountNumber == accountNumber);
    }

    public List<BankAccount> GetAllAccounts()
    {
        return Accounts;
    }

    public void Deposit(int accountNumber, double amount)
    {
        BankAccount account = GetAccount(accountNumber);
        if (account != null)
        {
            account.Balance += amount;
        }
    }

    public void Withdraw(int accountNumber, double amount)
    {
        BankAccount account = GetAccount(accountNumber);
        if (account != null)
        {
            if (account.Balance >= amount)
            {
                account.Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Bank bank = new Bank("MyBank");

        BankAccount account1 = new BankAccount { AccountNumber = 1001, AccountHolderName = "John Doe", Balance = 5000 };
        BankAccount account2 = new BankAccount { AccountNumber = 1002, AccountHolderName = "Jane Smith", Balance = 10000 };

        bank.AddAccount(account1);
        bank.AddAccount(account2);

        Console.WriteLine("All accounts:");
        foreach (BankAccount account in bank.GetAllAccounts())
        {
            Console.WriteLine($"Account Number: {account.AccountNumber}, Account Holder Name: {account.AccountHolderName}, Balance: {account.Balance}");
        }

        Console.WriteLine();

        BankAccount johnsAccount = bank.GetAccount(1001);
        Console.WriteLine($"John's Account: Account Number: {johnsAccount.AccountNumber}, Account Holder Name: {johnsAccount.AccountHolderName}, Balance: {johnsAccount.Balance}");

        Console.WriteLine();

        bank.Deposit(1001, 1000);
        Console.WriteLine($"John's Account after deposit: Account Number: {johnsAccount.AccountNumber}, Account Holder Name: {johnsAccount.AccountHolderName}, Balance: {johnsAccount.Balance}");

        Console.WriteLine();

        bank.Withdraw(1002, 5000);
        BankAccount janesAccount = bank.GetAccount(1002);
        Console.WriteLine($"Jane's Account after withdrawal: Account Number: {janesAccount.AccountNumber}, Account Holder Name: {janesAccount.AccountHolderName}, Balance: {janesAccount.Balance}");
    }
}
