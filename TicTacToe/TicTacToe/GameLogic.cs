using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;


namespace TicTacToe
{
    public class GameLogic
    {
        /*
            public static void Main(string[] args)
            {
                //Your code goes here
                Console.WriteLine("Hello, world!");
                // Create game and initialize it.
                // First player will be 'x'
                TicTacToe game = new TicTacToe();

                // Player 'x' places a mark in the top right corner row 0, column 2
                // These values are based on a zero index array, so you may need to simply take in a row 1 and subtract 1 from it if you want that.
                game.placeMark(0, 2);

                // Lets print the board
                game.printBoard();

                // Did we have a winner?
                if (game.checkForWin())
                {
                    Console.WriteLine("We have a winner! Congrats!");
                    return;
                }
                else if (game.isBoardFull())
                {
                    Console.WriteLine("Appears we have a draw!");
                    return;
                }

                // No winner or draw, switch players to 'o'
                game.changePlayer();

                // Repeat steps again for placing mark and checking game status...
            }
        }*/
        /*** variables ***/

        public class TicTacToe
        {
            /*** variables ***/
            public char[,] board;
            const int MAXROW = 3;
            const int MAXCOLUMN = 3;

            //private char currentPlayerMark;
            private char[] posn;
            int turn = 1;
            int count= 0;

            public TicTacToe()
            {
                board = new char[MAXROW, MAXCOLUMN];
                initializeBoard();
            }

            /*
            public enum Player
            {
                X = 1 ,O
            }
            */

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
            public void initializeBoard()
            {
                // Loop through rows
                int n = 0;
                for (int i = 0; i < MAXROW; i++)
                {
                    // Loop through columns
                    for (int j = 0; j < MAXCOLUMN; j++)
                    {
                        n++;
                        board[i, j] = (char)n;
                    }
                }
                //This fills the array with 1-9
                posn = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9'  };
            }


            private int computerChoice()
            {
                Random rand = new Random(); //importing the random number generator class
                int row = 0;
                int column = 0;
                do
                {
                    row = rand.Next(1, MAXROW);
                    column = rand.Next(1, MAXCOLUMN);
                } while (!checkChoice(row ,column));

                SetChoice(2, row, column);
                return row;
                return column;

            }

            private bool checkChoice(int i, int j)
            {
                if (board[i,j] != '0' && board[i,j] != 'X')
                {
                    return true;
                }
                    return false;
            }


            // Returns true if there is a win, false otherwise.
            // This calls our other win check functions to check the entire board.
            public bool checkForWin()
            {
                return (checkRowsForWin() || checkColumnsForWin() || checkDiagonalsForWin());
            }


            // Loop through rows and see if any are winners.
            private bool checkRowsForWin()
            {
                for (int i = 0; i < 3; i++)
                {
                    if (checkRowCol(board[i, 0], board[i, 1], board[i, 2]) == true)
                    {
                        return true;
                    }
                }
                return false;
            }

            // Loop through columns and see if any are winners.
            private bool checkColumnsForWin()
            {
                for (int i = 0; i < 3; i++)
                {
                    if (checkRowCol(board[0, i], board[1, i], board[2, i]) == true)
                    {
                        return true;
                    }
                }
                return false;
            }

            // Check the two diagonals to see if either is a win. Return true if either wins.
            private bool checkDiagonalsForWin()
            {
                return ((checkRowCol(board[0, 0], board[1, 1], board[2, 2]) == true) || (checkRowCol(board[0, 2], board[1, 1], board[2, 0]) == true));
            }

            // Check to see if all three values are the same (and not empty) indicating a win.
            private bool checkRowCol(char c1, char c2, char c3)
            {
                return ((c1 == c2) && (c2 == c3));
            }

        }
    }       
}

