using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

namespace TicTacToe
{
    class Player
    {
        private static string[] playerType = {"Human", "Computer Random", "Computer Alpha Beta" };
        private static char[] playerCode = {'1', '2', '3' }; 
        private string[] PlayerType { get; set; }
        public int[] PlayerCode { get; set; }
        public static int playerNum = 2;
        public static char inputOpponentCode;

        public static void SetupPlayers()
        {
            inputOpponentCode = '0';
            playerNum = 2;
            //User selects play against Other Human (1), Computer Random (2), or Computer Alpha Beta (3).  
            //Display list of opponent codes
            DisplayOpponentCodes(); 
            //Prompt continuously for valid playerCode entered until Q entered to Quit
            const char QUIT = 'Q';
            Write("\nWho would you like to play against? Enter an opponent code (1, 2, or 3) to play against, or {0} to quit>> ", QUIT);

            try
            {
                inputOpponentCode = Convert.ToChar(ReadLine());
            }
            catch {
                
            };

            while (inputOpponentCode != QUIT)
            {
                bool flag = false;
                //check for matching code
                for (int i=0; i< playerCode.Length; i++)
                {
                    if (inputOpponentCode == playerCode[i]) //play against Other Human
                    {
                        //Assign User as Player 1 (Other Human is Player 2) 
                        Write("\nYou are Player {0}", playerNum - 1);
                        Write("\nYour {0} opponent is Player {1}", playerType[i], playerNum);
                        if (i == 0)
                            Human.HumanPlayer();
                        else if (i == 1)
                            ComputerRandom.ComputerRandomPlayer();
                        else
                            ComputerAlphaBeta.ComputerAlphaBetaPlayer();
                        flag = true;
                        break; 
                    }
                }
                if (!flag)
                {
                    WriteLine("\nInvalid Input!");
                    Write("Please re-enter opponent code (1, 2, or 3) to play against, or {0} to quit>> ", QUIT);
                    try
                    {
                        inputOpponentCode = Convert.ToChar(ReadLine());
                    }
                    catch
                    {

                    };
                }
            }
            Environment.Exit(0);
        }
        public static void DisplayOpponentCodes()
        {
            WriteLine(""); 
            WriteLine("\nOpponent codes are:");
            WriteLine("Enter Code:\t1\tto play against Other Human");
            WriteLine("Enter Code:\t2\tto play against Computer Randome");
            WriteLine("Enter Code:\t3\tto play against Computer Alpha Beta");
        }
    }

    class Human: Player
    {
        public static void HumanPlayer()
        {
            StandardMessages.Continue(); 
            GameEngine.MakeMoves(0);
        }
    }
    class ComputerRandom: Player
    {
        public static void ComputerRandomPlayer()
        {
            StandardMessages.Continue();
            GameEngine.MakeMoves(1);
        }
        public static int GetInput()
        {
            List<int> list= new List<int>();
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j  < 3; j++)
                {
                    if (GameBoard.boardPosition[i, j] != 'X' && GameBoard.boardPosition[i, j] != 'O')
                        list.Add((i * 3) + j + 1);
                }
            }
            Random random = new Random();
            int listSize = list.Count;

