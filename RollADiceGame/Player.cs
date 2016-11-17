using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RollADiceGame
{
    public class Player
    {
        static int nextPlayerNumber = 1;

        int playerNumber;
        string userName;
        int winCount = 0;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public int WinCount
        {
            get { return winCount; }
        }
        public Player(string userName)
        {
            this.userName = userName;
            playerNumber = nextPlayerNumber++;
        }

        public int GetPlayerNumber()
        {
            return playerNumber;
        }
        public void AddWin()
        {
            winCount = winCount + 1;
        }
        public override string ToString()
        {
            return userName;
        }


    }
}
