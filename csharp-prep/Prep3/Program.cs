using System;

class Program
{
    static void Main(string[] args)
    {
        
        //int guessNumber = 5;
        
        
        //Console.WriteLine("What is your magic Number: ");
        //string numberText = Console.ReadLine();
        //int number = int.Parse(numberText);

        // random nu,ber generation 

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

       int magicGuess = -1;

        while (magicGuess != magicNumber)
        {
            Console.WriteLine("What is Your magic number: ");
            string guessNumberText = Console.ReadLine();
            magicGuess= int.Parse(guessNumberText);

            if (magicGuess > magicNumber)
            {
                Console.WriteLine("Guess low!!");
            }
            else if (magicGuess<magicNumber)
            {
                Console.WriteLine("Guess high");
            }
            else
            {
                Console.WriteLine("You have guessed it coreectly!!! cograts !!!");
            }


        }

        
    }
}