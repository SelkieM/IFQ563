using System;
using static System.Console; 
namespace TicTacToe
{
    public class GameEngine
    {
        //Setup GameEngine for User, OtherHuman, Computer (Random, Alpha-beta) 
        //Display message which player makes first move and prompt move
        //Setup user input

        private static int fieldInput=0;
        private static bool inputCorrect = true;
        private static char playerMarker = ' '; //"X" or "åO"
        public static int turns = 0;
        public int Turns { get; set; }


    public static void MakeMoves(int code)
        {
            turns = 0;
            fieldInput = 0;
            WriteLine("\nThe Game Begins!");
            WriteLine("");
            do
            {
                //Setup alternate player turns
                if (Player.playerNum == 1)
                {
                    Player.playerNum = 2;
                    AssignMarkers(Player.playerNum, fieldInput); 
                }
                else if (Player.playerNum == 2)
                {
                    Player.playerNum = 1;
                    AssignMarkers(Player.playerNum, fieldInput);
                }
                //Display Board
                //If move was valid, display final marker positions on Board
                GameBoard.SetBoard();
                turns++; //if no winner, keep playing (loop) 
                //Check Winner
                IsWinner.HorizontalWin(code);
                IsWinner.VerticalWin(code);
                IsWinner.DiagonalWin(code);

                if (turns ==10)
                {
                    IsWinner.Draw(); //check draws after 10 turns (game has only 9 squares for input)
                }
                //Start game play here 
                do
                {
                    try
                    {
                        if (turns % 2 == 0)
                        {
                            if (code == 0)
                            {
                                //Prompt for player to move
                                Write("\nReady Player {0}: It's your move! Choose your input from 1-9 >>> ", Player.playerNum);
                                fieldInput = Convert.ToInt32(ReadLine());
                            }
                            else if (code == 1)
                            {
                                Write("Computer Random Player played at position>> ");
                                fieldInput = ComputerRandom.GetInput();
                                WriteLine(fieldInput);
                            }
                            else if (code == 2)
                            {
                                Write("Computer Alpha Beta Player played at position>> ");
                                fieldInput = ComputerAlphaBeta.GetInput();
                                WriteLine(fieldInput);
                            }
                        }
                        else
                        {
                            //Prompt for player to move
                            Write("\nReady Player {0}: It's your move! Choose your input from 1-9 >>> ", Player.playerNum);
                            fieldInput = Convert.ToInt32(ReadLine());
                        }
                    }
                    catch
                    {
                        WriteLine("You did not enter a valid number!"); //error message if input is not a valid number 
                    }
                    //each fieldinput of 1-9 corresponds to specific position on board
                    if ((fieldInput == 1) && (GameBoard.boardPosition[0, 0] == '1'))
                        inputCorrect = true;
                    else if ((fieldInput == 2) && (GameBoard.boardPosition[0, 1] == '2'))
                        inputCorrect = true;
                    else if ((fieldInput == 3) && (GameBoard.boardPosition[0, 2] == '3'))
                        inputCorrect = true;
                    else if ((fieldInput == 4) && (GameBoard.boardPosition[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((fieldInput == 5) && (GameBoard.boardPosition[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((fieldInput == 6) && (GameBoard.boardPosition[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((fieldInput == 7) && (GameBoard.boardPosition[2, 0] == '7'))
                        inputCorrect = true;
                    else if ((fieldInput == 8) && (GameBoard.boardPosition[2, 1] == '8'))
                        inputCorrect = true;
                    else if ((fieldInput == 9) && (GameBoard.boardPosition[2, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        WriteLine("Please re-enter a valid input."); // error message if input is duplicated 
                        inputCorrect = false;
                    }
                } while (!inputCorrect);

            } while (inputCorrect == true);
        
        }

        public static void AssignMarkers(int playerNo, int fieldInput)
        {
            //Assign Markers 'X' and 'O' to Players 1 & 2 initially - Player 1 (User) = X, Player 2 = O 
            if (playerNo == 2)
            {
                playerMarker = 'X';
            }
            else if (playerNo == 1)
            {
                playerMarker = 'O';
            }
            switch (fieldInput)
            {
                //each fieldinput on board that was selected is replaced with playerMarker 'X' or 'O' 
                case 1:
                    GameBoard.boardPosition[0, 0] = playerMarker;
                    break;
                case 2:
                    GameBoard.boardPosition[0, 1] = playerMarker;
                    break;
                case 3:
                    GameBoard.boardPosition[0, 2] = playerMarker;
                    break;
                case 4:
                    GameBoard.boardPosition[1, 0] = playerMarker;
                    break;
                case 5:
                    GameBoard.boardPosition[1, 1] = playerMarker;
                    break;
                case 6:
                    GameBoard.boardPosition[1, 2] = playerMarker;
                    break;
                case 7:
                    GameBoard.boardPosition[2, 0] = playerMarker;
                    break;
                case 8:
                    GameBoard.boardPosition[2, 1] = playerMarker;
                    break;
                case 9:
                    GameBoard.boardPosition[2, 2] = playerMarker;
                    break;

            }
        }
    }
}
