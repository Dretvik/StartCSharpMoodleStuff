namespace TestConsoleApp1
{
    internal class GuessTheNumber
    {
        public void PlayNumberGuessingGame(string userName)
        {
            Random random = new Random();
            int targetNumber = random.Next(1, 101);
            int userGuess;
            int attempts = 0;

            Console.WriteLine("Guess the a number between 1 and 100:");

            do
            {
                string input = Console.ReadLine();

                if (!int.TryParse(input, out userGuess))
                {
                    Console.WriteLine("Please enter a valid number, the number must be between 1 and 100");
                    continue;
                }
                attempts++;

                if (userGuess < targetNumber)
                {
                    Console.WriteLine("Too low! Try again:");
                }
                else if (userGuess > targetNumber)
                {
                    Console.WriteLine("Too high! Try again:");
                }
                else
                {
                    Console.WriteLine($"Congratulations {userName}! You guessed the number correctly in {attempts} attempts.");
                }
            } while (userGuess != targetNumber);
        }
    }
}
