using System;
using static System.Console; 
namespace TicTacToe
{
    public class StandardMessages
    {
        public static void Welcome()
        {
            WriteLine("Wecome to a game!");
            WriteLine("\nIn this game, players are represented with a unique markers: X or O");
            WriteLine("The first player to score three same markers in a horizontal, vertical or diagonal row is the winner!");
            Write("\nGood luck! \nNow press any key to begin...");
            ReadKey();
            Clear();
        }
        public static void GameReset()
        {
            WriteLine(""); 
            Write("\nPress any key to reset the game >>> ");
            ReadKey();
            WriteLine("");
            GameBoard.BoardReset();
            Player.SetupPlayers();
        }
        public static void Continue()
        {
            WriteLine("");
            Write("\nPress any key to continue...");
            ReadKey();
            Clear();
        }
    }
}
