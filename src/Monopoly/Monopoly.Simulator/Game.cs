// Game.cs
// Copyright (c) 2023-2024 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

namespace Monopoly.Simulator;

internal sealed class Game
{
    private const int Squares = (int)Square.Boardwalk + 1;

    private readonly Deck<Chance> _chance;
    private readonly Deck<CommunityChest> _communityChest;

    public Game(Random random)
    {
        Random = random;

        const int cards = 16;

        _chance = new Deck<Chance>(cards, random);
        _communityChest = new Deck<CommunityChest>(cards, random);

        for (int card = 0; card < cards; card++)
        {
            _chance[card] = (Chance)card;
        }

        for (int card = 0; card < cards; card++)
        {
            _communityChest[card] = (CommunityChest)card;
        }

        _chance.Shuffle();
        _communityChest.Shuffle();
    }

    public Random Random { get; }
    public Square Square { get; private set; } = Square.Go;
    public bool InJail { get; private set; }
    public int JailTime { get; private set; }
    public int Doubles { get; private set; }

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

    private static Square NearestRailroad(Square square)
    {
        if (square <= Square.ReadingRailroad || square > Square.ShortLine)
        {
            return Square.ReadingRailroad;
        }

        if (square <= Square.PennsylvaniaRailroad)
        {
            return Square.PennsylvaniaRailroad;
        }

        if (square <= Square.BAndORailroad)
        {
            return Square.BAndORailroad;
        }

        return Square.ShortLine;
    }

    private static Square NearestUtility(Square square)
    {
        if (square <= Square.ElectricCompany || square > Square.WaterWorks)
        {
            return Square.ElectricCompany;
        }

        return Square.WaterWorks;
    }

    private void Land()
    {
        switch (Square)
        {
            case Square.Chance1:
            case Square.Chance2:
            case Square.Chance3:
                {
                    Chance card = _chance.Draw();

                    switch (card)
                    {
                        case Chance.AdvanceToBoardwalk:
                            Square = Square.Boardwalk;
                            break;

                        case Chance.AdvanceToGo:
                            Square = Square.Go;
                            break;

                        case Chance.AdvanceToIllinoisAvenue:
                            Square = Square.IllinoisAvenue;
                            break;

                        case Chance.AdvanceToStCharlesPlace:
                            Square = Square.StCharlesPlace;
                            break;

                        case Chance.AdvanceToReadingRailroad:
                            Square = Square.ReadingRailroad;
                            break;

                        case Chance.AdvanceToNearestRailroad1:
                        case Chance.AdvanceToNearestRailroad2:
                            Square = NearestRailroad(Square);
                            break;

                        case Chance.AdvanceToNearestUtility:
                            Square = NearestUtility(Square);
                            break;

                        case Chance.GoToJail:
                            GoToJail();
                            break;

                        case Chance.GoBackThreeSpaces:
                            Square = (Square)((int)(Square + Squares - 3) % Squares);

                            Land();
                            break;
                    }
                }
                break;

            case Square.CommunityChest1:
            case Square.CommunityChest2:
            case Square.CommunityChest3:
                {
                    CommunityChest card = _communityChest.Draw();

                    switch (card)
                    {
                        case CommunityChest.AdvanceToGo:
                            Square = Square.Go;
                            break;

                        case CommunityChest.GoToJail:
                            GoToJail();
                            return;
                    }
                }
                break;

            case Square.GoToJail:
                GoToJail();
                break;
        }
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
                return;
            }
        }

        if (a == b)
        {
            Doubles++;

            if (Doubles == 3)
            {
                GoToJail();

                return;
            }
        }
        else
        {
            Doubles = 0;
        }

        Square = (Square)((int)(Square + a + b) % Squares);

        Land();
    }
}
