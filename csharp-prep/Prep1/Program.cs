using System;

class Program
{
    static void Main(string[] args)
    {
        // asked the user for the name 
        Console.Write("what is your name: ");
        string name = Console.ReadLine();

        Console.Write("what s you last name name: ");
        string lastName = Console.ReadLine();

        Console.WriteLine("Your name is " + lastName + " , "  + name + " "+ lastName);
    }
}