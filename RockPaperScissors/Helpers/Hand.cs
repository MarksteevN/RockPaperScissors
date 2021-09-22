using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissor.Helpers
{
    public class Hand
    {
        public OptionRPS Selection { get; set; }
        public OptionRPS WinsAgainst { get; set; }
        public OptionRPS LossAgainst { get; set; }
        public string Image { get; set; }

        public GameStatus PlayAgainst(Hand opponentHand)
        {
            if (Selection == opponentHand.Selection)
            {
                return GameStatus.Draw;
            }
            if (LossAgainst == opponentHand.Selection)
            {
                return GameStatus.Loss;
            }
            return GameStatus.Victory;
        }
    }
}
