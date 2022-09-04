using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }

    public bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
    }
}