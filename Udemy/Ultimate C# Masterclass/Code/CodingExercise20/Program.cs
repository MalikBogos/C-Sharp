﻿var tuesday = NumberToDayOfWeekTranslator.Translate(0);

Console.WriteLine(tuesday);
Console.ReadKey();

public static class NumberToDayOfWeekTranslator
{

    public static string Translate(int number)
    {
        switch (number)
        {
            case 1:
                return "Monday";
            case 2:
                return "Tuesday";
            case 3:
                return "Wednesday";
            case 4:
                return "Thursday";
            case 5:
                return "Friday";
            case 6:
                return "Saturday";
            case 7:
                return "Sunday";
        }
        return "Invalid day of the week";
    }
}