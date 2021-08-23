using System;
public class RandomNumber
{
   public static void Main()
    {
    //Random class to provides functionality to generate random numbers in C#
      Random random = new System.Random();
      Console.WriteLine("First Random Number is :" +(random.Next(0,1000)));          //will generate random no ranging 0 to 1000 from user
      Console.WriteLine("2nd random Number is : "+(random.Next(20,50)));             //will generate random no ranging 20 to 50 from user
      Console.WriteLine("3rd random Number is : "+(random.Next(10,50)));            //will generate random no ranging 10 to 50 from user
    }
}
/*
First Random Number is :989
2nd random Number is : 20
3rd random Number is : 48
*/