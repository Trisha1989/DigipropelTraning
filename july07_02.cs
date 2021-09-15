using System;
public abstract class Animal // declare abstract class Animal
{
    private string Name; // declare a private attribute Name
    
    public void SetName(string name)  // method to set the attribute 
    {
        Name=name;
    }
    public string GetName() // method to get the attribute / return the attribute value
    {
        return Name ;
    }
    public abstract void Eat();
}
// defining a AbstractClass
public class AbstractClass
{
    public class Dog : Animal
{
public override  void Eat()
{
Console.WriteLine("The Dog is Eating ");
}
    public static void Main()
    {
        Dog obj1 = new Dog(); //object instantiation
        Console.WriteLine("Enter The Name of Dog ");
        obj1.SetName("Dog's Name : "+Console.ReadLine());
        Console.WriteLine (obj1.GetName());
        obj1.Eat();
    
    }
}
}


/*
Enter The Name of Dog 
shero
Dog's Name : shero
The Dog is Eating
*/