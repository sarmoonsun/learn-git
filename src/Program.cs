using System;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            // string name; 
            // Console.WriteLine("Hello World!");
            // Console.WriteLine("please enter your name");
            // name = Console.ReadLine();
            // if (name.ToLower() == "iman" )
            // {
            //     Console.WriteLine("your name is correct");
               
            // }
            // else
            //    {
            //        Console.WriteLine($"u dont know your name hahahah");
                   
            //    } 
            // Console.WriteLine($" your name is {name}");
            // Console.WriteLine("Please Enter num of week:");
            // int num = Convert.ToInt32(Console.ReadLine());
            //  string[] name ={"iman","samane","gisou"};
            // for (int i=0 ;i<3;i++)
            // {
            //     Console.WriteLine(name[i]);
            
    
            // }
            Console.WriteLine("Please Enter Numbers of members:");
            int numofnumbers =Convert.ToInt32(Console.ReadLine());
            string[] Name = new string[numofnumbers];
            int index = 0;
            foreach(string name in Name)
            {
                  Console.WriteLine("Please Enter name :");
                  Name[index] = Console.ReadLine(); 
                  index++;
   
            }
            int j = 0;
            foreach(string name in Name)
            {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Name[j]);
            j++;
            Console.ResetColor();

            }

            


            Console.ReadKey();

        }
    }
}
