using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppercaseProg
{
    public class Assignment07
    {
        public static void Main(string[] args)

        {
            string txt = "python exercises";           //declarition and initialization of string type
            Console.WriteLine("Original string: " + txt);
            Console.WriteLine("After converting string to camalcase:\n" + test(txt));  //calling function test() of a string type

            txt = "The quick brown Fox jumps over the little lazy Dog";     //declarition and initialization of string type
            Console.WriteLine("\nOriginal string: " + txt);
            Console.WriteLine("After converting the string to camalcase:\n" + test(txt));  //calling function test() of a string type
            Console.ReadLine();

        }
        public static string test(string str1)    // declaration of Main method for test() function
        {
            
            string[] strArry = str1.Split(' ');   //spliting the string by space into string array
            for (int i = 0; i < strArry.Length; i++)
            {
                //converting the 1st character of substring to uppercase and adding rest of substring
                strArry[i] = strArry[i].Substring(0, 1).ToUpper() + strArry[i].Substring(1);
            }
            
            return string.Join(" ", strArry);
        }

    }
}
/*
 Original string: python exercises
After converting string to camalcase:
Python Exercises

Original string: The quick brown Fox jumps over the little lazy Dog
After converting the string to camalcase:
The Quick Brown Fox Jumps Over The Little Lazy Dog
 */

