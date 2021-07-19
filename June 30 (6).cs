using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppercaseProg
{
    public class Assignment06
    {
        public static void Main(string[] args)
        {
            string txt = "The quick brown fox jumps over the lazy dog";         //declaration and initialization of a string type 
            Console.WriteLine("Original string: " + txt);
            //using a function test(), to call class
            Console.WriteLine("Position of the word 'fox' in the said string: " + test(txt, "fox"));
            Console.WriteLine("Position of the word 'The' in the said string: " + test(txt, "The"));
            Console.WriteLine("Position of the word 'lazy' in the said string: " + test(txt, "lazy"));
            Console.ReadLine();
        }
        public static int test(string text, string word)              // method to call our test() function
        {

            string[] arry = text.Split(' ');           // separating the statemnt and putting it in string array 
            return Array.IndexOf(arry, word) + 1;

        }
    }
}
/*
 Original string: The quick brown fox jumps over the lazy dog
Position of the word 'fox' in the said string: 4
Position of the word 'The' in the said string: 1
Position of the word 'lazy' in the said string: 8
 
 */

