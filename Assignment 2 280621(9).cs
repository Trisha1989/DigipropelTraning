using System;
namespace Ascendarry
{
    public class Ascearry
    {
        public static void Main(string[] args)
        {

            int n;                                                // declare a variable of an integerger type
            Console.WriteLine("Input the size of array : ");      // write message on the console to ask user to enter the number of elements 
            n = Convert.ToInt32(Console.ReadLine());              // get the number of elements from the console and store it in integer variables by doing type casting to int from string

            int[] list = new int[n];                              //Declare an array of int type
            Console.WriteLine("Input {0} elements in the array :", n);
            for (int i = 0; i < n; i++)                           // for loop for reading the element of an array
            {
                Console.Write("element - {0} : ", i);
                list[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Original Unsorted List");          // get the original unsorted list
            foreach (int i in list)
            {
                Console.Write(i + " ");                           
               
            }
            Array.Sort(list);                                     // To sort thr array in ascending order                 
            Console.WriteLine("\n Sorted List");
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
/*
 Input the size of array :
4
Input 4 elements in the array :
element - 0 : 5
element - 1 : 2
element - 2 : 9
element - 3 : 4
Original Unsorted List
5 2 9 4
 Sorted List
2 4 5 9
 */