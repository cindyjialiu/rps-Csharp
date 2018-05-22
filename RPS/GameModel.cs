//using System;
//using System.Linq;
//using System.Collections.Generic;

//namespace RPS
//{
//    public static class GameModel
//    {
//        public static gameResult Game()
//        {
//            var random = new Random();
//            var player1 = new List<int> { 2, 0, 1 };
//            var player2 = new List<int> { random.Next(3), random.Next(3), random.Next(3) };

//            //Need to extract below into a separate function
//            var player1Moves = player1.Select(index => RPS.Players.RandomComputerPlayer(index));
//            var player2Moves = player2.Select(index => RPS.Players.RandomComputerPlayer(index));
//            RPS.Rules.Beats()
//        }
//    }
//}
