using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("Nov 12 2024", 30, 3.0),
            new Cycling("Mar 03 2024", 45, 20.0),
            new Swimming("Feb 14 2024", 60, 40)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}