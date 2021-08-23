using System;
//using System;



    public class Person                                //declaring the first public class Person
    {
        
        public int age;
        public void greet()
        {
            Console.WriteLine("Hello!");
        }
        public void SetAge(int n)
        {
            age = n;
        }
        public void explain()
        {
            Console.WriteLine("\n  I'm explaining on the screen Person Age Is :{0}", age); //declaring as per instructions from snippets
        }


    }
    
    public class Student : Person                                     // taking Student and Teacher classes inherit from the Person class
    {

        public void study()
        {
            Console.WriteLine("I'm studying on the screen");                   //declaring as per instructions from snippets
        }
        public void ShowAge()
        {
            Console.WriteLine("Student calss :: My age is: {0} years old on the screen", age);  //declaring as per instructions from snippets
        }
    }
    public class Teacher : Person                                       // taking Teacher and Person classes inherit from the Person class
    {
        public void explain()
        {
            Console.WriteLine("\n Teacher class:: I'm explaining on the screen Teacher Age Is :{0}", age); //declaring as per instructions from snippets
        }
    }
    // Main method for output that are defined in public class Person
    public class StudentProfessorTest
    {
        public static void Main()
        {
            Person obj1 = new Person();
            obj1.greet();


            Student obj2 = new Student();
            obj2.greet();
            obj2.SetAge(28);
            obj2.ShowAge();
            obj2.study();

            Person obj3 = new Teacher();
            obj3.SetAge(49);
            obj3.explain();
            obj3.greet();
            Console.ReadLine();

        }
    }
   /*
   Hello!
Hello!
Student calss :: My age is: 28 years old on the screen
I'm studying on the screen

  I'm explaining on the screen Person Age Is :49
Hello!
> 
   */