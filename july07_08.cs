using System;

   public class Encryption // defining Encryption class and its methods
    {
        public static string Encrypt(string text)  // defining Encrypt method
        {
            int alphInt = 0;
            char singleAlph = ' ';
            string textEncripted = "";
            for (int i = 0; i < text.Length; i++)
            {
                alphInt = (int)text[i] + 1;// converting alphabet to ascii integer and adding +1 to that int
				//Console.WriteLine("ascii integer value : {0}",alphInt);
                singleAlph = (char)alphInt; // converting the ascii int to char alphabet again
                textEncripted += singleAlph.ToString(); // joining the alphabet
            }
            return textEncripted;
        }
 
        public static string Decrypt(string text) // defining Decrypt method
        {
            int alphInt = 0;
            char singleAlph = ' ';
            string textDecripted = "";
            for (int i = 0; i < text.Length; i++)
            {
                alphInt = (int)text[i] - 1;
                singleAlph = (char)alphInt;
                textDecripted += singleAlph.ToString();
            }
            return textDecripted;
        }
    }
 
   public class TextEncripted
    {
       public static void Main()
        {
          
            string newText = Encryption.Encrypt("Hello");
            Console.WriteLine("Text encripted: {0}", newText);
            string TextDescripted = Encryption.Decrypt(newText);
            Console.WriteLine("Text Decripted: {0}", TextDescripted);
 
           
        }
    }
/*
Text encripted: Ifmmp
Text Decripted: Hello
*/