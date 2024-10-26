using System.Security;
using System.Runtime.InteropServices;

namespace Functions
{
    class Function
    {
        // In order to invoke a non-static function
        // We must have an object **
        public void Run()
        {
            Console.WriteLine("I am Run() and I am non static!");
        }
        
        // A static Function doesn't require
        // an object to invoke **
        public static void Walk()
        {
            Console.WriteLine("I am Walk() and I am static!");
        }
        
        // Call by Value (you know **)
        // Call by reference (notice the ref keyword **)
        public static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        
        // Optional Parameter 
        // When Some Parameter are NOT Mandatory **
        public static int Add(int a, int b = default)
        {
            // In some cases we can have default as null 
            return a + b;
        }
        public static int Sub(int a, [Optional] int b)
        {
            // In order to use [Optional] we must be
            // using System.Runtime.InteropServices;
            return a - b;
        }
        
        // Named Parameter
        // While Invoking them we must map arguments with parameter **
        public static void PrintDetails(string Name, int Age, char Grade)
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade}");
        }
        
        
        // Out Parameter
        // This Method is returing and giving output at the same time **
        public static bool LinearSearch(List<int> list, int value,out int idx)
        {
            idx = -1;
            foreach (int i in list)
            {
                if (i == value)
                {
                    idx = i;
                    return true;
                }
            }
            return false;
        }
        
        // ## The Difference Between out Parameter & ref Parameter
            // $$ For a function having out parameter as parameter it must intialise it in the body .
            
            // $$ Intialisation in the body before return is not required .
    }
    class Program
    {
        public static void Main(string[] args)
        {
                Console.Title = "Sarthak";
                Console.WriteLine("Entry Point: Function Main()");
                Function.Walk();
                
                Function test = new Function();
                test.Run();
                
                // Default Parameter Check 
                int num1 = 3;
                Console.WriteLine($"{Function.Add(num1, num1)}");
                Console.WriteLine($"{Function.Add(num1)}");
                Console.WriteLine($"{Function.Sub(num1,num1)}");

                // Named Parameter Check 
                Function.PrintDetails("Sarthak",24,'9');

                string name = "Abhishek";
                int age = 22;
                char grade = 'A';
                Function.PrintDetails(Age:age,Grade:grade,Name:name);

                // Out Parameter Check 
                var list = new List<int>() { 4, 1, -2, 7, 11 };
                bool found = Function.LinearSearch(list, 7, out int dx);

                // Call by reference Check 
                int x = 4, y = -2;
                Console.WriteLine($"{x}, {y}");
                Function.swap(ref x, ref y);
                Console.WriteLine($"{x}, {y}");

        }
    }
}
