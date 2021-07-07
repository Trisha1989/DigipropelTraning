using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    public class IfElse                   // declare class name followed by class definition
    {
        static void Main()                 
        {
            Console.WriteLine("Enter 1st number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Check if one is positve and one is negative:");

            if ((num1 < 0 && num2 > 0) || (num1 > 0 && num2 < 0) && (num1 != 0 && num2 != 0))
            {
                Console.WriteLine("true" + " " + "one number is +ve and one is -ve");
            }
            else
            {
                Console.WriteLine("false");
                Console.ReadLine();
            }
        }
    }
}
/*
 * Enter 1st number:
5
Enter 2nd number:
6
Check if one is positve and one is negative:
false
 */
