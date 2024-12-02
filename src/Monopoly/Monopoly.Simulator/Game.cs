// Game.cs
// Copyright (c) 2023-2024 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

namespace Monopoly.Simulator;

internal sealed class Game
{
    private const int Squares = 40;

    public Random Random { get; }
    public Square Square { get; private set; } = Square.Go;
    public bool InJail { get; private set; }
    public int JailTime { get; private set; }
    public int Doubles { get; private set; }

    public Game(Random random)
    {
        Random = random;
    }

    private void PrintStatus(int a, int b)
    {
        Console.Write($"I rolled {a}, {b} and I'm at {Square}");

        if (Square == Square.Jail && InJail)
        {
            Console.Write(" and I'm in jail");
        }

        Console.WriteLine();
        Console.ReadKey(intercept: true);
    }

    private void GoToJail()
    {
        Square = Square.Jail;
        Doubles = 0;
        InJail = true;
    }

    public void Move()
    {
        int a = Random.Next(1, 7);
        int b = Random.Next(1, 7);

        if (InJail)
        {
            JailTime++;

            if (a == b || JailTime == 3)
            {
                InJail = false;
                JailTime = 0;
            }
            else
            {
                PrintStatus(a, b);

                return;
            }
        }

        if (a == b)
        {
            Doubles++;

            if (Doubles == 3)
            {
                GoToJail();
                PrintStatus(a, b);

                return;
            }
        }
        else
        {
            Doubles = 0;
        }

        Square = (Square)((int)(Square + a + b) % Squares);

        if (Square == Square.GoToJail)
        {
            GoToJail();
            PrintStatus(a, b);

            return;
        }

        PrintStatus(a, b);
    }
}
