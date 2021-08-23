using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrrayStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int friends = 3;                                    // Declarition of an integerger type variable
            Person[] persons = new Person[friends];            //Declare an array 

            for (int i = 0; i < friends; i++)                   // For loop for traversing of an array
            {
                persons[i] = new Person()                       //defines three names of people from the user and stores them in an array of objects of type Person
                {
                    Name = Console.ReadLine()                     
                };
            }

            for (int i = 0; i < friends; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }

            Console.ReadLine();
        }

        public class Person                          //Create a person class that has a name property of a string type
        {
            public string Name { get; set; }        // get method is used to returns the value of the variable name and set method is use to assigns a value to the name variable
		
            public override string ToString()       ////Name property of type string and override the ToString() method
            {
                return "My name is " + Name;
            }

        }
    }
}

/*
 Priya
Riya
Mariya
My name is Priya
My name is Riya
My name is Mariya


 */
