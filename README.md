# Rock, Paper, Scissors

## Technology Used
- Language: C#
- Testing Framework: MSTest

## My Approach
- Followed TDD, MVP

- I started with domain models, see below
![d1](https://user-images.githubusercontent.com/33848023/40395131-90465702-5e1e-11e8-9764-c10e09b0804d.jpg)
![d2](https://user-images.githubusercontent.com/33848023/40394995-de6bb75c-5e1d-11e8-936f-62375911fff2.jpg)
- MVP - Take one random computer player and one tactical computer, play 3 rounds of the game and show the game result.

- Rules class, it has method Beats, takes two parameters, one move from each player and the output is the result of each round.

- Players class, it has method LookUpMovesFromIndex and takes index as the parameter and returns the move of that index.

- GameFinished class, it has function GameResult and takes the result history and returns the game result, used switch/cases.

- GameModel class, it has function Game and no parameter passed in, this function is the top function to link the other classes together. The method Game creates two players, random computer player and tactical computer player, each player has a list of index and the Select method turns index list into a list of moves, then the Zip method works out the out come of each round, the last is the GameResult works out the final result.

## What went well
- Logics, I've managed to work out most of the game logics and break down the big task into small problems.
- Managed to implement the MVP in C#.

## What was difficult
- Setting up the development environment, work out which testing framework to use and how to connect the tests to source code.

- C#, as a completed new language, I spent 80% of my time on learning C#, understand syntax, work out the types and how to write the methods. Also I've found the documentation and the online resource is not very clear, every time I googled some simple question, the solution came up seems daunting. Compare with the learning experience of Ruby and JavaScript, C# is definitely takes a lot more time to understand and implement the code. It was very difficult to understand the examples without understanding the syntax.

## What I have done
- MVP - Take one random computer player and one tactical computer, play 3 rounds of the game and show the game result.

## What I haven't completed
- Human player option has been completed
- Choose the type of the players

## Setup
```bash
git clone git@github.com:cindyjialiu/rps-Csharp.git
```
