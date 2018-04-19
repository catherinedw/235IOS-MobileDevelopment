using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;


namespace TicTacToe
{
    public class GameLogic
    {
        /*** variables ***/
        const int MAXROW = 3, MAXCOLUMN = 3;
        private char[,] board = new char[MAXROW, MAXCOLUMN]; // keep track of which squares have been filled
        public int[,] grid = new int[3,3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }}; // keep track of which squares have been filled
        //public string[,] grid = new string[3, 3] { { "a1Button", "a2Button", "a3Button" }, { "b1Button", "b2Button", "b3Button" }, { "c1Button", "c2Button", "c3Button" } }; // keep track of which squares have been filled

        private bool[,] openBoard = new bool[MAXROW, MAXCOLUMN];  // keep track of which squares have been filled
        public Random rand = new Random();  // Random number generator
        public int playerTurn = 1;
        public string player;
        public char markToPlace;
        public string MarkToPlace { get { return markToPlace.ToString(); } }
        public int compButtonNumber;
        public int CompButtonNumber { get { return compButtonNumber; } }

        //Marks down the players symbols
        public int PlayerChoice(int buttonNumber)
        {
            int i = (buttonNumber - 1) / MAXCOLUMN;
            int j = (buttonNumber - 1) % MAXROW;
            if (CheckChoice(i, j))
            {
                board[i, j] = 'X';
                openBoard[i, j] = false;
                playerTurn++;
                if (!CheckForWin())
                {
                    player = "You";
                }
                else
                {
                   compButtonNumber = ComputerChoice();  
                } 
            }
            return compButtonNumber;
        }

        // Reset the board.
        public void NewGame()
        {
            playerTurn = 1;
            // Set all the squares as open (no number placed)
            for (int i = 0; i < MAXROW; i++) // Loop through rows
            {
                for (int j = 0; j < MAXCOLUMN; j++) // Loop through columns
                {
                    openBoard[i, j] = true;
                }
            }
        }

        //This marks a the computers randomly selected button
        public int ComputerChoice()//char[,] board)
        {
            int row = 0;
            int column = 0;
            do
            {
                row = rand.Next(MAXROW);
                column = rand.Next(MAXCOLUMN);
            } while (openBoard[row, column]);
            playerTurn++;
            board[row, column] = 'O';
            int result = grid[row, column];
            if (CheckForWin())
            {
                player = "Computer";
            }
            //need to return button number
            return result;
        }

        //This makes sure that the button isnt already taken 
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
            return ((CheckRowCol(board[0, 0], board[1, 1], board[2, 2]) == true) 
                    || (CheckRowCol(board[0, 2], board[1, 1], board[2, 0]) == true));
        }

        // Check to see if all three values are the same (and not empty) indicating a win.
        private bool CheckRowCol(char c1, char c2, char c3)
        {
            return ((c1 == c2) && (c2 == c3));
        }
    }
}       

