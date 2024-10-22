namespace cool
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // List<T> class in C# represents a strongly typed list of objects. 
            int[] array = { 2, 3, 4, 5 };
            
            // Declaration of a List
            List<int> numbers = new List<int>();
            List<string> names = new List<string>(3);
            
            Console.WriteLine($"Capacity of names list : {names.Capacity}");
            Console.WriteLine($"Count of names list : {names.Count}");
            
            // Insert Elements at End **
            numbers.Add(1);
            numbers.AddRange(array);
            
            names.Add("John");
            names.Add("Mary");
            names.Add("Jane");
            
            // List Size Expand when required **
            names.Add("Jim");
            
            // Seems like Capacity Increase by Two Fold Every Time List Expands 
            Console.WriteLine($"Capacity of names list : {names.Capacity}");
            Console.WriteLine($"Count of names list : {names.Count}");
            
            Console.WriteLine($"First Element in the names list : {names[0]}");
            Console.WriteLine($"Total number of elements in the names : {names.Count}");
            
            // Insert Method here **
            numbers.Insert(0,0);
            numbers.InsertRange(0,numbers);
            
            numbers.Sort();
            
            // Remove Method here **
            // First Occurance Will be removed 
            names.Remove("Jane");
            numbers.RemoveRange(0,2);
            names.RemoveAt(names.Count - 1);
            
            Console.WriteLine("Names Array : ");
            foreach (string name in names)
                Console.WriteLine(name);
            
            Console.WriteLine("Numbers  : ");
            foreach(int number in numbers)
                Console.WriteLine(number);
            
            Console.WriteLine("To Check if an element present in the  list :");
            
            Console.WriteLine($"Is 4 present ? {numbers.Contains(4)}"); 
            
            // In case of Abscence it will return -1 !!
            Console.WriteLine($"Index of 4 present ? {numbers.IndexOf(4)}");
            Console.WriteLine($"Index of 9 present ? {numbers.IndexOf(9)}");
            Console.WriteLine($"Is 5 present ? {numbers.LastIndexOf(5)}");
            
            
            // The result of this method is always based upon the zeroth index element **
            // I mean the counting start from first element **
            Console.WriteLine($"Starting From Second Index Is 5 present ? {numbers.IndexOf(5,2)}");
            
            // Above Method is HelpFul When We Want To Skip Searching For Some Intital Elements **
            // May be We Don't Want First Occurance 
            
            
            // Reverse Method & Binary Search
            Console.WriteLine($"Let Me Try Binary Search For '5' : {numbers.BinarySearch(5)}");
            numbers.Reverse();
            
            names.Clear();
            numbers.Clear();
            if(names.Count is 0 && numbers.Count is 0)
                Console.WriteLine("Everything is Clear");
        }
    }
}
