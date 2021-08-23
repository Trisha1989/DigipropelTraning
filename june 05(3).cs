using System;
//1. created a class called PhotoBook
public class PhotoBook
{
    protected int numPages;                                                   //used protected so that main methed have access for numPages


    public int GetNumberPages()
    {
        return numPages;
    }

    public PhotoBook()                                                         // defined default constructor
    {
        numPages = 16;
    }

    public PhotoBook(int numPages)                                              // specifying no of pages using additional parameterized constructor
    {
        this.numPages = numPages;
    }

}

public class BigPhotoBook : PhotoBook                                           //used inheritance concept for bigphotobook and defined constructor
{
    public BigPhotoBook()
    {
        numPages = 64;
    }
}
public class PhotoBookTest
{
    public static void Main()                                                   //main method intracting with class PhotoBook
    {
        PhotoBook Book1 = new PhotoBook();
        Console.WriteLine(" Book1 number of pages :" + Book1.GetNumberPages());

        PhotoBook Book2 = new PhotoBook(24);
        Console.WriteLine(" Book2 number of pages :" + Book2.GetNumberPages());

        BigPhotoBook Book3 = new BigPhotoBook();
        Console.WriteLine(" Book3 number of pages :" + Book3.GetNumberPages());
        Console.ReadLine();
    }
}
/*
 Book1 number of pages :16
 Book2 number of pages :24
 Book3 number of pages :64
 */