//Marcus LaBar (Section 2) - Mission #2 Assignment

using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome statement
            Console.WriteLine("Welcome to the dice throwing simulator! " +
                "How many dice rolls would you like to simulate?");
            float choosenRolls = Convert.ToSingle(Console.ReadLine());

            //Creates 12 spots in an array
            int[] spots = new int[11];

            //Creates random instance
            Random rnd = new Random();

            //Loops through each roll
            for (int i = 0; i < choosenRolls; i++)
            {
                int die1 = rnd.Next(0, 6);
                int die2 = rnd.Next(0, 6);

                int dieTotal = die1 + die2;

                //Adds 1 to the position afterwards
                spots[dieTotal]++;
            }

            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS: Each '*' represents 1% " +
                "of the total number of rolls. Total number of rolls = " + choosenRolls);

            //Loops through array
            for (int k = 0; k < spots.Length; k++)
            {
                float calc = (spots[k] / (choosenRolls)) * 100;
                Math.Round(calc);

                Console.Write((k + 2) + ":");

                //Loop to print asterisks
                for (int j = 0; j < calc; j++)
                {
                    string asterisk = "*";
                    Console.Write(asterisk);
                }

                //Keeps asterisks on same line
                Console.WriteLine();
            }
        }
    }
}