using System;

public class Program
{
    static void Main(string[] args)
    {
        try {
            UserInput();
        } catch(Exception e){
            Console.WriteLine(e.Message);
        }
    }

    public static void UserInput(){
        Console.WriteLine("Enter a year to check for if a leap year: ");
        string year = Console.ReadLine();
        Console.WriteLine(IsLeapYear(int.Parse(year)) ? "Yay" : "Nay");
    }

    public static bool IsLeapYear(int year)
    {
        if(year < 1582) throw new Exception("Year must be greater than 1582!");
        return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
    }
}