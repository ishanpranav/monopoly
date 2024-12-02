// Deck.cs
// Copyright (c) 2023-2024 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

namespace Monopoly.Simulator.Decks;

internal abstract class Deck<T>
{
    private readonly T[] _cards;

    protected Deck(int count, Random random)
    {
        Random = random;
        _cards = new T[count];
    }

    public T this[int index]
    {
        get
        {
            return _cards[index];
        }
        set
        {
            _cards[index] = value;
        }
    }

    public int Count
    {
        get
        {
            return _cards.Length;
        }
    }

    public Random Random { get; }

    public void Shuffle()
    {
        for (int i = 0; i < _cards.Length - 1; i++)
        {
            int j = Random.Next(i, _cards.Length);

            T temp = _cards[i];
            _cards[i] = _cards[j];
            _cards[j] = temp;
        }
    }

    public abstract T Draw();
}
