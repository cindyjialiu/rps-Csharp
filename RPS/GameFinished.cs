using System;
using System.Linq;
using System.Collections.Generic;

namespace RPS
{
    public enum gameResult { player1Won, player2Won, draw, notFinished }
    public static class GameFinished
    {
        public static gameResult GameResult(List<wonDrawLost> history)
        {
            var groupedRes = history.GroupBy(roundRes => roundRes).ToList();
            var aaa = groupedRes.Find(eachGroup => (eachGroup.Count() == 2));
            if (aaa != null)
            {
                switch (aaa.Key)
                {
                    case wonDrawLost.won:
                        return gameResult.player1Won;
                    case wonDrawLost.lost:
                        return gameResult.player2Won;
                    //if the result is won, draw, draw or lost, draw, draw, the result will be as below
                    case wonDrawLost.draw:
                        return gameResult.draw;
                    default://compiler limitation
                        return gameResult.draw;
                }
            }
            // else if aaa is null, there should be either draw or notFinished
            else 
            {
                if (history.Count == 3)
                {
                    return gameResult.draw;
                }
                else 
                {
                    return gameResult.notFinished;
                }
            }

            //if (history.Count == 2 && history[0] == wonDrawLost.won) return gameResult.player1Won;
            //if (history.Count == 2 && history[0] == wonDrawLost.lost) return gameResult.player2Won;
            //if (history.Count == 2 && history[0] == wonDrawLost.draw) return gameResult.draw;
            //if (history.Count == 3 && history[2] == wonDrawLost.won) return gameResult.player1Won;
            //if (history.Count == 3 && history[2] == wonDrawLost.lost) return gameResult.player2Won;
            //if (history.Count == 3 && history[2] == wonDrawLost.draw) return gameResult.draw;
            //return gameResult.notFinished;
        }
    }
}
