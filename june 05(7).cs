using System;
public class CompareDateTime 
{
 public static void Main() 
 {
	
    Console.WriteLine("Enter the date (mm/dd/yyyy :");       //asking primary date from user end
    DateTime date1 = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Starting Date : {0}", date1);
    
    
	Console.WriteLine("Enter the next date(mm/dd/yyyy) :");    //asking second date from user end
    DateTime date2 = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Seconday Date : {0}", date2);
    
    
	  if (date1 < date2)                        //appliting basic condition of greater and less then
	  {
          Console.WriteLine("{0} Occurs Before {1}", date1, date2);
	  }
	 else if (date1 > date2){
		 Console.WriteLine("{0} Occurs after {1}", date1, date2);
	 }
  }
}


/*
Enter the date (mm/dd/yyyy :
01/01/1990
Starting Date : 1/1/1990 12:00:00 AM
Enter the next date(mm/dd/yyyy) :
01/08/2020
Seconday Date : 1/8/2020 12:00:00 AM
1/1/1990 12:00:00 AM Occurs Before 1/8/2020 12:00:00 AM
*/
