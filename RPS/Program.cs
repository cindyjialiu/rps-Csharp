using System;
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
    public static class Rules
    {
        public static wonDrawLost Beats(string move1, string move2)
        {
            var KeyBeatsValue = new Dictionary<string, string>
            {
                {"rock", "scissors"},
                {"scissors", "paper"},
                {"paper", "rock"}
            };

            return wonDrawLost.draw;
        }
    }
}
