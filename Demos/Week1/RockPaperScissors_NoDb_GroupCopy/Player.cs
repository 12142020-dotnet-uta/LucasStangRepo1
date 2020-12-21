using System;

namespace RockPaperScissors_NoDb_GroupCopy
{
    class Player  //creates validation for playerID
    {
        
        public Player()
        {

        }
        public Player(string fname = null, string lname = null)
        {
            this.FName = fname;
            this.LName = lname;
        }
        private Guid playerId = Guid.NewGuid();
        public Guid PlayerId { get { return playerId; } }
        private string fName;
        public string FName
        {
            get { return fName; }
            set 
            {
                if(value is string && value.Length < 20)
                {
                 fName = value;
                } 
                else
                {
                    throw new Exception("That first name is not valid.");
                }
            }
        }

        private string lName;
        public string LName
        {
            get { return lName; }
            set 
            {
                if(value is string && value.Length < 20)
                {
                 lName = value;
                } 
                else
                {
                    throw new Exception("That last name is not valid.");
                }
            }
        }
        
        private int numWins;
        private int numLosses;



        public void AddWin()
        {
            numWins++;
        }
        public void AddLoss()
        {
            numLosses++;
        }

        public int[] GetWinLossRecord()
        {
            int[] winsAndLosses = new int[2];  // creates an array to hold the number of wins and losses

            winsAndLosses[0] =numWins;  // inputs the wins
            winsAndLosses[1] = numLosses;  // inputs the losses

            return winsAndLosses;  // returns the array
        }
    }
}