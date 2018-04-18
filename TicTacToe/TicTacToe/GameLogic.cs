using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;


namespace TicTacToe
{
    public class GameLogic
    {
        public class TicTacToe
        {
            /*** variables ***/
            const int MAXROW = 3, MAXCOLUMN = 3;
            private char[,] board = new char[MAXROW, MAXCOLUMN]; // keep track of which squares have been filled
            private bool[,] openBoard = new bool[MAXROW, MAXCOLUMN];  // keep track of which squares have been filled
            public Random rand = new Random();  // Random number generator

            int playerTurn = 1;
            private int clickCount = 0;
            private int numberToPlace = 0;
            //private int matchesMade = 0;

            public string NumberToPlace { get { return numberToPlace.ToString(); } }
            //public bool Done { get { return matchesMade == ROWS * COLUMNS; } }
            public string ClickCount { get { return clickCount.ToString(); } }

            public void SetChoice(int turn, int i, int j)
            {
                if (turn == 1)
                {
                    board[i, j] = 'X';
                }
                else
                {
                    board[i, j] = 'O';
                }
            }
                                 
            // Set/Reset the board back to all empty values.
            public void NewGame()
            {
                clickCount = 0;
                // Set all the squares as open (no number placed)
                for (int i = 0; i < MAXROW; i++) // Loop through rows
                {
                    for (int j = 0; j < MAXCOLUMN; j++) // Loop through columns
                    {
                        openBoard[i, j] = true;
                    }
                }
            }

            void ComputerChoice(char[,] board)
            {
                //var rand = new Random();  // Random number generator

                //rand = new Random(); //importing the random number generator class
                int row = 0;
                int column = 0;
                do
                {
                    row = rand.Next(MAXROW);
                    column = rand.Next(MAXCOLUMN);
                } while (!CheckChoice(row ,column));

                SetChoice(2, row, column);
                //board[row, column] = 'O';
            }

            private bool CheckChoice(int i, int j)
            {
                if (board[i,j] != '0' && board[i,j] != 'X')
                {
                    return true;
                }
                    return false;
            }


            // Returns true if there is a win, false otherwise.
            // This calls our other win check functions to check the entire board.
            public bool CheckForWin()
            {
                return (CheckRowsForWin() || CheckColumnsForWin() || CheckDiagonalsForWin());
            }


            // Loop through rows and see if any are winners.
            private bool CheckRowsForWin()
            {
                for (int i = 0; i < 3; i++)
                {
                    if (CheckRowCol(board[i, 0], board[i, 1], board[i, 2]) == true)
                    {
                        return true;
                    }
                }
                return false;
            }

            // Loop through columns and see if any are winners.
            private bool CheckColumnsForWin()
            {
                for (int i = 0; i < 3; i++)
                {
                    if (CheckRowCol(board[0, i], board[1, i], board[2, i]) == true)
                    {
                        return true;
                    }
                }
                return false;
            }

            // Check the two diagonals to see if either is a win. Return true if either wins.
            private bool CheckDiagonalsForWin()
            {
                return ((CheckRowCol(board[0, 0], board[1, 1], board[2, 2]) == true) || (checkRowCol(board[0, 2], board[1, 1], board[2, 0]) == true));
            }

            // Check to see if all three values are the same (and not empty) indicating a win.
            private bool CheckRowCol(char c1, char c2, char c3)
            {
                return ((c1 == c2) && (c2 == c3));
            }

        }
    }       
}

