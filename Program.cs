// See https://aka.ms/new-console-template for more information
using System;

namespace DiceSimulator;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.Write("How many dice rolls would you like to simulate? ");
        
        // Read user input and convert to integer
        if (!int.TryParse(Console.ReadLine(), out int numRolls))
        {
            Console.WriteLine("Invalid input. Goodbye.");
            return;
        }

        // Initialize the second class and get results
        DiceRoller dr = new DiceRoller();
        int[] rollTotals = dr.SimulateRolls(numRolls);

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {numRolls}.\n");

        // Loop from 2 to 12 to print the histogram
        for (int i = 2; i <= 12; i++)
        {
            // Calculate percentage: (count / total) * 100
            double percentage = ((double)rollTotals[i] / numRolls) * 100;
            
            // Round to nearest whole number for asterisks
            int asteriskCount = (int)Math.Round(percentage);

            Console.Write($"{i}: ");
            Console.WriteLine(new string('*', asteriskCount));
        }

        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}