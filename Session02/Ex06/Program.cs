using System;

namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            Schedule mySchedule = new Schedule();
            mySchedule[new DateTime(2018,9,6,7,15,0)] = "Wake Up.";
            mySchedule["Sep 5, 2018, 08:30:00"] = "Start Classes.";
            mySchedule[new DateTime(2018,9,6,12,0,0)] = "Have lunch.";
            mySchedule[new DateTime(2018,9,6,14,15,0)] = "Go home";

            foreach (DateTime key in mySchedule.Keys)
                Console.WriteLine($"Time: {key}, Activity: {mySchedule[key]}");
        }
    }
}
