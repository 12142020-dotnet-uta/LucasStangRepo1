using System;
using System.Collections.Generic;

namespace RockPaperScissors_NoDb_GroupCopy
{
    class Match
    {
        private Guid matchId = Guid.NewGuid();
        public Guid MatchId { get {return matchId; } }
        public Player Bot { get; set; }  // always the user
        public Player User { get; set; }  // always the computer
        public List<Round> Rounds = new List<Round>();

        public int BotRoundWins { get; set; }  // tracks the round wins of the user
        public int UserRoundWins { get; set; }  // tracks the round wins of the computer
        public int Ties { get; set; }

        // below are methods
        public void RoundWinner(Player p = null)
        {
            if(p.PlayerId == Bot.PlayerId)
            {
                BotRoundWins++;
            }
            else if(p == User)
            {
                UserRoundWins++;
            }
            else
            {
                Ties++;
            }
        }

        public Player MatchWinner()
        {
            if(BotRoundWins == 2)
            {
                return Bot;
            }
            else if(UserRoundWins == 2)
            {
                return User;
            }
            else
            {
                return null;
            }
        }

    }
}