namespace cool
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // Dictionary in C #
            // You know what it does **
            Dictionary<char, string> genders = new Dictionary<char, string>();
            genders.Add('f', "female");
            genders.Add('m', "male");

            // Accessing Values With Keys **
            Console.WriteLine(genders['f']);
            Console.WriteLine(genders['m']);
            
            // When you are not sure weather key is present
            // And Don't Want Your Code to Breaks **
            var flag = genders.TryGetValue('g',out string result);
            if(flag)
                Console.WriteLine(result);
            else
                Console.WriteLine("INVALID GENDER");
            
            
            // Initialisation **
            Dictionary<int, string> names = new Dictionary<int, string>
            {
                {0,"Sarthak"},
                {1,"John"},
                {2,"Mary"},
                {3,"James"},
                
                // Duplicate Key is Not Possible
                // {2,"Test"} will give Run Time Error
                
                // Duplicate Value is Possible
                {4,"John"}
            };
            
            // Looping Over the Dictionary
            for (int i = 0; i < names.Count; i++)
            {
                //  print names[i] response will be value at key 'i' .

                // Pair is of type --> KeyValuePair<int,string>
                var pair = names.ElementAt(i); 
                Console.WriteLine($"Key : {pair.Key} \nValue : {pair.Value}");
            }
            
            // gn is of type KeyValuePair<char,string>
            foreach(var gn in genders)
                Console.WriteLine(gn.Key + " - " + gn.Value);
            
            
            // Check Present and then Removed
            if(names.ContainsKey(0))
                names.Remove(0);
            
            Console.WriteLine($"Is Sarthak Present ? {names.ContainsValue("Sarthak")}");
            Console.WriteLine($"Is 'f' present in gender? {genders.ContainsKey('f')}");
        }
    }
}
