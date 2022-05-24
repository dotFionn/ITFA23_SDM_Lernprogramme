using System;
using System.Linq;

// ISBN-Rechner von Artur, Chris und Fionn

namespace ISBN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = GetInput(), mode = "NULL";

                string[] split = input.Select(x => x.ToString()).ToArray();

                if (split.Count() == 10) mode = "VALIDATE";
                if (split.Count() == 9) mode = "GENERATE";

                if (mode == "NULL")
                {
                    Console.WriteLine($"\"{input}\" is no valid input. See the rules above for valid input!");
                    continue;
                }

                bool skip = false;
                int temp = 0;

                for(int i = 0; i < 9; i++)
                {
                    string sign = split[i];

                    int parsedInt;

                    if(!int.TryParse(sign, out parsedInt))
                    {
                        skip = true;
                        break;
                    }

                    temp += parsedInt * (i + 1);
                }

                if (skip) continue;

                Console.WriteLine(temp);

                temp %= 11;

                string sum = temp == 10 ? "X" : temp.ToString();

                Console.WriteLine($"Calculated Checksum is {sum}.");
                if (mode == "VALIDATE")
                {
                    string inCheck = split[9];
                    Console.Write($"{inCheck} was given. ");
                    Console.WriteLine(inCheck == sum ? "They are the same." : "They are not the same.");
                }
                Console.WriteLine("\n\n\n");
            }
        }

        internal static string GetInput()
        {
            while (true)
            {
                Console.Write("Pls input complete ISBN (can be only ISBN-10, with ot without checksum, do not include dashes!):\n-> ");
                string input = Console.ReadLine();

                if (input == null || input == "") continue;

                if (input == "q")
                {
                    Console.WriteLine("Bye bye!");
                    Environment.Exit(0);
                }

                return input;
            }
        }
    }
}
