using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
          // declaring a new list
          List<int> numbers = new List<int>();
          int sum = 0;

        // run the code if the user does nt press o 
        while (true)
        {
            Console.WriteLine("Enter a number, type 0 to finish: ");
            string numberText = Console.ReadLine();
            int number = int.Parse(numberText);

        if (number == 0)
        
            break;

            // this adds to the list called numbers 
            numbers.Add(number);

        }
        
        foreach (int num in numbers)
        {
            sum += num;

           
        }
        double average = (double) sum / numbers.Count;

        int maxNumber = numbers.Max();

         Console.WriteLine("The sum of numbers in the list is " +  sum);
         Console.WriteLine("The average number of " +  average);
         Console.WriteLine("The max number of " +  maxNumber);



    }
}