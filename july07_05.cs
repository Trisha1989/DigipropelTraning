using System;

namespace st  //  defining the namespace
{
    abstract class Course  // declaring the abstract class
    {
		// defining the attributes
        protected string name;
        protected int duration;
        protected int coursefee;

        public Course(string name, int duration, int coursefee)// parameterized constructor
        {
            this.name = name;            
            this.duration = duration;
            this.coursefee = coursefee;
        }

        public virtual void Print() // method to print the attributes
        {
            Console.WriteLine(name);
            Console.WriteLine(duration);
            Console.WriteLine(coursefee);
        }

        public abstract int  GetTotalFee(); // abstract method
    }

    class ParttimeCourse : Course // implement the abstract class Course
    {
        private string timings;

        public ParttimeCourse(string name, int duration, int coursefee, string timings) : base(name,duration,coursefee) // parameterized constructor
        {
            this.timings = timings;
        }

        public override void Print() 
        {
            base.Print();
            Console.WriteLine(timings);
        }

        public override int GetTotalFee()
        {
            return (int)  (coursefee * 0.90); // 10% discount 
        }

    }

    class OnsiteCourse : Course // OnsiteCourse class inherits  Course 
    {
		// defining attributes
        private string company;
        private int nostud;

        public OnsiteCourse(string name, int duration, int coursefee, string company, int nostud) // parameterized constructor
            : base(name, duration, coursefee) // 
        {
            this.company = company;
            this.nostud = nostud;
        }

        public override void Print() // using override concepts 
        {
            base.Print();
            Console.WriteLine(company);
            Console.WriteLine(nostud);
        }

        public override int GetTotalFee()
        {
            return (int)(coursefee * 1.1);  // 10% more
        }

    }

    public class TestCourse
    {

        public static void Main() // main  method 
        {
            Course c = new OnsiteCourse("ASP.NET", 30, 5000, "ABC Tech", 10); // object instantiation
            c.Print();
            Console.WriteLine(c.GetTotalFee());

            c = new ParttimeCourse("C#", 30, 3000, "7-8pm");
            c.Print();
            Console.WriteLine(c.GetTotalFee());
        }


    }
}

/* output
ASP.NET
30
5000
ABC Tech
10
5500
C#
30
3000
7-8pm
2700
*/