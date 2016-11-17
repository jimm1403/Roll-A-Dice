using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RollADiceGame
{
    public class RollADice
    {
        PlayerRepository playerRepo = new PlayerRepository();
        Random rnd = new Random();

        public int RollTheDice()
        {
            int diceRoll = rnd.Next(1, 7);
            return diceRoll;
        }

        public string winOrLose(int playerOneRoll, int playerTwoRoll)
        {
            List<Player> playerList = playerRepo.GetList();
            string winMessage;
            if (playerOneRoll > playerTwoRoll)
            {
                winMessage = playerList[0].ToString() + " Wins!";
                playerList[0].AddWin();
            }
            else if (playerOneRoll < playerTwoRoll)
            {
                winMessage = playerList[1].ToString() + " Wins!";
                playerList[1].AddWin();
            }
            else
            {
                winMessage = "It's A Draw!";
            }

            return winMessage;
        }
    }
}
