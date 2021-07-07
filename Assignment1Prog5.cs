using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign
{
    public class IfElse                   // declare class name followed by class definition
    {
        public static void Main()                 
        {
            Console.WriteLine("Enter 1st number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("if two values are equal return thrice the sum:");

            int result = (num1 + num2);

            if (num1 == num2)
            {
			
			/*
			Enter 1st number:
3
Enter 2nd number:
2
if two values are equal return thrice the sum:
5 the two values are not equal
> 
			*/
			
			/*
			Enter 1st number:
2
Enter 2nd number:
2
if two values are equal return thrice the sum:
64
			*/