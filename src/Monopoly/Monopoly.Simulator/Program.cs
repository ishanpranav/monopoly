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

        Game game = new Game(random);
        int[] frequencies = new int[(int)(Square.Boardwalk + 1)];

        for (int turn = 0; turn < turns; turn++)
        {
            game.Move();
            frequencies[(int)game.Square]++;
        }

        Square[] squares = new Square[(int)(Square.Boardwalk + 1)];

        for (Square square = Square.Go; square <= Square.Boardwalk; square++)
        {
            squares[(int)square] = square;
        }

        Array.Sort(squares, (a, b) => frequencies[(int)b] - frequencies[(int)a]);

        foreach (Square square in squares)
        {
            double probability = (double)frequencies[(int)square] / turns;

            Console.WriteLine("{0,-20}{1:p2}", square, probability);
        }
    }
}
