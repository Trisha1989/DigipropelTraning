using System;

public class File
{
	public static void Main()
	{
		String line;
		int count = 0;
		
		//Opens a file in read mode
		//streamreader-enables a TextReader to reads characters from a byte stream in a particular encoding.
		
		System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\admin\Desktop\Sample.txt");
		
		while ((line = file.ReadLine()) != null)
		{
			//Splits each line into words
			String[] words = line.Split(' ');
			//Counts each word
			count = count + words.Length;
		}

		Console.WriteLine("Number of words present in given file: " + count);
		file.Close();
	}
}
/*Output:
C:\Users\admin>cd/Users/admin/Desktop/cd

C:\Users\admin\Desktop\cd>dotnet run
Number of words present in given file: 16*/