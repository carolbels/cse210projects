using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percente = int.Parse(answer);

        string letter = "";

        if (percente >=90)
        {
            letter = "A";
        }
        else if (percente  >= 80)
        {
            letter = "B";
        }
        else if (percente  >= 70)
        {
            letter = "C";
        }
        else if (percente  >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        Console.WriteLine ($"Your grade is : {letter}");

        if (percente >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}