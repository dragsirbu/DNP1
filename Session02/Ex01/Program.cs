using System;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
           Student student = new Student();
           student.SayHi();
           DNPStudent dnpStudent = new DNPStudent();
           dnpStudent.SayHi();
           Student upcast = dnpStudent;
           upcast.SayHi();
        }
    }
}
