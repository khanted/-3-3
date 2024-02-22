using System;

public class WeekDaysPrinter : IPrintable
{
    public void Print()
    {
        string[] days = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        foreach (string day in days)
        {
            Console.WriteLine(day);
        }
    }
}