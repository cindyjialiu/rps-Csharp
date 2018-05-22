using System;
using System.Collections.Generic;

namespace RPS
{
    public static class Players
    {
        public static moves LookUpMovesFromIndex(int index)
        {
            var random = new Random();
            var moves = new List<moves>
            {
                RPS.moves.rock,
                RPS.moves.paper,
                RPS.moves.scissors
            };
            //int index = random.Next(moves.Count);
            Console.WriteLine(moves[index]);
            return moves[index];
        }
    }
}
