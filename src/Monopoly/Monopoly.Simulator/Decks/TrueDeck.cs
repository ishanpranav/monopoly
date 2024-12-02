// TrueDeck.cs
// Copyright (c) 2023-2024 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

namespace Monopoly.Simulator.Decks;

internal class TrueDeck<T> : Deck<T>
{
    private int _index;

    public TrueDeck(int count, Random random) : base(count, random) { }

    public override T Draw()
    {
        if (_index == Count)
        {
            _index = 0;

            Shuffle();
        }

        T result = this[_index];

        _index++;

        return result;
    }
}
