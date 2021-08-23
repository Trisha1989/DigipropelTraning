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
            int size = 3;                                            //declaration of the integer type variable
            string Name;                                             // declaration of a string type variable

            Person[] persons = new Person[size];                       // created a array to store 3 names in it.

            for (int i = 0; i < size; i++)                            //for loop to store each name in each index of array
            {
                persons[i] = new Person(Name = Console.ReadLine());

            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(persons[i]); 
            }
        }   
    }
}
public class Person
{
    public string Name { get; set; }                       //defined a property(string)
    public Person(string name)
    {
        Name = name;
    }

    public override string ToString()                   //declare a overring method to take the value and return Name
    {
        Console.WriteLine("Constructors are called"); 
        return "Name :" + Name;
    }
    ~Person()                                           // destructor
    {
        Name = string.Empty;
        Console.ReadLine();
    }
    
}

/*
 Riya
Priya
Mariya
Constructors are called
Name :Riya
Constructors are called
Name :Priya
Constructors are called
Name :Mariya
 */