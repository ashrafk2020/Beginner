using System;
namespace CsharpFundamentals
{
    public class Person
{
    private string name;
    public static string nationality = "Egyptian";

    public Person(string name)
    {
        this.name = name;
    }

    public void Introduce()
    {
       Console.WriteLine("Hello my name is {0}" , name);
    }
    
}
}
