using System;

namespace DiceSimulator;

public class DiceRoller
{
    public int[] SimulateRolls(int numberOfRolls)
    {
        // Array size 13 to easily map index 2-12 to the dice totals
        int[] results = new int[13];
        Random random = new Random();

        for (int i = 0; i < numberOfRolls; i++)
        {
            int die1 = random.Next(1, 7); // Rolls 1-6
            int die2 = random.Next(1, 7);
            int total = die1 + die2;

            results[total]++;
        }

        return results;
    }
}