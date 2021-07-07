using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June25.cs
{
    class June25
    { 
     public void Multiplication(int n1, int n2)
    {
            int result = (n1 * n2);
            Console.WriteLine("The multiplication of two number is:" + result);
            Console.ReadLine();
    }
     public void Add(int n1, int n2)
    {
            int result = (n1+n2);
            Console.WriteLine("The addition of two number is:" + result);
            Console.ReadLine();
        }
     public void Divi(int n1, int n2)
    {
            int result = (n1/n2);
            Console.WriteLine("The Division of two number is:" + result);
            Console.ReadLine();
        }
        public void Sub(int n1, int n2)
        {
            int result = (n1-n2);
            Console.WriteLine("The substraction of two number is:" + result);
            Console.ReadLine();
        }
        public static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter two numbers");

            Console.WriteLine("Enter 1st number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("The value of 1st number =" + num1);
            Console.ReadLine();

            Console.WriteLine("Enter 2nd number");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The value of 2nd number =" + num2);
            Console.ReadLine();

            June25 obj25 = new June25();
            obj25.Multiplication(num1,num2);
            obj25.Add(num1, num2);
            obj25.Divi(num1, num2);
            obj25.Sub(num1, num2);
        }
    }
}
