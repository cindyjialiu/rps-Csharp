﻿using System;
using System.Collections.Generic;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public enum wonDrawLost { won, draw, lost }
    public enum moves { rock, paper, scissors }

    public static class Rules
    {
        public static wonDrawLost Beats(moves move1, moves move2)
        {
            var KeyBeatsValue = new Dictionary<moves, moves>
            {
                {moves.rock, moves.scissors},
                {moves.scissors, moves.paper},
                {moves.paper, moves.rock}
            };

            return wonDrawLost.draw;

        }
    }
}
