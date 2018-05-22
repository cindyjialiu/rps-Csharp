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
            if (history.Count == 2 && history[0] == wonDrawLost.won) return gameResult.player1Won;
            if (history.Count == 2 && history[0] == wonDrawLost.lost) return gameResult.player2Won;
            if (history.Count == 2 && history[0] == wonDrawLost.draw) return gameResult.draw;
            if (history.Count == 3 && history[2] == wonDrawLost.won) return gameResult.player1Won;
            return gameResult.notFinished;
        }
    }
}
