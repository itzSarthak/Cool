using System;
namespace EncapsulationDemo
{
    /*
        $$ Encapsulation is the concept of bundling the data (attributes) and methods
             that operate on the data within a single unit or class. 
             It also restricts direct access to some of the object's components,
             which can be done using access modifiers.

        $$ Access Specifiers in C#:
            1. public: Accessible from any class.
            2. private: Accessible only within the same class.
            3. protected: Accessible within the same class and derived classes.
            4. internal: Accessible only within the same assembly.
            5. protected internal: Accessible within the same assembly and derived classes.
    */

    // Demonstrating encapsulation with private fields and public methods
    public class BankAccount
    {
        // Encapsulated private field
        private decimal balance;

        public void Deposit(decimal amount)
        {
            if (amount > 0)
                balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
                balance -= amount;
        }
        
        // Public method to retrieve the balance in a controlled way
        public decimal GetBalance()
        {
            return balance;
        }
    }

    // Program class to test encapsulation in BankAccount
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Object-Oriented Programming: Encapsulation and Access Modifiers");

            BankAccount bankAccount = new BankAccount();
            bankAccount.Deposit(100);
            bankAccount.Withdraw(50);
            var balance = bankAccount.GetBalance();
            Console.WriteLine("Balance after transactions: {0}", balance);

            Console.WriteLine("\nTesting Internal and Protected Internal Access Specifiers:");
            var derivedClass = new DerivedClass();
            derivedClass.TestProtectedInternalAccess();
        }
    }

    // CoreProject - Demonstrating internal and protected internal access specifiers

    // Internal class example, only accessible within the same assembly (EncapsulationDemo)
    internal class InternalClass
    {
        internal void DisplayInternalMessage()
        {
            Console.WriteLine("Internal method in InternalClass - accessible only within this assembly.");
        }
    }

    // Base class with a protected internal method, accessible within assembly and to derived classes
    public class BaseClass
    {
        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("Protected internal method in BaseClass - accessible within this assembly and derived classes outside.");
        }
    }

    // DerivedClass that extends BaseClass to demonstrate protected internal access
    public class DerivedClass : BaseClass
    {
        public void TestProtectedInternalAccess()
        {
            // Accessing protected internal method from the base class
            ProtectedInternalMethod();
            Console.WriteLine("Successfully accessed protected internal method in derived class.");

            // Trying to access InternalClass - only accessible within this assembly
            var internalClass = new InternalClass();
            internalClass.DisplayInternalMessage();
        }
    }
}
