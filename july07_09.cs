using System;
using System.IO;
class FileRecords // defining class FileRecords
{
    public static void Main()
    {
        //defined path of the file from local drive 
        FileStream inFile = new FileStream(@"C:\Users\user\Desktop\textfile.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(inFile);
        string record;
        string input;
        Console.Write("Enter the word in the line to  find :\n");
        input = Console.ReadLine();
        try
        {
            //read the record and displays it on the screen
            record = reader.ReadLine();
            while (record != null)
            {
                if (record.Contains(input))
                {
                    Console.WriteLine(record);
                }
               
                    record = reader.ReadLine();
               
            }
        finally
        {
            //Closing the file
            reader.Close();
            inFile.Close();
        }   
        Console.ReadLine();
    }
}
    /*Output
        Enter Friend's Birth Month >>present
        In the program it is present for the pionters.
    */