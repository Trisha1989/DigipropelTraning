using System;
public class CarProgramForInterface
{
    //Defining an interface called Ivehicle having two methods drive and refuel
    public interface Ivehicle 
    {
        void Drive();
        bool Refuel(int amount);
    }
    public class Car :Ivehicle //Car class with a builder
    {
        public int fuel{ get; set;} //To set up initial fuel values
        public Car(int Fuel)
        {
            fuel = Fuel ;
        }
        public void Drive() //Drive method which prints on the screen where the car is Driving or not
        {
            if( fuel > 0 )
            {
                Console.WriteLine("the car is driving");
            }
            else
            {
                Console.WriteLine("No fuel, Please Refuel the Car");
            }
            
        }
        public bool Refuel(int amount)
        {
            fuel += amount; // fuel = fuel + amount
            return true;
        }
    }
    
    public static void Main ()
    {
        Car obj1 = new Car(0); // creation and instantiation of car object
        Console.WriteLine("Enter the speed of car:");
        int Fuel = int.Parse(Console.ReadLine());
        if (obj1.Refuel(Fuel))
        {
            obj1.Drive();
        }
    }
}
/*
Enter the speed of car:
0
No fuel, Please Refuel the Car
*/