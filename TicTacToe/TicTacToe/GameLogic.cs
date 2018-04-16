using System;
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
        public class TicTacToe
        {

            private char[,] board;
            private char currentPlayerMark;
            private char[] posn;

            public TicTacToe()
            {
                board = new char[3, 3];
                currentPlayerMark = 'x';
                initializeBoard();
            }


            // Set/Reset the board back to all empty values.
            public void initializeBoard()
            {

                // Loop through rows
                int n = 0;
                for (int i = 0; i < 3; i++)
                {

                    // Loop through columns
                    for (int j = 0; j < 3; j++)
                    {
                        n++;
                        board[i, j] = n.ToString();
                    }
                }
                posn = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            }


            // Print the current board (may be replaced by GUI implementation later)
            public void printBoard()
            {
                Console.WriteLine("-------------");

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("| ");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine(board[i, j] + " | ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("-------------");
                }
            }


            // Loop through all cells of the board and if one is found to be empty (contains char '-') then return false.
            // Otherwise the board is full.
            public bool isBoardFull()
            {
                bool isFull = true;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board[i, j] == '-')
                        {
                            isFull = false;
                        }
                    }
                }

                return isFull;
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
                return ((c1 != '-') && (c1 == c2) && (c2 == c3));
            }


            // Change player marks back and forth.
            public void changePlayer()
            {
                if (currentPlayerMark == 'x')
                {
                    currentPlayerMark = 'o';
                }
                else
                {
                    currentPlayerMark = 'x';
                }
            }


            // Places a mark at the cell specified by row and col with the mark of the current player.
            public bool placeMark(int row, int col)
            {

                // Make sure that row and column are in bounds of the board.
                if ((row >= 0) && (row < 3))
                {
                    if ((col >= 0) && (col < 3))
                    {
                        if (board[row, col] == '-')
                        {
                            board[row, col] = currentPlayerMark;
                            return true;
                        }
                    }
                }

                return false;
            }
            public void play()
            {

            }
        }
    }       
}

