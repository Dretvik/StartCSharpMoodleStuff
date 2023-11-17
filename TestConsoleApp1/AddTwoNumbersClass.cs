
namespace TestConsoleApp1
{
    internal class AddTwoNumbersClass
    {
        public void AddTwoNumbers(string userName)
        {
            Console.WriteLine($"Hey {userName}, please write a number.");
            Console.WriteLine("You may use decimals if you please");
            var num1Input = Console.ReadLine();

            Console.WriteLine($"Now {userName}, please write a second number:");
            var num2Input = Console.ReadLine();
            Console.WriteLine("Now I'll add these two numbers together for you: ");

            if (double.TryParse(num1Input, out double num1) && double.TryParse(num2Input, out double num2))
            {
                double sum = num1 + num2;
                Console.WriteLine($"{num1} + {num2} = {sum}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid  values.");
            }
        }
    }
}
