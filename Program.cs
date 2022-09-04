using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a year to check for if a leap year: ");
        string year = Console.ReadLine();
        Console.WriteLine(IsLeapYear(int.Parse(year)) ? "Yay" : "Nay");
    }

    public static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
    }
}