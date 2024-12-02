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

|Square                            | Probability |
|----------------------------------|------------:|
| Jail                             |11.60%       |
| Illinois Avenue                   |2.99%        |
| Go                               |2.91%        |
| B. & O. Railroad                    |2.89%        |
| Free Parking                      |2.82%        |
| Tennessee Avenue                  |2.82%        |
| New York Avenue                    |2.81%        |
| Reading Railroad                  |2.80%        |
| St James Place                     |2.68%        |
| Water Works                       |2.65%        |
| Pennsylvania Railroad             |2.64%        |
| Electric Company                  |2.62%        |
| Kentucky Avenue                   |2.61%        |
| Indiana Avenue                    |2.57%        |
| St. Charles Place                   |2.56%        |
| Atlantic Avenue                   |2.54%        |
| Pacific Avenue                    |2.52%        |
| Ventnor Avenue                    |2.52%        |
| Boardwalk                        |2.48%        |
| North Carolina Avenue              |2.47%        |
| Marvin Gardens                    |2.44%        |
| Virginia Avenue                   |2.43%        |
| Pennsylvania Avenue               |2.36%        |
| Community Chest (2)                  |2.30%        |
| Short Line                        |2.29%        |
| Community Chest (3)                  |2.23%        |
| Income Tax                        |2.20%        |
| Vermont Avenue                    |2.18%        |
| States Avenue                     |2.18%        |
| Connecticut Avenue                |2.17%        |
| Oriental Avenue                   |2.13%        |
| Park Place                        |2.06%        |
| Luxury Tax                        |2.05%        |
| Baltic Avenue                     |2.03%        |
| Mediterranean Avenue              |2.01%        |
| Community Chest (1)                  |1.77%        |
| Chance (2)                          |1.05%        |
| Chance (3)                          |0.81%        |
| Chance (1)                          |0.81%        |
| Go To Jail                         |0.00%        |
| __Total__                            | __100.00%__   |
