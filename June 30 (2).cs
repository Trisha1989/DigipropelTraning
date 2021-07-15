using System;
using System.Collections.Generic;
public class Listassignment
    {
        

        public static void Main(string[] args)
        {
           
            string FirstName, SecondName;                            // declaration of two string values
            List<string> name = new List<string>();                  // declaration of List
			
            Console.WriteLine("Enter FirstName :\n");                // write a massage on console to enter the first name
            FirstName = Console.ReadLine();
			
            Console.WriteLine("Enter SecondName:\n");                // write a massage on console to enter the second name
            SecondName = Console.ReadLine();
			
            name.Add(FirstName);                                      // addition of elements to the list using inbuilt Add method of the list 
            name.Add(SecondName);
            name.Sort();                                               // sorting of elements of the list using inbuilt Sort method of the list 

        Console.WriteLine("Entered names in sorted order: ");
            foreach (string srt in name)                              // foreach loop to read each string value in the list "name"
           
            {
                Console.WriteLine(srt);

            }

            
        }
    }

/*
Enter FirstName :

maya
Enter SecondName:

asha
Entered names in sorted order: 
asha
maya
*/