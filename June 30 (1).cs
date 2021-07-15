using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumeration
{
    
    class Program
    {
        enum Month        //declaration of an enum 
        {
            Jan,          // from line 13-26 enum values have been assigned

            Feb,
            Mar,
            Apr,
            May,
            Jun,
            Jul,
            Aug,
            Sep,
            Oct,
            Nov,
            Dec
        }
        static void Main(string[] args)
        { 
            Console.WriteLine("Choose valur from option : Jan, Feb, Mar, Apr...: ");
            String str = Console.ReadLine();
            // Month cal =0;// =  Month.parse(str);
            Enum.TryParse(str, out Month month);

            Month cal = Month.Jul;
            switch (cal)                           // switch statement to check the corresponding values
            { 
                case Month.Jan:
                Console.WriteLine("Month Jan");
                break;
                case Month.Feb:
                    Console.WriteLine("Month Feb");
                    break;
                case Month.Mar:
                    Console.WriteLine("Month Mar");
                    break;
                case Month.Apr:
                    Console.WriteLine("Month Apr");
                    break;
            
            }
            Console.ReadLine();
        }
        
    }
}
/*
 Choose valur from option : Jan, Feb, Mar, Apr...:

Jun

 */