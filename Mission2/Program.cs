//Marcus LaBar (Section 2) - Mission 2

using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator! " +
                "How many dice rolls would you like to simulate?");
            int choosenRolls = Convert.ToInt32(Console.ReadLine());

            //Creates 12 spots in an array
            int[] spots = new int[11];

            //Initializes random class
            Random rnd = new Random();

            //Loops through each roll
            for (int i = 0; i < choosenRolls; i++)
            {
                int die1 = rnd.Next(0, 6);
                int die2 = rnd.Next(0, 6);

                int dieTotal = die1 + die2;

                //Adds 1 to the position
                spots[dieTotal]++;
            }

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS: Each '*' represents 1% " +
                "of the total number of rolls. Total number of rolls = " + choosenRolls);

            //Loops through each position in array
            for (int i = 0; i < spots.Length; i++)
            {
                //Calculate %, new variable, round it
                double calc = (spots[i] / choosenRolls) * 100;
                Math.Round(calc);

                string asterisk = "*";

                //For loop to print asterisk
                for (int j = 0; j < calc; j++)
                {
                    asterisk = asterisk + asterisk;
                }

                Console.WriteLine((i + 2) + ":" + asterisk);
            }
        }
    }
}

//Tools:
//Console.WriteLine(string.Join(", ", spots));
//Console.WriteLine((1) + ": " + spots[5]);