using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90 && percent <=100)
        {
            letter = "A";
        }
        else if (percent >= 80 && percent <=89)
        {
            letter = "B";
        }
        else if (percent >= 70 && percent <=79)
        {
            letter = "C";
        }
        else if (percent >= 60 && percent <=69)
        {
            letter = "D";
        }
        else if (percent >= 0 && percent <=59)
        {
        letter = "F";
        }
        else
        {
            letter = "unknown";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= 70 && percent <= 100)
        {
            Console.WriteLine("You passed!");
        }
         else if (percent < 0 || percent > 100)
        {
            Console.WriteLine("Enter a valid percent value from 1 to 100");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}