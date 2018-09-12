using System;
namespace Ex05
{
    public class Time
    {
        public int Hours {get; set;}
        public int Minutes {get; set;}

        public Time(int hours, int minutes)
        {
            this.Hours = hours;
            this.Minutes = minutes;
        }

        public static Time operator +(Time t1, Time t2)
        {
            Time t3 = new Time(t1.Hours+t2.Hours, t1.Minutes+t2.Minutes);
            if (t3.Minutes > 59)
            {
                t3.Hours++;
                t3.Minutes -= 60;
            }
            if (t3.Hours > 23)
            {
                t3.Hours -= 24;
            }
            return t3;
        }
        public override String ToString()
        {
            return this.Hours+":"+this.Minutes;
        }

    }
}