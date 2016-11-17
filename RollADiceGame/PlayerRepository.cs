using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RollADiceGame
{
    public class PlayerRepository
    {
        static List<Player> playerList = new List<Player>();

        public void AddPlayerToList(Player player)
        {
            playerList.Add(player);
        }
        public List<Player> GetList()
        {
            return playerList;
        }
        public string CompareUserNames(string playerTwoUserName)
        {
            string warning = "";
            
            if (playerList[0].UserName == playerTwoUserName)
            {
                warning = "Name already taken. Click enter and go back to menu and try again.";
                playerList.Remove(playerList[1]);
            }
            else
            {
                warning = "Username accepted";
            }
            
            return warning;
        }

    }
}
