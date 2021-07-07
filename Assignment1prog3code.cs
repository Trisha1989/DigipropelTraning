using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June25.cs
{
    class June25
    { 
     public void Avg(int n1, int n2, int n3, int n4)
    {
            int result = (n1+n2+n3+n4)/2;
            Console.WriteLine("The Avg of two number is:" + result);
            Console.ReadLine();
    }
        
        public static void Main(string[] args)
        {
            int num1, num2, num3, num4;
            Console.WriteLine("Enter four numbers");

            Console.WriteLine("Enter 1st number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("The value of 1st number =" + num1);
            Console.ReadLine();

            Console.WriteLine("Enter 2nd number");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The value of 2nd number =" + num2);
            Console.ReadLine();

            Console.WriteLine("Enter 3rd number");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("The value of 3rd number =" + num3);
            Console.ReadLine();

            Console.WriteLine("Enter 4th number");
            num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("The value of 4th number =" + num2);
            Console.ReadLine();

            June25 obj25 = new June25();
            obj25.Avg(num1,num2,num3,num4);
            
        }
    }
}
