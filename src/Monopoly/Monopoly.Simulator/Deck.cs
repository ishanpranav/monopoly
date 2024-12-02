// Deck.cs
// Copyright (c) 2023-2024 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

namespace Monopoly.Simulator;

internal class Deck<T>
{
    private readonly T[] _cards;
    private int _index;

    public Deck(int count, Random random)
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

    public T Draw()
    {
        if (_index == _cards.Length)
        {
            _index = 0;

            Shuffle();
        }

        T result = _cards[_index];

        _index++;

        return result;
    }
}
