using System;


   public class Student
    {
		// defining attributes for Student class
        private int rollno;
        private string name;
        private string course;
        private int feepaid;
		
		//static member to store Service Tax, which is set to 12.3%
        private static double servicetax = 12.3;

        public Student(int rollno, string name, string course) // parameterised constructor defined
        {
            this.rollno = rollno;
            this.name = name;
            this.course = course;
        }

        public void Payment(int amount) // Payment method to calculate the feespaid
        {
            feepaid += amount;
        }

        public void PrintStdDetails()  // method to print the values of the attributes
        {
            Console.WriteLine("RollNO:{0}",rollno);
            Console.WriteLine("Name:{0}",name);
            Console.WriteLine("course: {0}",course);
            Console.WriteLine("Feepaid: {0}",feepaid);
        }

        public int DueAmount
        {

            get
            {
                return TotalFee - feepaid; //(call_2- total what is calculated in TotalFee - amount paid i.e 1000)
            }
        }

        public int TotalFee
        {
            get
            {
                double total = course == "c#" ? 2000 : 3000; // ternery operator (if course is c# then fee will be 2000 else 3000)
                // service tax
                total = total + total * servicetax / 100; // (call_1-suppose if course=asp.net then total is 12.3/100 * 2000 + 2000)
                return (int) total;
            }
        }

        public static double  ServiceTax // defined Static servicetax property-getters and setters 
        {
            get
            {
                return servicetax;
            }
            set
            {
                servicetax = value; // value = 12.3
            }
        }
    } 

   public class UseStudent2
    {

        public static void Main()
        {

            Student obj1 = new Student(45, "Karthik", "asp.net"); // object instantiation
            obj1.Payment(1000);
            obj1.PrintStdDetails();
            Console.WriteLine("Due Amount: {0}",obj1.DueAmount); // will call due amount for asp.net refer comment call_1 at line 49
	    Console.WriteLine();//for next line
			
            Student obj2 = new Student(13, "Mayank", "c#");  // object instantiation
            obj2.Payment(1000);
            obj2.PrintStdDetails();
            Console.WriteLine("Due Amount: {0}",obj2.DueAmount);


        }
    }
/*
RollNO:45
Name:Karthik
course: asp.net
Feepaid: 1000
Due Amount: 2369

RollNO:13
Name:Mayank
course: c#
Feepaid: 1000
Due Amount: 1246
*/