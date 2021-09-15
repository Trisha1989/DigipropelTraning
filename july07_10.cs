using System;
//Defining a class "Table"  having a constructor setting the values of width and height of the board
public class Table // Created a class Table
{
 private float width, height; //defining private attributes width and height
 
 public Table(float width, int height) // parameterised constructor
 {
     this.width=width;
     this.height=height;
 }

 public float Width
 {
 set { width = value; }
 get { return width; }
 }

 public float Height
 {
 set { height = value; }
 get { return height; }
 }

 //method "ShowData" to display the width and height of the table.
	public void Showdata()
		{
		    Console.WriteLine("Width: "+width.ToString()+"\nHeigth: "+ height.ToString());
		    
		}
}
 
	public class Program{
public void Main()
{
	int i;
	//Defining an array containing 10 tables, with random sizes between 50 and 200 cm, and display all the data.
	Table[] obj = new Table[10]; // Created a Table with 10 array size
	Random rndgen = new Random();// declared for random size 
	for (i=0; i<10; i++)
		obj[i] = new Table(rndgen.Next(50, 201), rndgen.Next(50, 201)); // looping through array to get random size bet 50 and 200.
	for (i=0; i<10; i++)
 		obj[i].Showdata();
}
}
/*
output : Width: 52, Heigth: 176
Width: 132, Heigth: 102
Width: 128, Heigth: 77
Width: 156, Heigth: 87
Width: 152, Heigth: 115
Width: 140, Heigth: 92
Width: 138, Heigth: 139
Width: 151, Heigth: 179
Width: 52, Heigth: 140
Width: 184, Heigth: 165
*/