using System;


namespace TestConsoleApp1
{
    internal class RandomHobbyGenerator
    {
        Random randomHobbyGenerator = new Random();

        public void GenerateRandomHobby(string userName)
        {
            var randomHobby = randomHobbyGenerator.Next(0, 4);

            if (randomHobby == 0)
            {
                Console.WriteLine($"{userName}, your new hobby is Shopping and you now use all your money on shopping, way to go!");
            }
            else if (randomHobby == 1)
            {
                Console.WriteLine($"{userName}, your new hobby is now D&D and you will live in your mothers basement and play Dungeons and Dragons for the rest of your life");
            }
            else if(randomHobby == 2)
            {
                Console.WriteLine($"{userName}, your new hobby is now MTG Cards, you have a lot of cool cards and you use all your money on Magic The athering Cards!");
            }
            else if (randomHobby == 4) 
            {
                Console.WriteLine($"{userName}, your new hobby is now hiking, thats the only thing you do now.");
            }
            else
            {
                Console.WriteLine($"{userName}, your new hobby is writing code! Yey!! ");
            }
        }


        private Random randomHobbyGeneratorArray = new Random();
        private string[] hobbies = {
            "Shopping and you now use all your money on shopping, way to go!",
            "D&D and you will live in your mother's basement and play Dungeons and Dragons for the rest of your life",
            "MTG Cards, you have a lot of cool cards and you use all your money on Magic The Gathering Cards!",
            "Hiking, that's the only thing you do now.",
            "Writing code! Yey!!"
        };

        public void GenerateRandomHobbiesWithArray(string userName)
        {
            var randomHobbyIndex = randomHobbyGeneratorArray.Next(0, hobbies.Length);
            var randomHobby = hobbies[randomHobbyIndex];

            Console.WriteLine($"{userName}, your new hobby is now {randomHobby}");
        }
    }
}
