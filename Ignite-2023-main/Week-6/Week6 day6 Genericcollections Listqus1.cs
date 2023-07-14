/* QUESTION1 BANKING SYSTEM
Define a BankAccount class with the following private data members:
customerName (string)
accountNumber (int)
balance (double)
Define a constructor for the BankAccount class that takes three parameters:
name (string)
number (int)
initialDeposit (double)
Implement the following public member functions in the BankAccount class:
Deposit(double amount): Adds the specified amount to the account balance.
Withdraw(double amount): Subtracts the specified amount from the account balance if sufficient funds are available.
Show(): Prompts the user to enter their name, account number, and initial deposit, and then displays the account information.
In the Main method, create a new BankAccount object with initial values of empty string, 0, and 0.
Call the Show method to prompt the user to enter the initial values for the account.
Prompt the user to enter the amount to deposit using Console.ReadLine(), and then call the Deposit method with the entered value.
Call the Show method to display the updated account information.
Prompt the user to enter the amount to withdraw using Console.ReadLine(), and then call the Withdraw method with the entered value.
Call the Show method to display the updated account information.

Sample Input:
Please enter your name(s), separated by commas:
John Doe
Please enter your account number:
1001
Please enter your initial deposit:
5000
Please enter the amount to deposit:
1000
Please enter the amount to withdraw:
2000


Sample Output:
Customer Account Information
Account Number: 1001
Customer Name(s):
John Doe
Balance: 5000

Customer Account Information
Account Number: 1001
Customer Name(s):
John Doe
Balance: 6000

Customer Account Information
Account Number: 1001
Customer Name(s):
John Doe
Balance: 4000 */




using System;
using System.Collections.Generic;

class BankAccount
{
    private string customerName;
    private int accountNumber;
    private double balance;

    public BankAccount(string name, int number, double initialDeposit)
    {
        customerName = name;
        accountNumber = number;
        balance = initialDeposit;
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }
    }

    public void Show()
    {
        Console.WriteLine("Please enter your name(s), separated by commas: ");
        string names = Console.ReadLine();

        List<string> nameList = new List<string>(names.Split(','));

        Console.WriteLine("Please enter your account number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter your initial deposit: ");
        double deposit = Convert.ToDouble(Console.ReadLine());

        customerName = names;
        accountNumber = number;
        balance = deposit;

        Console.WriteLine("Customer Account Information");
        Console.WriteLine("Account Number: {0}", accountNumber);
        Console.WriteLine("Customer Name(s):");
        foreach (string name in nameList)
        {
            Console.WriteLine(name.Trim());
        }
        Console.WriteLine("Balance: {0}", balance);
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount("", 0, 0);

        account.Show();

        Console.WriteLine("Please enter the amount to deposit: ");
        double depositAmount = Convert.ToDouble(Console.ReadLine());
        account.Deposit(depositAmount);
        account.Show();

        Console.WriteLine("Please enter the amount to withdraw: ");
        double withdrawAmount = Convert.ToDouble(Console.ReadLine());
        account.Withdraw(withdrawAmount);
        account.Show();
    }
}
