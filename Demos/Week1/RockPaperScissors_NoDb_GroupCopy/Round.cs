using System;

namespace RockPaperScissors_NoDb_GroupCopy
{
    class Round
    {
        private Guid roundId = Guid.NewGuid();
        public Guid RoundId { get { return roundId; } }
        public Choice BotChoice { get; set; } // always the computer
        public Choice UserChoice { get; set; } // always the user
        public Player WinningPlayer { get; set; } = null;

    }
}