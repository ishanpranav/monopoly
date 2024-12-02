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

The table below gives the terminal probabilities for each square on the standard
monopoly board after 1 billion iterations. These results are consistent with
[the findings of Truman Collins](http://www.tkcs-collins.com/truman/monopoly/monopoly.shtml).

|Square                            | Probability |
|----------------------------------|------------:|
| Jail                             | 11.61%        |
| Illinois Avenue                  | 3.00%         |
| Go                               | 2.90%         |
| B. & O. Railroad                 | 2.89%         |
| Free Parking                     | 2.83%         |
| Tennessee Avenue                 | 2.82%         |
| New York Avenue                  | 2.81%         |
| Reading Railroad                 | 2.80%         |
| St. James Place                  | 2.68%         |
| Water Works                      | 2.66%         |
| Pennsylvania Railroad            | 2.64%         |
| Kentucky Avenue                  | 2.62%         |
| Electric Company                 | 2.61%         |
| Indiana Avenue                   | 2.56%         |
| St. Charles Place                | 2.56%         |
| Atlantic Avenue                  | 2.53%         |
| Ventnor Avenue                   | 2.52%         |
| Pacific Avenue                   | 2.52%         |
| Boardwalk                        | 2.48%         |
| North Carolina Avenue            | 2.47%         |
| Marvin Gardens                   | 2.44%         |
| Virginia Avenue                  | 2.43%         |
| Pennsylvania Avenue              | 2.35%         |
| Community Chest (2)              | 2.30%         |
| Short Line                       | 2.30%         |
| Community Chest (3)              | 2.23%         |
| Income Tax                       | 2.19%         |
| Vermont Avenue                   | 2.18%         |
| States Avenue                    | 2.17%         |
| Connecticut Avenue               | 2.16%         |
| Oriental Avenue                  | 2.13%         |
| Park Place                       | 2.05%         |
| Luxury Tax                       | 2.05%         |
| Baltic Avenue                    | 2.03%         |
| Mediterranean Avenue             | 2.01%         |
| Community Chest (1)              | 1.78%         |
| Chance (2)                       | 1.05%         |
| Chance (1)                       | 0.82%         |
| Chance (3)                       | 0.81%         |
| Go to Jail                       | 0.00%         |
| __Total__                            | __100.00%__   |
