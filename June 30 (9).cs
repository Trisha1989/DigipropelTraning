using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppercaseProg
{
    public class Assignment09
    {
        class Program
        {
            public static void Main()
            {

                string str;                                          // declaration of the string value
                Console.WriteLine("enter the sentence:");
                str = Console.ReadLine();
                Console.WriteLine("\nOriginal string: " + str);
                Console.WriteLine("\nReverse all the words of the said string which have even length.:\n" + test(str));  // creating a test function to call in another method
                Console.ReadLine();
            }
            public static string test(string str)                     // method to call our test function
            {
				// first splitting the statement separated by space and applying condition to find even number of words 
				//Resversing the even number pf words and using string.joint to join th sentences again
                return string.Join(" ", str.Split(' ').Select(str2 => str2.Length % 2 != 0 ? str2 : new string(str2.Reverse().ToArray())));  
            }

        }
    }
}
/*
 enter the sentence:
#C si desu ot develop web sppa , desktop sppa , elibom sppa , games and hcum more

Original string: #C si desu ot develop web sppa , desktop sppa , elibom sppa , games and hcum more

Reverse all the words of the said string which have even length.:
C# is used to develop web apps , desktop apps , mobile apps , games and much erom
 */
