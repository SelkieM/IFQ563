using System;
using static System.Console; 
namespace TicTacToe
{
    public class IsWinner
    {
        //Winner is first to match 3 markers horizontally, vertically, or diagonally
        //Display message - which player is winner
        private static char[] playerMarkerCode = { 'X', 'O' };


        public static void HorizontalWin(int code)
        {
            foreach (char playerMarkCode in playerMarkerCode)
            {
                if (((GameBoard.boardPosition[0, 0] == playerMarkCode) && (GameBoard.boardPosition[0, 1] == playerMarkCode) && (GameBoard.boardPosition[0, 2] == playerMarkCode))
                    || ((GameBoard.boardPosition[1, 0] == playerMarkCode) && (GameBoard.boardPosition[1, 1] == playerMarkCode) && (GameBoard.boardPosition[1, 2] == playerMarkCode))
                    || ((GameBoard.boardPosition[2, 0] == playerMarkCode) && (GameBoard.boardPosition[2, 1] == playerMarkCode) && (GameBoard.boardPosition[2, 2] == playerMarkCode)))
                {
                    Clear();
                    if (playerMarkCode == 'X')
                    {
                        WriteLine("Congratulations Player 1.\nYou have a achieved a horizontal win! ");
                        WinMessage(); 
                    }
                    else if (playerMarkCode == 'O')
                    {
                        if (code == 0)
                        {
                            WriteLine("Congratulations Player 2.\nYou have a achieved a horizontal win! ");
                            WinMessage();
                        }
                        else if(code == 1)
                            WriteLine("\nRandom Computer has defeated you! Hard Luck :(\n");
                        else
                            WriteLine("\nAlpha Beta Computer has defeated you! Hard Luck :(\n");
                    }
                    StandardMessages.GameReset();
                    break;

                }
            }
        }
        public static void VerticalWin(int code)
        {
            foreach (char playerMarkCode in playerMarkerCode)
            {
                if (((GameBoard.boardPosition[0, 0] == playerMarkCode) && (GameBoard.boardPosition[1, 0] == playerMarkCode) && (GameBoard.boardPosition[2, 0] == playerMarkCode))
                    || ((GameBoard.boardPosition[0, 1] == playerMarkCode) && (GameBoard.boardPosition[1, 1] == playerMarkCode) && (GameBoard.boardPosition[2, 1] == playerMarkCode))
                    || ((GameBoard.boardPosition[0, 2] == playerMarkCode) && (GameBoard.boardPosition[1, 2] == playerMarkCode) && (GameBoard.boardPosition[2, 2] == playerMarkCode)))
                {
                    Clear();
                    if (playerMarkCode == 'X')
                    {
                        WriteLine("Congratulations Player 1.\nYou have a achieved a vertical win! ");
                        WinMessage(); 
                    }
                    else if (playerMarkCode == 'O')
                    {
                        if (code == 0)
                        {
                            WriteLine("Congratulations Player 2.\nYou have a achieved a horizontal win! ");
                            WinMessage();
                        }
                        else if (code == 1)
                            WriteLine("\nRandom Computer has defeated you! Hard Luck :(\n");
                        else
                            WriteLine("\nAlpha Beta Computer has defeated you! Hard Luck :(\n");
                    }
                    StandardMessages.GameReset();
                    break;

                }
            }

        }
        public static void DiagonalWin(int code)
        {
            foreach (char playerMarkCode in playerMarkerCode)
            {
                if (((GameBoard.boardPosition[0, 0] == playerMarkCode) && (GameBoard.boardPosition[1, 1] == playerMarkCode) && (GameBoard.boardPosition[2, 2] == playerMarkCode))
                    || ((GameBoard.boardPosition[0, 2] == playerMarkCode) && (GameBoard.boardPosition[1, 1] == playerMarkCode) && (GameBoard.boardPosition[2, 0] == playerMarkCode)))
                {
                    Clear();
                    if (playerMarkCode == 'X')
                    {
                        WriteLine("Congratulations Player 1.\nYou have a achieved a diagonal win! ");
                        WinMessage();
                    }
                    else if (playerMarkCode == 'O')
                    {
                        if (code == 0)
                        {
                            WriteLine("Congratulations Player 2.\nYou have a achieved a horizontal win! ");
                            WinMessage();
                        }
                        else if (code == 1)
                            WriteLine("\nRandom Computer has defeated you! Hard Luck :(\n");
                        else
                            WriteLine("\nAlpha Beta Computer has defeated you! Hard Luck :(\n");
                    }
                    StandardMessages.GameReset(); 
                    break;

                }
            }

        }
        //Draw if all markers placed and no winners
        public static void Draw() 
        {
            Console.WriteLine("Looks like it's a draw.");
            StandardMessages.GameReset(); 
        }
        //Display win message
        public static void WinMessage()
        {
            Write("\nYou're the Tic Tac Toe Master!\n" + "\nTurns taken {0}", GameEngine.turns - 1);
        }
    }
}
