using System;

namespace InheritanceDemo
{
    // Base Class representing a generic Account
    public class Account
    {
        // So that Child Class Can Access them !
        protected string AccountHolder;
        protected decimal Balance;

        // Constructor
        public Account(string accountHolder, decimal initialBalance)
        {
            AccountHolder = accountHolder;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
                Balance += amount;
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"{AccountHolder}'s Balance: {Balance}");
        }
    }

    // Single Inheritance - SavingsAccount inherits from Account
    public class SavingsAccount : Account
    {
        private decimal InterestRate;

        // Constructor Invoking -- From Parent to Child **
        public SavingsAccount(string accountHolder, decimal initialBalance, decimal interestRate)
            : base(accountHolder, initialBalance)
        {
            InterestRate = interestRate;
        }

        public void ApplyInterest()
        {
            Balance += Balance * InterestRate;
            Console.WriteLine("Interest applied to Savings Account.");
        }
    }

    // Multi-level Inheritance - FixedDeposit inherits from SavingsAccount
    public class FixedDeposit : SavingsAccount
    {
        private int TermInMonths;

        public FixedDeposit(string accountHolder, decimal initialBalance, decimal interestRate, int term)
            : base(accountHolder, initialBalance, interestRate)
        {
            TermInMonths = term;
        }

        public void DisplayTermDetails()
        {
            Console.WriteLine($"{AccountHolder} has a fixed deposit term of {TermInMonths} months.");
        }
    }

    // Hierarchical Inheritance - CurrentAccount also inherits from Account
    public class CurrentAccount : Account
    {
        private decimal OverdraftLimit;

        public CurrentAccount(string accountHolder, decimal initialBalance, decimal overdraftLimit)
            : base(accountHolder, initialBalance)
        {
            OverdraftLimit = overdraftLimit;
        }

        public void UseOverdraft(decimal amount)
        {
            if (amount <= OverdraftLimit)
            {
                Balance -= amount;
                Console.WriteLine($"Overdraft of {amount} used. Remaining Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Overdraft limit exceeded!");
            }
        }
    }

    // Main program to demonstrate inheritance types
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Single Inheritance:");
            SavingsAccount savingsAccount = new SavingsAccount("Alice", 1000, 0.05m);
            savingsAccount.DisplayBalance();
            savingsAccount.ApplyInterest();
            savingsAccount.DisplayBalance();

            Console.WriteLine("\nMulti-level Inheritance:");
            FixedDeposit fixedDeposit = new FixedDeposit("Bob", 2000, 0.07m, 12);
            fixedDeposit.DisplayBalance();
            fixedDeposit.ApplyInterest();
            fixedDeposit.DisplayBalance();
            fixedDeposit.DisplayTermDetails();

            Console.WriteLine("\nHierarchical Inheritance:");
            CurrentAccount currentAccount = new CurrentAccount("Charlie", 500, 200);
            currentAccount.DisplayBalance();
            currentAccount.UseOverdraft(100);
        }
    }
}
