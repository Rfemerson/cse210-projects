using System;

class Program
{
    static void Main(string[] args)
    {
        // Random randomGenerator = new Random();
        //     int number = randomGenerator.Next(1, 11);

        int guess = 0;
        int attempt = 0;
        string back = "yes";
        // Console.WriteLine(number);

        while (back == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 11);
             Console.WriteLine(number);

            Console.Write("What your guess? ");
            guess = int.Parse(Console.ReadLine());
            attempt += 1;

            if (guess < number)
            {
                Console.WriteLine("Higher");
            }

            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You guesses it!");
                Console.WriteLine($"You had {attempt} guesses ");
            }
               
            // Console.WriteLine($"You had {attempt} guesses ");
            Console.Write("Do you want to continue? (yes/no):  ");
            back = Console.ReadLine();
        }
    }
}