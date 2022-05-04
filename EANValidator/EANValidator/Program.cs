// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



while (true)
{
    string mode = "NULL"; int givenCheckNo = 0;

    Console.Write("Pls input complete EAN:\n-> ");
    string input = Console.ReadLine();

    if (input == "q")
    {
        Console.WriteLine("Bye bye!");
        return;
    }

    if (input == null || input == "") continue;

    string[] split = input.Select(x => x.ToString()).ToArray();

    if (split.Count() == 13) mode = "VALIDATE";
    if (split.Count() == 12) mode = "GENERATE";

    if (mode == "NULL") continue;

    bool skip = false;
    int sum = 0;

    for (int i = 0; i < split.Count(); i++)
    {
        string sign = split[i];
        int val;

        if (!int.TryParse(sign, out val))
        {
            break;
        }

        Console.WriteLine($"no: {val} | sum: {sum}");

        if (i == 12) givenCheckNo = val;

        if (i % 2 == 1)
        {
            val *= 3;
        }

        if (i < 12) sum += val;
    }
    if (skip) continue;

    int temp = Convert.ToInt32(Math.Ceiling(sum / 10f));

    int nextFullTen = temp * 10;

    int checksum = nextFullTen - sum;

    string msg = $"Generated Checksum: {checksum}";

    if (mode== "VALIDATE")
    {
        msg += $"\nGiven Checksum: {givenCheckNo}";
        msg += $"\nThey do{(givenCheckNo == checksum ? "" : "n't")} match";
    }

    Console.WriteLine(msg);
}

