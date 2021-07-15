using System;
public class Foreaachloop
{
    public static void Main()
    {
        string str;                             // declaration of string variable
        int arry = 0;                           // declaration of int variable
        Console.Write("Input the string: ");
        str = Console.ReadLine();

        foreach (char characters in str)       // for each loop to accept string as input and traverse each character in the string.
        {
            arry = arry + 1;
         
            Console.Write("Length of the string is : {0}\n", arry);
        }
        Console.ReadLine();
        
        
    }
    
}
/*
Length of the string is :14
*/