using System;

namespace TestConsoleApp1
{
    internal class RandomNumber
    {
        Random rand = new Random();

        public void GenerateAndPrintRandomNumber()
        {
            var randomNumber = rand.Next(0, 3);

            if (randomNumber == 0)
            {
                Console.WriteLine("The  random number is 0");
            }
            else if (randomNumber == 1)
            {
                Console.WriteLine("The random number is 1");
            }
            else
            {
                Console.WriteLine("The random number is 2");
            }
        }
    }
}