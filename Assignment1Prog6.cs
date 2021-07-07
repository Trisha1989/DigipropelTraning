
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    public class IfElse                   // declare class name followed by class definition
    {
        public static void Main()
        {
            string firstword;
            Console.Write("Input a string : ");
            firstword = Console.ReadLine();

            if (firstword.Length == 6 && firstword.Equals("Trisha"))
            {
                Console.WriteLine("true" + " " + "String starts with a specified word Trisha");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(" string doesnt match word is" + " " + firstword);
                Console.ReadLine();
            }
        }
    }
}

/*
 Input a string : Trisha
true String starts with a specified word Trisha
*/