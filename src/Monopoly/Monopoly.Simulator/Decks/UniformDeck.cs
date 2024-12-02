// UniformDeck.cs
// Copyright (c) 2023-2024 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

namespace Monopoly.Simulator.Decks;

internal class UniformDeck<T> : Deck<T>
{
    public UniformDeck(int count, Random random) : base(count, random) { }

    public override T Draw()
    {
        int index = Random.Next(Count);

        return this[index];
    }
}
