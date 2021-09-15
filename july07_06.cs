using System;

    interface AStack // created a interface called AStack
    {
        void Push(int v); //Declaration of Push method with return type as void 
        int Pop(); //Declaration of Pop method with return type as int
        int Length { get; } //Declaration of Length method with return type as int 
    }

   public class StackFullException : Exception //C# exceptions are represented by classes. The exception classes in C# are mainly directly or indirectly derived from the System.Exception class
    {
        public StackFullException()
            : base("Stack Full") // this will throw an exception along with stack trace address
        {
        }
    }

   public class StackEmptyException : Exception //C# exceptions are represented by classes. The exception classes in C# are mainly directly or indirectly derived from the System.Exception class
    {
        public StackEmptyException()
            : base("Stack Empty")
        {
        }
    }
//Create a class Stack which implements interface AStack defined above and implement methods Push(), Pop() and Length()
   public class Stack  : AStack 
    {
        private int[] a = new int[10];  // declare integer type of array
        public int top = 0;

        public void Push(int v) // implementation of Push method
        {

            if (top == 10)
			{
                throw new StackFullException(); // This will call class stackFullExecption
			}

            a[top] = v;
            top++;
        }

        public int Pop() // implementation of Pop method
        {
		
            if (top == 0)
                throw new StackEmptyException(); //// This will call class stackEmptyExecption
			
            top--;
            return a[top];
        }

        public int Length// // implementation of Length method - integer with getter as return  as top value
        {
            get
            {
                return top;
            }
        }
    }

   public class UseStack
    {
        public static void Main()
        {
            Stack s = new Stack(); // object instantiation
            s.Push(20);

            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Length);

            //Console.WriteLine(s.Pop()); //remove the comment to see the flow goes in stackemptyexecption and will throw stack empty exeption			
			
			s.top=10;
			s.Push(20);

           
        
    }
}
/*
20
0
Run-time exception (line 36): Stack Full

Stack Trace:

[StackFullException: Stack Full]
   at Stack.Push(Int32 v) :line 36
   at UseStack.Main() :line 75
   */