using System;
using System.Collections.Generic;
using System.Linq;

namespace GLS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This Utility calculates GLS Parcel numbers.");
            while (true)
            {
                Console.WriteLine("Please press:\n- (n) to enter a new Number to generate\n- (c) to clear the console\n- (q) to quit the application");

                // read key from console
                ConsoleKeyInfo cki = Console.ReadKey();

                string action = "NULL";
                switch (cki.Key)
                {
                    case ConsoleKey.N:
                        {
                            // N was pressed, set action to new
                            action = "NEW";
                            break;
                        }
                    case ConsoleKey.Q:
                        {
                            // return from Main Method, effectively exiting from application
                            return;
                        }
                    case ConsoleKey.C:
                        {
                            // return from Main Method, effectively exiting from application
                            action = "CLEAR";
                            break;
                        }
                    default:
                        {
                            // something wrong was pressed
                            action = "NULL";
                            break;
                        }
                }

                if (action == "NULL")
                {
                    // continue in loop, effectively giving user prompt again
                    Console.WriteLine("The key pressed is not accepted, try again.");
                    continue;
                }

                if (action == "CLEAR")
                {
                    // optionally clear console
                    Console.Clear();
                }

                // create List to hold numbers that were put in
                List<int> parsedNumbers = new();

                while (true)
                {
                    Console.WriteLine("\rPlease type the GLS parcel number without the checksum (or press q and enter to quit):");

                    // get input from user
                    string input = Console.ReadLine();

                    if (input == "q")
                    {
                        // user pressed q, exit
                        return;
                    }

                    if (input == null || input == "")
                    {
                        // nothing was put in, rerun loop and let user retry
                        continue;
                    }

                    // clear number list to make sure the numbers don't overlap from previous attempt
                    parsedNumbers.Clear();

                    // split all characters into individual strings
                    string[] splitCharacters = input.Select(x => x.ToString()).ToArray();

                    // do more validation
                    foreach (string character in splitCharacters)
                    {
                        int parsedNum;

                        if (int.TryParse(character, out parsedNum))
                        {
                            // number is valid, add to parsednumbers list
                            parsedNumbers.Add(parsedNum);
                        }
                    }

                    // ensure we got 11 digits, because that is the length of the GLS number without checksum
                    if (parsedNumbers.Count != 11 || parsedNumbers.Count != splitCharacters.Length)
                    {
                        // number of digits is not correct, let the user retry
                        continue;
                    }

                    // add variable to hold sum of result of multiplication
                    // initial value is 1 because then we can skip adding 1 later on
                    int tempSum = 1;

                    // we now know we have exactly 11 digits
                    for (int i = 0; i < parsedNumbers.Count; i++)
                    {
                        int thisNumber = parsedNumbers[i];

                        if (i % 2 == 0)
                        {
                            // if index is even, multiply with 3
                            thisNumber *= 3;
                        }

                        // add maybe multiplied number to temporary sum variable
                        tempSum += thisNumber;
                    }

                    // modulo 10 the sum
                    int tempSumMod10 = tempSum % 10;

                    // subtract mod 10 from 10, mod 10 again to remove 10 if the initial mod 10 result is 0
                    int checksum = (10 - tempSumMod10) % 10;

                    // write results to console
                    Console.WriteLine("The calculated checksum is:         -----------" + checksum);
                    Console.WriteLine("The entire parcel number should be: " + input + checksum);

                    // print newlines to console for some space
                    Console.WriteLine("\n\n");

                    // calculation is done, break out of loop, go back to initial new/clear/quit prompt
                    break;
                }
            }
        }
    }
}
