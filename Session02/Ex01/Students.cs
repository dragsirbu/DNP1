using System;

namespace Ex01
{
    public class Student
    {
        public virtual void SayHi() 
        {
            Console.WriteLine("Hi, I am a student!");
        }
    }

    public class DNPStudent : Student
    {
        public override void SayHi()
        {
            Console.WriteLine("Hi, I am a DNP student!");
            // base.SayHi();
        }
    }
} 