using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe;
using static System.Console;

namespace TicTacToe
{
    class Game
    {
        static char inputGameCode= '\0';
        public static void SetupGame()
        {
            DisplayGameCodes();
            Write("\nWhich game would you like to play? Enter game code (1, 2, or 3) to play>> ");

            bool flag = false;
            while (!flag)
            {
                try
                {
                    inputGameCode = Convert.ToChar(ReadLine());
                    flag = true;
                    while (inputGameCode != '1' && inputGameCode != '2' && inputGameCode != '3')
                    {
                        WriteLine("\nInvalid Input!");
                        Write("\nWhich game would you like to play? Enter game code (1, 2, or 3) to play>> ");
                        bool flag2 = false;
                        while (!flag2)
                        {
                            try
                            {
                                inputGameCode = Convert.ToChar(ReadLine());
                                flag2 = true;
                            }
                            catch
                            {
                                WriteLine("\nInvalid Input!");
                                Write("\nWhich game would you like to play? Enter game code (1, 2, or 3) to play>> ");
                            };
                        }
                        WriteLine(inputGameCode);
                    }
                }
                catch
                {
                    WriteLine("\nInvalid Input!");
                    Write("\nWhich game would you like to play? Enter game code (1, 2, or 3) to play>> ");
                };
            }

            if (inputGameCode == '1')
                TicTacToe.startGame();
            else if (inputGameCode == '2')
                Reversi.startGame();
            else if (inputGameCode == '3')
                Morris.startGame();
        }
        public static void DisplayGameCodes()
        {
            WriteLine("");
            WriteLine("\nGame codes are:");
            WriteLine("Enter Code:\t1\tto play Tic Tac Toe");
            WriteLine("Enter Code:\t2\tto play Reversi");
            WriteLine("Enter Code:\t3\tto play Morris");
        }
    }

    class TicTacToe : Game
    {
        public static void startGame()
        {
            StandardMessages.Welcome();   //Display welcome message & game rules
            Player.SetupPlayers(); //Setup 3 player types - User, Other Human, Computer 
        }
    }

    class Reversi : Game
    {
        public static void startGame()
        {
            WriteLine("\nGame has not been implemented yet!");
        }
    }

    class Morris : Game
    {
        public static void startGame()
        {
            WriteLine("\nGame has not been implemented yet!");
        }
    }
}
