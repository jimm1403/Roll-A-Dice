using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RollADiceGame;

namespace Roll_A_Dice_Game
{
    public class Program
    {
        PlayerRepository playerRepo = new PlayerRepository();
        List<Player> playerList;
        string NL = Environment.NewLine;
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        public void Run()
        {
            string choice = "";
            bool run = true;
            do
            {
                Console.Clear();
                ShowMenu();
                choice = GetUserInput();

                switch (choice)
                {
                    case "p": GamePlay(); break;
                    case "p1": PlayerOneRegistration(); break;
                    case "p2": PlayerTwoRegistration(); break;
                    case "e": run = false; break;
                    default: ShowMenuSelectionError(); break;
                }

            } while (run);
        }
        public void ShowMenu()
        {
            Console.WriteLine("Roll A Dice: The game about rolling the dice" + NL +
                "Type 'P1' to choose player 1 username." + NL +
                "Type 'P2' to choose player 2 username." + NL +
                "Type 'P' to play the game" + NL +
                "Type 'E' to exit game");
        }
        private void ShowMenuSelectionError()
        {
            Console.WriteLine("Invalid selection, enter to try again");
            Console.ReadKey();

        }
        public string GetUserInput()
        {
            string userInput = Console.ReadLine().ToLower();
            return userInput;
        }
        public string newPlayer()
        {
            string userName;
            userName = Console.ReadLine();
            Player newPlayer = new Player(userName);
            playerRepo.AddPlayerToList(newPlayer);

            return userName;
        }
        public void PlayerOneRegistration()
        {
            Console.WriteLine("Player 1 enter username");
            newPlayer();
        }
        public void PlayerTwoRegistration()
        {
            string userName;
            string warning;
            Console.WriteLine("Player 2 enter username");
            userName = newPlayer();
            warning = playerRepo.CompareUserNames(userName);
            Console.WriteLine(warning);
            Console.ReadKey();
        }
        public void GamePlay()
        {
            playerList = playerRepo.GetList();
            string p1Result;
            string p2Result;
            Console.WriteLine(playerList[0].ToString() + " Roll Dice (Click Enter)");
            p1Result = DiceRoll();
            Console.WriteLine("You rolled a: " + p1Result);
            Console.WriteLine(playerList[1].ToString() + " Roll Dice (Click Enter)");
            p2Result = DiceRoll();
            Console.WriteLine("You rolled a: " + p2Result);
            Console.WriteLine(WhoIsTheWinner(p1Result, p2Result));
            Console.WriteLine(playerList[0].ToString() + " has won: " + playerList[0].WinCount.ToString() + " Times" + NL +
                playerList[1].ToString() + " has won: " + playerList[1].WinCount.ToString() + " Times");
            Console.WriteLine("Click Enter to try again");
            Console.ReadKey();
        }
        public string DiceRoll()
        {
            Console.ReadKey();
            RollADice newRoll = new RollADice();

            int playerRoll = newRoll.RollTheDice();

            return playerRoll.ToString();

        }
        public string WhoIsTheWinner(string resultOne, string resultTwo)
        {
            RollADice newRoll = new RollADice();

            string winner;

            winner = newRoll.winOrLose(int.Parse(resultOne), int.Parse(resultTwo));

            return winner;
        }
    }
}
