using System;
class Person
{
    String name;
    public Person(String name)
    {
        this.name = name;
    }
     public  void Introduce() 
    {
     Console.WriteLine($"Hi, I am {name}!");
    }
}
