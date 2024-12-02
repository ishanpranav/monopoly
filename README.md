<!-- README.md -->
<!-- Copyright (c) 2024 Ishan Pranav -->
<!-- Licensed under the MIT license. -->

# Monopoly

Recently, a friend acquired a _Monopoly: The Mega Edition_ set. To prepare for
the inevitable gameplay session, I am investigating the optimal strategy for
both the traditional Monopoly game and this variant, with an emphasis on the
differences between the two games.

## Probabilities

First, we seek the probabilities of landing on each square during the game. We
define a _turn_ to be the time spent by a player during their move, which may
include multiple successive dice _rolls_.

To determine the probability distribution, we simulate many, many turns, and
note the frequency of each square at the end of each roll.
