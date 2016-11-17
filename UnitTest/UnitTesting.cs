using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using RollADiceGame;

namespace UnitTest
{
    [TestFixture]
    public class UnitTesting
    {
        [Test]
        public void PlayerCanRollTheDice()
        {
            RollADice newDiceRoll = new RollADice();

            Assert.GreaterOrEqual(newDiceRoll.RollTheDice(), 1);
            Assert.LessOrEqual(newDiceRoll.RollTheDice(), 6);
        }
        [Test]
        public void CanCheckWhoTheWinnerIs()
        {
            RollADice newDiceRoll = new RollADice();

            Assert.AreEqual("Player One Wins!", newDiceRoll.winOrLose(6, 2));
            Assert.AreEqual("Player Two Wins!", newDiceRoll.winOrLose(3, 5));
            Assert.AreEqual("It's A Draw!", newDiceRoll.winOrLose(4, 4));
        }
        [Test]
        public void CanSetAndGetUserName()
        {
            Player newPlayer = new Player("Lotto");

            Assert.AreEqual("Lotto", newPlayer.UserName);
        }
       /* [Test]
        public void PlayersCantHaveTheSameUserName()
        {
            //List<Item> items = new List<Item>() {  };
            PlayerRepository playerRepo = new PlayerRepository();
            Player newPlayer1 = new Player("Lotto");
            Player newPlayer2 = new Player("Lotto");

            playerRepo.AddPlayerToList(newPlayer1);
            playerRepo.AddPlayerToList(newPlayer2);

            Assert.AreEqual("Name already taken. Try something else.", playerRepo.CompareUserNames("Lotto"));
        }
        */
        [Test]
        public void CanGetPlayerWins()
        {
            Player newPlayer = new Player("Lotto");

            newPlayer.AddWin();
            newPlayer.AddWin();
            newPlayer.AddWin();

            Assert.AreEqual(3, newPlayer.WinCount);
        }
        [Test]
        public void CanAddOneToPlayerWins()
        {
            Player newPlayer = new Player("Lotto");

            newPlayer.AddWin();
            newPlayer.AddWin();

            Assert.AreEqual(2, newPlayer.WinCount);
        }
    }
}
