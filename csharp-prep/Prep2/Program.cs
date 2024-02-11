using System;

class Program
{
    static void Main(string[] args)
    {
        string gradeLetter = "";
        string sign ="";

        

        Console.WriteLine("What is your grade percentage: ");
        string gradePercentageText= Console.ReadLine();
        int gradePercentage = int.Parse(gradePercentageText);

        if (gradePercentage >= 90)
        {

            gradeLetter = "A";
        }
        else if (gradePercentage  >= 80)
        {
            gradeLetter= "B";
        
        }

        else if ( gradePercentage >= 70)
        {
            gradeLetter= "C";
        }
        else if ( gradePercentage >= 60)
        {
            gradeLetter= "D";
        }

        else
        {
            gradeLetter= "F";
        }

        int lastDigit = gradePercentage % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        } 

        else if (lastDigit <3)
        {
            sign = "-";
        }
        else 
        {
            sign = "";
        }

        if (gradeLetter =="A" && lastDigit<7)
        {
            sign ="-";
        }

        else if (gradeLetter == "F" && lastDigit < 7 || lastDigit < 3)
        {
            sign = "";
        }
        Console.WriteLine("Your grade is " + gradeLetter +sign);
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations you passed your exams!!!");
        }
        else 
        {
            Console.WriteLine("Unfortunately you failed !! try again next time!!!");
        }


    }
}