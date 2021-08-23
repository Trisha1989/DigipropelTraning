using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    public class Program
    {
        public static void Main(string[] args)
        {
           int year;
		Console.WriteLine("Please enter the year to check year is a leap year or not/n");
		year = Convert.ToInt32(Console.ReadLine());
		
		if ((year % 400 == 0) || (year % 4 == 0))                      // if else condition to check for leap year using /4 and /400 and remainder=0
			{
				Console.WriteLine(year + "is a leap year");
			}
			else
			{
				Console.WriteLine(year +" "+ " is not a leap year ");
			}
		
            
                
        }
    }
}


/*
Please enter the year to check year is a leap year or not/n
2016
2016is a leap year
*/
		