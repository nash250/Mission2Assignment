using System;

namespace Mission2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enter Dice Roll Amount & Display
            Console.WriteLine("Welcome to the Dice Throwing Simulator.\n");
            Console.WriteLine("How many dice rolls would you like to simulate ? Ex: 1000\n");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + input + "\n");

            // Instantiate Random
            Random r = new Random();

            int[] rollTotals = new int[13];

            //Simulate the roll of the die
            for (int i = 0; i < input; i++)
            {
                int die1 = r.Next(1, 7);
                int die2 = r.Next(1, 7);
                int total = die1 + die2;
                rollTotals[total]++;
            }

            //Print out the results from the array
            for (int i = 2; i <= 12; i++)
            {
                double percentage = (double)rollTotals[i] / input * 100;
                Console.Write(i + ": ");
                for (int ii = 0; ii < percentage; ii++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}