            int num =  random.Next(0, listSize);
            return list[num];
        }
    }
    class ComputerAlphaBeta: Player
    {
        public static void ComputerAlphaBetaPlayer()
        {
            StandardMessages.Continue();
            GameEngine.MakeMoves(2);
        }

        public static int calculateScore()
        {
            if (GameBoard.boardPosition[0, 0] == 'O' && GameBoard.boardPosition[0, 1] == 'O' && GameBoard.boardPosition[0, 2] == 'O')
                return 1;
            if (GameBoard.boardPosition[1, 0] == 'O' && GameBoard.boardPosition[1, 1] == 'O' && GameBoard.boardPosition[1, 2] == 'O')
                return 1;
            if (GameBoard.boardPosition[2, 0] == 'O' && GameBoard.boardPosition[2, 1] == 'O' && GameBoard.boardPosition[2, 2] == 'O')
                return 1;
            if (GameBoard.boardPosition[0, 0] == 'O' && GameBoard.boardPosition[1, 0] == 'O' && GameBoard.boardPosition[2, 0] == 'O')
                return 1;
            if (GameBoard.boardPosition[0, 1] == 'O' && GameBoard.boardPosition[1, 1] == 'O' && GameBoard.boardPosition[2, 1] == 'O')
                return 1;
            if (GameBoard.boardPosition[0, 2] == 'O' && GameBoard.boardPosition[1, 2] == 'O' && GameBoard.boardPosition[2, 2] == 'O')
                return 1;
            if (GameBoard.boardPosition[0, 0] == 'O' && GameBoard.boardPosition[1, 1] == 'O' && GameBoard.boardPosition[2, 2] == 'O')
                return 1;
            if (GameBoard.boardPosition[0, 2] == 'O' && GameBoard.boardPosition[1, 1] == 'O' && GameBoard.boardPosition[2, 0] == 'O')
                return 1;

            if (GameBoard.boardPosition[0, 0] == 'X' && GameBoard.boardPosition[0, 1] == 'X' && GameBoard.boardPosition[0, 2] == 'X')
                return -1;
            if (GameBoard.boardPosition[1, 0] == 'X' && GameBoard.boardPosition[1, 1] == 'X' && GameBoard.boardPosition[1, 2] == 'X')
                return -1;
            if (GameBoard.boardPosition[2, 0] == 'X' && GameBoard.boardPosition[2, 1] == 'X' && GameBoard.boardPosition[2, 2] == 'X')
                return -1;
            if (GameBoard.boardPosition[0, 0] == 'X' && GameBoard.boardPosition[1, 0] == 'X' && GameBoard.boardPosition[2, 0] == 'X')
                return -1;
            if (GameBoard.boardPosition[0, 1] == 'X' && GameBoard.boardPosition[1, 1] == 'X' && GameBoard.boardPosition[2, 1] == 'X')
                return -1;
            if (GameBoard.boardPosition[0, 2] == 'X' && GameBoard.boardPosition[1, 2] == 'X' && GameBoard.boardPosition[2, 2] == 'X')
                return -1;
            if (GameBoard.boardPosition[0, 0] == 'X' && GameBoard.boardPosition[1, 1] == 'X' && GameBoard.boardPosition[2, 2] == 'X')
                return -1;
            if (GameBoard.boardPosition[0, 2] == 'X' && GameBoard.boardPosition[1, 1] == 'X' && GameBoard.boardPosition[2, 0] == 'X')
                return -1;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (GameBoard.boardPosition[i, j] != 'X' && GameBoard.boardPosition[i, j] != 'O')
                        return -2;
                }
            }
            return 0;
        }

        public static int Minimax(bool isMax, int alpha, int beta)
        {
            int num = calculateScore();
            if (num != -2)
                return num;

            if (isMax)
            {
                int best = -1000;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (GameBoard.boardPosition[i, j] != 'X' && GameBoard.boardPosition[i, j] != 'O')
                        {
                            char temp = GameBoard.boardPosition[i, j];
                            GameBoard.boardPosition[i, j] = 'O';

                            best = Math.Max(best, Minimax(!isMax, alpha, beta));
                            alpha = Math.Max(alpha, best);

                            GameBoard.boardPosition[i, j] = temp;

                            if (beta <= alpha)
                                break;
                        }
                    }
                }
                return best;
            }
            else
            {
                int best = 1000;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (GameBoard.boardPosition[i, j] != 'X' && GameBoard.boardPosition[i, j] != 'O')
                        {
                            char temp = GameBoard.boardPosition[i, j];
                            GameBoard.boardPosition[i, j] = 'X';

                            best = Math.Min(best, Minimax(!isMax, alpha, beta));
                            beta = Math.Min(beta, best);

                            GameBoard.boardPosition[i, j] = temp;

                            if (beta <= alpha)
                                break;
                        }
                    }
                }
                return best;
            }
        }

        public static int GetInput()
        {
            int bestVal = -1000;
            int bestMove = -1;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (GameBoard.boardPosition[i, j] != 'X' && GameBoard.boardPosition[i, j] != 'O')
                    {
                        char temp = GameBoard.boardPosition[i, j];
                        GameBoard.boardPosition[i, j] = 'O';

                        int moveVal = Minimax(false, -1000, 1000);

                        GameBoard.boardPosition[i, j] = temp;
                        if (moveVal > bestVal)
                        {
                            bestMove = (i * 3) + j + 1;
                            bestVal = moveVal;
                        }
                    }
                }
            }

            return bestMove;
        }
    }

}