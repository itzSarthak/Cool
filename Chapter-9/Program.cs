using System;
namespace PolymorphismDemo
{
    /*
        In C#, polymorphism allows methods to behave differently based on the object they belong to.
        It comes in two forms:

            1. Compile-time Polymorphism (Static Binding): Achieved via method overloading.
            2. Run-time Polymorphism (Dynamic Binding): Achieved via method overriding with inheritance.
    */
    
    // Base class representing a generic Employee
    public class Employee
    {
        /*
             $$ Run-time Polymorphism using Virtual Method
             
             $$ The virtual keyword in C# is used to indicate that
                 a method in a base class is intended to be overridden in derived classes.
                 This keyword is essential for implementing run-time polymorphism
                 (also known as dynamic binding or method overriding) in inheritance-based designs.
                 
             Virtual Methods may or may not be overriden from its childs .
             However an abstract method must be overriden .
        */
        
        
        public virtual void DisplayRole()
        {
            Console.WriteLine("Employee role is undefined.");
        }

        // Compile-time Polymorphism using Method Overloading
        public void Work(int hours)
        {
            Console.WriteLine($"Employee works {hours} hours.");
        }

        public void Work(int hours, string project)
        {
            Console.WriteLine($"Employee works {hours} hours on project: {project}.");
        }
    }

    // Derived class for Full-Time Employees
    public class FullTimeEmployee : Employee
    {
        public override void DisplayRole()
        {
            Console.WriteLine("Role: Full-Time Employee.");
        }
    }

    // Derived class for Part-Time Employees
    public class PartTimeEmployee : Employee
    {
        public override void DisplayRole()
        {
            Console.WriteLine("Role: Part-Time Employee.");
        }
    }

    // Main Program demonstrating polymorphism
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Compile-Time Polymorphism (Method Overloading):");
            Employee emp = new Employee();
            emp.Work(8);                                // Calls first overload
            emp.Work(5, "Project A");             // Calls second overload

            Console.WriteLine("\nRun-Time Polymorphism (Method Overriding):");
            Employee fullTimeEmp = new FullTimeEmployee();
            Employee partTimeEmp = new PartTimeEmployee();

            fullTimeEmp.DisplayRole();           // Calls overridden method in FullTimeEmployee
            partTimeEmp.DisplayRole();           // Calls overridden method in PartTimeEmployee
        }
    }
}