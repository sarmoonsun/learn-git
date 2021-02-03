using System;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            String name; 
            Console.WriteLine("Hello World!");
            Console.WriteLine("please enter your name");
            name = Console.ReadLine();
            name = name.ToLower();
            if (name == "iman" )
            {
                Console.WriteLine("your name is correct");
               
            }
            else
               {
                   Console.WriteLine($"u dont know your name hahahah");
                   
               } 
            Console.WriteLine($" your name is Iman");
        }
    }
}
