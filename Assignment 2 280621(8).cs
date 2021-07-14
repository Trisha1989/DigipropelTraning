using System;
public class Decrement
{
    public static void Main()
    {
        int[] aar1 = new int[3];           // declare integer array of size 10 
        int a, i;                          //  // declare integer varaibles 
        Console.WriteLine("number of elements to store in array :");       // write message on the console to ask user to enter the number of elements 
        a = Convert.ToInt32(Console.ReadLine());                       // get the number of elements from the console and store it in integer variables by doing type casting to int from string

        Console.WriteLine("input {0} number of elements :", a);
        for (i = 0; i<a; i++)                                               // for loop for reading the elements of the array 
        {
            Console.WriteLine("element - {0} : ", i);
            aar1[i] = Convert.ToInt32(Console.ReadLine());                // for loop for reading the elements of the array 

        }
        Console.WriteLine("The values in the array are : ");
        for (i = 0; i <a; i++)
        {
            Console.WriteLine("{0}  ", aar1[i]);
        }
        for (i = a - 1; i >= 0; i--)                                      // for loop for getting the reverse elements in the array
        {
            Console.WriteLine("the values in reverse are {0} ", aar1[i]);
           
        }
        Console.ReadLine();
    }
}

/*
 number of elements to store in array :
3
input 3 number of elements :
element - 0 :
2
element - 1 :
5
element - 2 :
7
The values in the array are :
2
5
7
the values in reverse are 7
the values in reverse are 5
the values in reverse are 2 
 * 