using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 1026);

        int score = 11;
        int highscore = 0;

        Console.WriteLine("Start guessing...");

        while (true)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int guess))
            {
                Console.WriteLine("No number!");
                continue;
            }

            if (guess == secretNumber)
            {
                Console.WriteLine("Correct Number!");
                Console.WriteLine($"The secret number was: {secretNumber}");

                if (score > highscore)
                {
                    highscore = score;
                    Console.WriteLine($"New Highscore: {highscore}");
                }

                break;
            }
            else
            {
                if (score > 1)
                {
                    Console.WriteLine(guess > secretNumber ? "Too high!" : "Too low!");
                    score--;
                    Console.WriteLine($"Remaining attempts: {score}");
                }
                else
                {
                    Console.WriteLine("You lost the game!");
                    Console.WriteLine($"The secret number was: {secretNumber}");
                    Console.WriteLine($"Your highscore: {highscore}");
                    break;
                }
            }
        }
    }
}
