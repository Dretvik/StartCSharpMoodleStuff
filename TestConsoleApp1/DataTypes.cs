namespace TestConsoleApp1
{
    internal class DataTypes
    {
        int heltTall = 7; // Hele tall
        float desimalTall = 1.01F; // Nøyaktig
        double desimalTall2 = 1.02; // Standard
        decimal desimalTall3 = 1.3M; //Veldig Nøyaktig

        char enkeltBokatav = 'a';
        string text = "Heyhey";

        bool santUsant = true; // eller false

        // Deklarere arrays:
        int[] tallArray = { 1, 2, 3, 4, 5};
        string[] textArray = { "Hey", ",", "how", "you", "doin?" };

        List<int> listeMedTall = new List<int>(); // lager en ny liste med tall

        public string ReturnString()
        {
            return text;
        }

        public int[] ReturnIntArray()
        {
            return tallArray;
        }

        public int ReturnWholeNumbers()
        {
            return heltTall;
        }

        public float returnFloat()
        {
            return desimalTall;
        }

        public double ReturnDouble()
        {
            return desimalTall2;
        }

        public decimal ReturnDecimal()
        {
            return desimalTall3;
        }

        public bool ReturnBoolean()
        {
            return santUsant;
        }

        public void Run()
        {
            Console.WriteLine($"Tis is a string: {ReturnString()}");
            Console.WriteLine($"Tis is an int: {ReturnWholeNumbers()}");
            Console.WriteLine($"Tis is a double: {ReturnDouble()}");
            Console.WriteLine($"Tis is a boolean: {ReturnBoolean()}");

            // Her går jeg igjennom array av int's og printer ut hvert enkelt
            // tall med en foreach loop.
            int[] returnedIntArray = ReturnIntArray();
            Console.Write("This is a int array: ");
            foreach (int num in returnedIntArray)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
