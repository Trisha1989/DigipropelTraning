using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June25.cs
{
    public class June25                                     // declare class name followed by class definition
    {
        public void Avg(int n1, int n2, int n3, int n4)             // define Average method 
        {
            {
            int result = (n1 + n2 + n3 + n4) / 4;
            Console.WriteLine("The Avg of four number is:" + result);
            Console.ReadLine();
        }

        public static void Main(string[] args)
        {
            int num1, num2, num3, num4;                         // delacare four integer variables
                Console.WriteLine("Enter four numbers");        // Write message on console to enter the four integer numbers

                Console.WriteLine("Enter 1st number");           // Write message on console to enter thhe 1st  integer number
                num1 = int.Parse(Console.ReadLine());             // Reads the input string entered on the console by the user and convert the string to integer (type casting) and assign its value to variable num1	
                Console.WriteLine("The value of 1st number =" + num1);    // Write message on the console to show the value set for 1st number

                Console.WriteLine("Enter 2nd number");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The value of 2nd number =" + num2);

            Console.WriteLine("Enter 3rd number");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("The value of 3rd number =" + num3);

            Console.WriteLine("Enter 4th number");
            num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("The value of 4th number =" + num2);

            June25 obj25 = new June25();                      // creates an object of class June25 by calling the constructor June25()
                obj25.Avg(num1, num2, num3, num4);            / call average method(parameterized method -accepting four interger type parameters/ arguments) of object obj25
            Console.ReadLine();
        }
    }
}
/*
 * Enter four numbers
Enter 1st number
2
The value of 1st number =2
Enter 2nd number
3
The value of 2nd number =3
Enter 3rd number
4
The value of 3rd number =4
Enter 4th number
6
The value of 4th number =3
The Avg of two number is:3
> 
 */