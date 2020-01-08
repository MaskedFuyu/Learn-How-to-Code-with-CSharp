using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess = 0;
            int theNumber = new Random().Next(1, 100);
            for (int chance = 3; chance > 0; chance--)
            {
                System.Console.WriteLine("Input your guess:");
                guess = int.Parse(Console.ReadLine());
                if (guess == theNumber)
                {
                    System.Console.WriteLine("You win!");
                    return;
                }
                if (guess > theNumber)
                {
                    System.Console.WriteLine("It's greater than the number");
                }
                else
                {
                    System.Console.WriteLine("It's less than the number");
                }
            }
            System.Console.WriteLine($"You lose! The number is {theNumber}");            
        }
    }
}
