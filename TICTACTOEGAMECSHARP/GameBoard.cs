using System;
using static System.Console; 
namespace TicTacToe
{
    class GameBoard
    {
        public static char[,] boardPosition =
            {
                {'1','2','3'},
                {'4','5','6'},
                {'7','8','9'},
            };
        private static int turns = 0; 
        public static void SetBoard()
        {
            WriteLine("     |       |       ");
            WriteLine(" {0}   | {1}     | {2} ", boardPosition[0,0], boardPosition[0,1], boardPosition[0,2]);
            WriteLine("-----|-------|-------");
            WriteLine("     |       |       ");
            WriteLine(" {0}   | {1}     | {2} ", boardPosition[1, 0], boardPosition[1, 1], boardPosition[1, 2]);
            WriteLine("-----|-------|-------");
            WriteLine("     |       |       ");
            WriteLine(" {0}   | {1}     | {2} ", boardPosition[2, 0], boardPosition[2, 1], boardPosition[2, 2]);
            WriteLine("     |       |       ");
            turns++; 

        }
        public static void BoardReset()
        {
            //Reset Board
            char[,] boardPositionReset =
            {
                {'1','2','3'},
                {'4','5','6'},
                {'7','8','9'},
            };
            boardPosition = boardPositionReset;
            turns = 0;
        }

    }
}
