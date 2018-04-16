using System;
namespace TicTacToe
{
    public class GameLogic
    {
        using System;
namespace TicTacToeGame
    {
        public class Program
        {
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
        }
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
    }         // 1 for player2, 2 for player2
    }
}


/*
 * using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PigGame_Library
{
    public class PigLogic
    {
        /*************** fields ********************/

private const int WINNING_SCORE = 10;
public const int BAD_NUMBER = 1;

private Random rand = new Random();
private int player1Score;
private int player2Score;
private int turnPoints;
private int turn;           // 1 for player2, 2 for player2

/************** Properties ***************/

public String Player1Name { get; set; }
public String Player2Name { get; set; }
public int Player1Score { get { return player1Score; } }
public int Player2Score { get { return player2Score; } }
public int TurnPoints { get { return turnPoints; } }
public int Turn { get { return turn; } }

/*************** Constructors *************/

public PigLogic()
{
    player1Score = 0;
    player2Score = 0;
    turnPoints = 0;
    turn = 1; // player 1 goes first
}

// Use to instantiate an object with the state for a game in progress
public PigLogic(int p1Score, int p2Score, int tPoints, int t)
{
    player1Score = p1Score;
    player2Score = p2Score;
    turnPoints = tPoints;
    turn = t;
}

/*************** public methods ******************/

// Start over without creating a new game object
public void ResetGame()
{
    player1Score = 0;
    player2Score = 0;
    turnPoints = 0;
    turn = 1;
}

// Roll die and update turn points field
public int RollDie()
{
    int roll = rand.Next(6) + 1;

    if (roll != BAD_NUMBER)
    {
        turnPoints += roll;
    }
    else
    {
        turnPoints = 0;
    }

    return roll;
}

// Get player based on the assumption that player 1 always goes first
public String GetCurrentPlayer()
{
    if (turn == 1)
        return Player1Name;
    else
        return Player2Name;
}


// toggles the turn number between 1 and 2
public int ChangeTurn()
{
    if (turn == 1)
        player1Score += turnPoints;
    else
        player2Score += turnPoints;

    turnPoints = 0;

    turn = turn % 2 + 1;
    return turn;
}

// rules for winning:
// 1. Both players need to have had the same number of turns
// 2. First player to reach WINNING_SCORE wins
// 3. If both players have reached WINNING_SCORE 
//    the one with the higher score wins
public String CheckForWinner()
{
    string name = "";

    if (player1Score >= WINNING_SCORE && player2Score >= WINNING_SCORE)
    {
        if (player1Score == player2Score)
        {
            name = "Tie";
        }
        else if (player1Score > player2Score)
        {
            name = Player1Name;
        }
        else
        {
            name = Player2Name;
        }
    }
    else if (player1Score >= WINNING_SCORE)
    {
        name = Player1Name;
    }
    else if (player2Score >= WINNING_SCORE)
    {
        name = Player2Name;
    }

    return name;
}

// Automatically play a turn for the current player
// Returns true if it wants to take another turn
// We'll keep rolling as long as points for the turn are low (less than 7)
public bool AiRoll(out int roll)
{
    roll = RollDie();
    return (turnPoints < 7);
}
    }
}

 */