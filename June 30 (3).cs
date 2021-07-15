using System;
public class Exercise59
{
    public static void Main()
    {
        int row, column;

        Console.Write("\n\n");
        Console.Write("Display the pattern like 'B' with an asterisk:\n");
        Console.Write("\n\n");

        for (row = 0; row <= 6; row++)                        //for loop for traversing of rows
        {
            for (column = 0; column <= 6; column++)          //for loop for traversing of columns
            for (column = 0; column <= 6; column++)          //for loop for traversing of columns
            {
                if (column == 1 || ((row == 0 || row == 3 || row == 6) && (column < 5 && column > 1)) || (column == 5 && (row != 0 && row != 3 && row != 6)))
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.Write("\n");
        }
        Console.Write("\n");
        Console.ReadLine();
    }
}
/*
 Display the pattern like 'B' with an asterisk:
---------------------------------------------

 ****
 *   *
 *   *
 ****
 *   *
 *   *
 ****

 */