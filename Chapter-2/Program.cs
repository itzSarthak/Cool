using System;
using System.Collections.Immutable;

//Top Level Statements
    Console.WriteLine("This is Entry Point for C# Tutorials");
    Console.WriteLine("This is a Top Level Statement");

    Myspace.Program.Main();

namespace Myspace
{
    // Arrays
    public class Program
    {
        // Entry point of the program in the absence of top level statement **
        public static int Main()
        {
            string[] names = { "John", "Jane", "Doe" };
            
            string[] surname = new string[] {"Cena", "Kowalski", "Johnson" };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(string.Concat(names[i], " ",surname[i]));
            }

            int[] numbers = { -1, 4, 0, 7, 12, 5 };
            
            Console.WriteLine($"Length : {numbers.Length}");
            
            Console.WriteLine($"Sum : {numbers.Sum()}");
            
            Console.WriteLine($"Average : {numbers.Average()}");
            
            Console.WriteLine($"Min : {numbers.Min()}");
            
            Console.WriteLine($"Max : {numbers.Max()}");
            
            Array.Sort(numbers);
            foreach(var num in numbers)
                Console.WriteLine(num);
            
            
            // Array Inside Array
            
            // Galat Syntax
            // int[][] matrix = new int[][] { { 1, 2, 3, 4, 5 }, { 1, 1, 1, 1, 1 }, { 5, 4, 3, 2, 1 } };
            
            
            // Syntax of 2D Array is little different from C/C++
            
            // Declarations
            int[,] ages;
            
            // Initialisations
            string [,] people = new string[,] {{"John", "Jane", "Doe"},{"Kowalski", "Johnson", "Kowalski"}};
            
            // Accessing
            Console.WriteLine($"First Person is : {string.Concat(people[0, 0]," ",people[1, 0])}");
            
            // Loop through it 
            ages = new int[,] {{1,2},{4,5},{6,7}};
            
            // Difference Between Length & GetLength()
            
            // arr.Length gives total number of elements in an array **
            Console.WriteLine($"Total Elements in the ages array is : {ages.Length}");
            
            // The GetLength() method allows you to retrieve the size of a specific dimension of the array.
                
            // This will give the number of rows **
            // First Dimension is an array of arrays and it's size is three .
            Console.WriteLine($"Numbers of rows in the above array is : {ages.GetLength(0)}");
            
            // This will give the number of coloumns **
            // Second Dimension is an array having three elements .
            Console.WriteLine($"Numbers of coloumns in the above array is : {ages.GetLength(1)}");
            
            // This is Cool it is printing whole array using single loop
            foreach(var num in ages)
                Console.WriteLine(num);
            
            // How to take 2d array as input **
            string[,] random = new string[2,3];

            Console.WriteLine("Enter array elements row wise : ");
            
            for (int i = 0; i < random.GetLength(0); i++)
            {
                for(int j = 0; j < random.GetLength(1); j++)
                    random[i,j] = Console.ReadLine();
                
            }
            
            
            // Printing of the 2d Array
            Console.WriteLine("Final 2D Array");
            for (int i = 0; i < random.GetLength(0); i++)
            {
                for(int j = 0; j < random.GetLength(1); j++)
                    Console.Write(random[i, j] + " ");
                
                Console.WriteLine();
            }
            
            return 0;
        }
    }
}

