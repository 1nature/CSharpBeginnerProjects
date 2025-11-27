namespace Number_Guessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int NUMBER_0F_GUESSES = 5;
            const int MIN = 0;
            const int MAX = 101;
            Random rnd = new Random();
            int randomGuess = rnd.Next(MIN, MAX+1);
            int guesses = 0;

            Console.WriteLine("Random number guessing game");


            for (int i = 1; i <= NUMBER_0F_GUESSES; i++)
            {

                Console.WriteLine($"Please guess a number between {MIN} and {MAX}");
                int userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == randomGuess)
                {
                    Console.WriteLine(userInput);
                    Console.WriteLine("You guessed the right number, 'Congratulations' ");

                    break;
                }

                else if (userInput < randomGuess)
                {
                    Console.WriteLine("You guessed a low number, please try again");
                }

                else if (userInput > randomGuess)
                {
                    Console.WriteLine("You guessed a high number, please try again");
                }
                guesses++;
                Console.WriteLine("Number of guesses: {0}", guesses);
            }

            if (guesses == NUMBER_0F_GUESSES) 
            {
                Console.WriteLine("You exceeded the number of attempts; 'You lose' ");
            }
        }
    }
}