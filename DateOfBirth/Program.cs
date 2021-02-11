using System;
using System.Globalization;

namespace DateOfBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter date of your birth in solar(Sample: year/month/day)");
            string dateper = "";
            try
            {
            dateper = Console.ReadLine(); 
            
            }
            catch
            {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter your date of birth as a sample");
            Console.ResetColor();
            }
            string[] dateperlist = dateper.Split("/"); 
            int year =  Convert.ToInt32(dateperlist[0]);
            int month =  Convert.ToInt32(dateperlist[1]);
            int day =  Convert.ToInt32(dateperlist[2]);
           
            var mydate=new DateTime(year ,month, day , new PersianCalendar() );
            var nowdate = DateTime.Now;
            //date in solar convert to gregorian data
             int myyear = mydate.Year;
             int mymonth = mydate.Month;
             int myday = mydate.Day;
          

             int days = (nowdate.Day- myday);
             Console.WriteLine(days);
            if (days < 0)
				{

					nowdate = nowdate.AddMonths(-1);
					days += DateTime.DaysInMonth(nowdate.Year, nowdate.Month);
                    
				}
				 int months = nowdate.Month - mymonth;
                 Console.WriteLine();
				if (months < 0)
				{
					nowdate = nowdate.AddYears(-1);
					months += 12;
				}
				int years = (nowdate.Year - myyear);
				
             Console.WriteLine($"your age is :{years} years and {months} monthes and {days} days");
            Console.WriteLine("Please enter anykey for continuse......");
            


    
            Console.ReadKey();

        }
    }
}
