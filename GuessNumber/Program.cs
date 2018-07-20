using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            
            string answer;
            int userNumber;

            do
            {
                int randomNumber = randomGenerator.Next(1, 10);
                int amountOfGuesses = 0;

                do {
                    Console.WriteLine("Guess the number between 1 and 10");
                    userNumber = int.Parse(Console.ReadLine());

                    if (userNumber > randomNumber)
                    {
                        Console.WriteLine("Too high!");
                    }
                    else if (userNumber < randomNumber)
                    {
                        Console.WriteLine("Too low!!");
                    }
                    else
                    {
                        Console.WriteLine("Correct!!");
                        Console.WriteLine("My number: {0}", randomNumber);
                    }

                    amountOfGuesses++;

                } while (userNumber != randomNumber);

                Console.Clear();
                Console.WriteLine("You guessed {0} times", amountOfGuesses);
                Console.WriteLine("Would you like to play again? :) Press \"T\" to start over or any other sign to quit");
                answer = Console.ReadLine();
            } while (answer == "T");

            Console.ReadKey();
        }
    }
}
