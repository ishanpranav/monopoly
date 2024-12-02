// Program.cs
// Copyright (c) 2024 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

namespace Monopoly.Simulator;

internal static class Program
{
    private static void PrintUsage()
    {
        Console.WriteLine("Usage: Monopoly.Simulator <turns> <seed>");
    }

    private static void Main(string[] args)
    {
        if (args.Length <= 0 || !int.TryParse(args[0], out int turns))
        {
            PrintUsage();

            return;
        }

        Random random;

        if (args.Length > 1)
        {
            if (!int.TryParse(args[1], out int seed))
            {
                PrintUsage();

                return;
            }

            random = new Random(seed);
        }
        else
        {
            random = Random.Shared;
        }

        for (; turns > 0; turns--)
        {
            int a = random.Next(1, 7);
            int b = random.Next(1, 7);

            Console.WriteLine($"{a} {b}");
        }
    }
}
