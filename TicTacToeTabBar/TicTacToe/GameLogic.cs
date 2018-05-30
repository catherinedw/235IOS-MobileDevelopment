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
        private int[,] grid = new int[MAXROW, MAXCOLUMN] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }}; // keep track of which squares have been filled
        private bool[,] openBoard = new bool[MAXROW, MAXCOLUMN];  // keep track of which squares have been filled
        public int playerTurn = 1, compButtonNumber;
        private string player;
        public int CompButtonNumber { get { return compButtonNumber; } }
        public string Player { get { return player; } }
        private Random rand;
        public int playerScore = 0, computerScore = 0;
        //public int PlayerScore { get { return playerScore; } }
        //public int ComputerScore { get { return computerScore; } }

        //Marks down the players symbols
        public int PlayerChoice(int buttonNumber)
        {
            int i = (buttonNumber - 1) / MAXROW;
            int j = (buttonNumber - 1) % MAXCOLUMN;
            board[i, j] = 'O';
            openBoard[i, j] = false;
            playerTurn++;
            if (!CheckForWin() && playerTurn != 10)
            {
               compButtonNumber = ComputerChoice();
            }
            else
            {
                compButtonNumber = -1; // player wins
                player = "You";
                if (CheckForWin())
                {
                    playerScore += 1;
                    if (computerScore > 0)
                    {
                        computerScore -= 1;
                    }
                }
            }
            return compButtonNumber;
        }

        // Reset the board
        public void NewGame()
        {
            playerTurn = 1;
            // Set all the squares as open (no number placed)
            for (int i = 0; i < MAXROW; i++) // Loop through rows
            {
                for (int j = 0; j < MAXCOLUMN; j++) // Loop through columns
                {
                    board[i, j] = ' ';
                    openBoard[i, j] = true;
                }
            }
        }

        //This marks a the computers randomly selected button
        public int ComputerChoice()
        {
            rand = new Random();  // Random number generator
            int row = 0, column = 0, result = 0;
            do
            {
                row = rand.Next(MAXROW);
                column = rand.Next(MAXCOLUMN);
            } while (!openBoard[row, column]); 

            board[row, column] = 'X';
            openBoard[row, column] = false;
            result = grid[row, column];
            playerTurn++;

            if (CheckForWin()) // computer win
            {
                player = "Computer";
                computerScore += 1;
                if (playerScore>0)
                {
                    playerScore -= 1; 
                }
            }
            //need to return button number
            return result;
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
            return ((c1 != ' ') && (c1 == c2) && (c2 == c3));
        }
    }
}       

