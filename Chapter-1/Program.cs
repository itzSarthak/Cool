using System;

// Top Level Statements
    Console.WriteLine("This is Entry Point for C# Tutorials");
    Console.WriteLine("This is a Top Level Statement");

    string input = Console.ReadLine();
    Myspace.Program.Main(input.Split(' '));

namespace Myspace
{
    // Let's revisit C# 
    public class Program
    {
        // Entry point of the program in the absence of top level statement **
        public static int Main(string[] args)
        {
            // If any arguments **
            if(args.Length > 0)
                Console.WriteLine($"Miracle\n Miracle {args[0]}"); 
            
            var helloWorld = "Hello, World!!";
            Console.WriteLine(helloWorld);  
            
            var startDate = DateTime.Now;
            Console.WriteLine(startDate);
            
            // Escape Characters & Verbetan Strings **
            string speech = "She said \"Sarthak is a Liar\"";
            Console.WriteLine(speech);

            
            string path = "C:\\Users\\Sarthak_Rai\\OneDrive\\Documents\\Projects\\C# Tutorials";
            Console.WriteLine(path);
            // First '\' is an escape Character"

            
            // Using @ to stores path and ignore escape charactes
            path = @"C:\Users\Sarthak_Rai\OneDrive\Documents\Projects\C# Tutorials";
            Console.WriteLine(path);

            // ## Fun 1
            string? sentence = string.Empty;
            Console.WriteLine(sentence);
            
            // ## Fun 2
            string teamA = "INDIA";
            string teamB = "INDIA";
            
            //if(teamA == teamB)
            
            // '==' operator checks value as well as memory *
            // Equals checks value only ***
            
            if(teamA.Equals(teamB))
                Console.WriteLine("Same team");
            else
                Console.WriteLine("Different team");
            
            // Fun 3
            var teamC = teamA.Substring(0,3);
            Console.WriteLine(teamC);
            
            Console.Write(teamA[0]);
            Console.Write(teamA[1]);
            Console.Write(teamA[2]);
            Console.WriteLine();
            
            // Fun 4
            Console.WriteLine(teamA.Contains(teamB));
            
            // Fun 5
            var teamD = "FRANCE";
            if(!string.IsNullOrEmpty(teamD))
                Console.WriteLine("A valid Team");
            
            if(!teamD.Equals(""))
                Console.WriteLine("A valid Team");
            
            if(teamD is not null)
                Console.WriteLine("A valid Team");

            string teamE = null;
            if(string.IsNullOrEmpty(teamE))
                Console.WriteLine("An Invalid Team");
            
            
            int age;
            string? name;
            char? gender;
            bool? isFlag;
            
            
            // Taking a string as an input 
            Console.WriteLine("Enter your name :");
            name = Console.ReadLine();
            
            // An integer as an input using differnt methods **
            Console.WriteLine("Enter your age :");
            
            //age = Convert.ToInt32(Console.ReadLine());
            bool isSuccess = int.TryParse(Console.ReadLine(), out int num);
            age = isSuccess ? num : 0;
            
            
            Console.WriteLine("Enter your gender :");
            gender = Convert.ToChar(Console.ReadLine())
            gender = char.Parse(Console.ReadLine());
          
            // Not only in reading inputs but parse functions basically
            // transformed one type to other .
            
            
             Console.WriteLine("Enter a flag : ");
             // isFlag = Convert.ToBool(Console.ReadLine()); 🤐🤐
             isFlag = bool.Parse(Console.ReadLine());
            
            // String Concatenation **
            Console.WriteLine("Hii, it's me " + name + " and I am " + age + " years old.");
            
            // String Interpolation **
            Console.WriteLine($"Hii, it's me {name} and I am {age} years old.");
            
            // String Formatting **
            Console.WriteLine("Hii, it's me {0} and I am {1} years old.", name, age);
            
            // Another One **
            Console.WriteLine(string.Concat("Hii, it's me ", name, " and I am ", age, " years old."));
            
            // Numbers 
                    byte x = 255;
                    short y = 1111;
                    int z = 2 ^ 20;
                    long zz = z * z;
            
            
            // Decimal Data Types **
            /*
                    While Declaring a variable of these types take extra care
                    as the source side (rhs) always are in double .
             */
            
            float pi = 3.14159f;
            double radius = 2.445;
            decimal area = ((decimal)pi * (decimal)radius * (decimal)radius);
            Console.WriteLine(area);
            
            // Characters & Booleans
            char sex = 'M';
            bool flag = true;
            return 0;
        }
    }
}

