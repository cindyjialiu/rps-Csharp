using System;
using System.Linq;
using System.Collections.Generic;

namespace RPS
{
    public enum gameResult { play1Won, play2Won, draw, notFinished }
    public static class GameFinished
    {
        public static gameResult GameResult(List<wonDrawLost> history)
        {
            if (history.Count == 2 && history[0] == wonDrawLost.won) return gameResult.play1Won;
            return gameResult.draw;
        }
    }
}
