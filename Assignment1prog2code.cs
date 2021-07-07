using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June25.cs
{
    class June25								// declare class name followed by class definition
    { 
     public void Multiplication(int n1, int n2)						// define Multiplication method 
    {
            int result = (n1 * n2);
            Console.WriteLine("The multiplication of two number is:" + result);
            
    }
     public void Add(int n1, int n2)                             // define Addition method 
    {
            int result = (n1+n2);
            Console.WriteLine("The addition of two number is:" + result);
            
        }
     public void Divi(int n1, int n2)                            // define Division  method 
    {
            int result = (n1/n2);
            Console.WriteLine("The Division of two number is:" + result);
            
        }
        public void Sub(int n1, int n2)                          //define Substraction  method
        {
            int result = (n1-n2);
            Console.WriteLine("The substraction of two number is:" + result);
            
        }
        public static void Main(string[] args)
        {
            int num1, num2;									// delacare two integer variables
            Console.WriteLine("Enter two numbers");			// Write message on console to enter thhe two integer numbers

            Console.WriteLine("Enter 1st number");					 // Write message on console to enter thhe 1st  integer number
            num1 = int.Parse(Console.ReadLine());  					// Reads the input string entered on the console by the user and convert the string to integer (type casting) and assign its value to variable num1		
            Console.WriteLine("The value of 1st number =" + num1); // Write message on the console to show the value set for 1st number
            

            Console.WriteLine("Enter 2nd number");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The value of 2nd number =" + num2);
            

            June25 obj25 = new June25();		// creates an object of class June25 by calling the constructor June25()
            obj25.Multiplication(num1,num2);  // call multiplication method (parameterized method - accepting two interger type parameters/arguments) of object obj25
            obj25.Add(num1, num2);
            obj25.Divi(num1, num2);
            obj25.Sub(num1, num2);
			Console.ReadLine();
			
        }
    }
}
