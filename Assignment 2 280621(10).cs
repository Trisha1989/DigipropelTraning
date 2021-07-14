using System;
using System.Text;
public class StringAddition
{
    public static void Main(string[] args)
    {
        int num1, num2, sumString, valueS3, valueS4, sum = 0;                           //declaration of integer type variables
        String s1, s2;                                                                 //declaartion of string type variables
        Console.Write("Input the size of array1 : ");                   // Write message on the console to get the size of 1st array 
        num1 = Convert.ToInt32(Console.ReadLine());     // Get the input of size of 1st array from the user on the console and read it and store it in the num1 integer type variable 
        Console.Write("Input the size of array2 : ");       // Write message on the console to get the size of 2nd array 
        num2 = Convert.ToInt32(Console.ReadLine());  // Get the input of size of 2nd array from the user on the console and read it and store it in the num2 integer type variable

        int[] arr1 = new int[num1];                                                   // declaartion of first intereg array
        int[] arr2 = new int[num2];                                                   // declaration of second integer array
        Console.Write("Input {0} elements in the array :\n", num1);
        for (int i = 0; i < num1; i++)                                                // for loop for the reading the elements of 1st array
        {
            Console.Write("element - {0} : ", i);                       
            arr1[i] = Convert.ToInt32(Console.ReadLine());                              // setting valules of elements of 1st integer array
        }
        Console.Write("Input {0} elements in the array :\n", num2);
        for (int i = 0; i < num2; i++)
        {
            Console.Write("element - {0} : ", i);
            arr2[i] = Convert.ToInt32(Console.ReadLine());                          // setting valules of elements of 2nd integer array
        }

        string[] strArray1 = Array.ConvertAll(arr1, ele => ele.ToString());        // convert the 1st integer array to string array  strArray1
        string[] strArray2 = Array.ConvertAll(arr2, ele => ele.ToString());     // convert the 2nd integer array to string array  strArray2


        valueS3 = Convert.ToInt32(string.Join("", strArray1));  // concatenates all the elemnts of the 1st string array and converts the final output to an integer and stores in integer varaible valueS3    
        valueS4 = Convert.ToInt32(string.Join("", strArray2));  // concatenates all the elemnts of the 2nd string array and converts the final output to an integer and stores in integer varaible valueS4

        sum = valueS3 + valueS4;  // add tha values of the two arrays and store result in integer variable sum
        Console.Write("{0} + {1} = {2}", valueS3, valueS4, sum); // print the values of sum of each array and the addition of both the arrays
        Console.ReadLine();


    }
}
/*
 Input the size of array1 : 3
Input the size of array2 : 2
Input 3 elements in the array :
element - 0 : 1
element - 1 : 3
element - 2 : 9
Input 2 elements in the array :
element - 0 : 2
element - 1 : 3
139 + 23 = 162
 */