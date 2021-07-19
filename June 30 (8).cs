using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppercaseProg
{
    public class Assignment08
    {
        public static void Main(string[] args)
        {
          
            string str = "C# is used to develop web apps, desktop apps, mobile apps, games and much more."; //declaration of the statement
            Console.WriteLine("Original string:   " + str);

            char[] ch = str.ToCharArray();                                // seperating the statement in character array for each character
            StringBuilder sb = new StringBuilder();                       

            for (int i = 0; i < ch.Length; i++)                           //for loop for transversing the array
            {
                if (i % 2 == 0)                                           //declaring if condition for even no words
                {
                    ch[i] = char.ToUpper(ch[i]);                        

                }
                //string.join method not used here
                sb.Append(ch[i].ToString());                       // joining the alphabets to make a complete statement  

            }

            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}

/*
 Original string:   C# is used to develop web apps, desktop apps, mobile apps, games and much more.
C# iS UsEd tO DeVeLoP WeB ApPs, DeSkToP ApPs, MoBiLe aPpS, gAmEs aNd mUcH MoRe.
 * 