using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        
        //int guessNumber = 5;
        
        
        //Console.WriteLine("What is your magic Number: ");
        //string numberText = Console.ReadLine();
        //int number = int.Parse(numberText);

        // random nu,ber generation 

        bool playAgain = true;


        while (playAgain){
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int magicGuess = -1;
        int numberOfGuess=0;

        while (magicGuess != magicNumber)
        {
            Console.WriteLine("What is Your magic number: ");
            string guessNumberText = Console.ReadLine();
            magicGuess= int.Parse(guessNumberText);
            numberOfGuess++;

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
                Console.WriteLine("You have guessed it coreectly!!! cograts !!! it took you " + numberOfGuess +  " times to get it right");
            }


        }
        Console.WriteLine("Do you want to play again? (yes/no)");
        string playAgainResponse = Console.ReadLine().ToLower();

        if (playAgainResponse != "yes")
        {
            playAgain = false;
        }

        
    }
    }
}