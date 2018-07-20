using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex 3 program generates a random number between 1 and 10, asks the user to guess the random nuber and than display the random number and a message indictaing whether the user's guess was to low, too high or correct


            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 10);
            string answer;
            int userNumber;
            int amountOfGuesses = 0;

            do
            {
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

                Console.WriteLine("You guessed {0} times", amountOfGuesses);
                Console.WriteLine("Would you like to play again? :) Press \"T\" to start over or any other sign to quit");
                answer = Console.ReadLine();
            } while (answer =="T");
            Console.ReadKey();
        }
    }
}
