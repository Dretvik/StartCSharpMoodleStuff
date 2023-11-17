using TestConsoleApp1;
using System;

class Program
{
    static void Main(string[] args)
    {
        string userNameInput;
        do {
            Console.WriteLine("Hello, what's your name?!");
            userNameInput = Console.ReadLine();
            Console.WriteLine($"Your name is {userNameInput}?");
            Console.WriteLine($"If the name is wrong press 'N'");
        } while (Console.ReadLine()?.ToLower() == "n");

        Console.WriteLine($"Welcome {userNameInput}");

        // Lager en instance av DataTypes
        DataTypes dataTypesInstance = new DataTypes();
        // Kjører metoden Run fra DataTypes.cs
        dataTypesInstance.Run();

        Console.WriteLine();
        Console.WriteLine();


        AddTwoNumbersClass addNumbers = new AddTwoNumbersClass();
        do
        {
            addNumbers.AddTwoNumbers(userNameInput);
            Console.WriteLine($"Do you want to do it again {userNameInput}? If Yes, press 'Y' ");
        } while (Console.ReadLine()?.ToLower() == "y");

        NumberIfStatement numberIfStatement = new NumberIfStatement();
        do
        {
            Console.WriteLine();
            numberIfStatement.ReturnIfNotSameOrMultiply();
            Console.WriteLine($"Do you want to do it again {userNameInput}? If Yes, press 'Y' ");
        } while (Console.ReadLine()?.ToLower() == "y");

        Console.WriteLine();

        // Her leker jeg med forskjellige random muligheter
        Console.WriteLine("The next number is generated randomly between 0 and 2");
        RandomNumber  generateRandomNumber = new RandomNumber();
        generateRandomNumber.GenerateAndPrintRandomNumber();

        Console.WriteLine();

        // Her har jeg en metode som lager en random ny hobby til deg.
        Console.WriteLine("Now I will give you a random new hobby:");
        RandomHobbyGenerator generateHobby = new RandomHobbyGenerator();
        do
        {
            generateHobby.GenerateRandomHobby(userNameInput);
            Console.WriteLine($"Do you want to do it again {userNameInput}? If Yes, press 'Y' ");
        } while (Console.ReadLine()?.ToLower() == "y");

        Console.WriteLine();

        // Her referer jeg til indexen i et array i stedet, samme utfall som metoden over.
        Console.WriteLine("And now I'll do the same but now I'm using an array of strings instead: ");
        do
        {
            generateHobby.GenerateRandomHobbiesWithArray(userNameInput);
            Console.WriteLine($"Do you want to do it again {userNameInput}? If Yes, press 'Y' ");
        } while (Console.ReadLine()?.ToLower() == "y");

        Console.WriteLine();

        // Her lager jeg et gjette spill, hvor du skal gjette et tall mellom 1 og 100
        Console.WriteLine("Here is a guessing game: ");
        Console.WriteLine();

        GuessTheNumber guessTheNumberGame = new GuessTheNumber();
        do
        {
            guessTheNumberGame.PlayNumberGuessingGame(userNameInput);
            Console.WriteLine("Press 'Y' to play again, or anything else to quit.");
            Console.WriteLine($"So {userNameInput}, do you want to play again?");
        } while (Console.ReadLine()?.ToLower() == "y");
    }
}