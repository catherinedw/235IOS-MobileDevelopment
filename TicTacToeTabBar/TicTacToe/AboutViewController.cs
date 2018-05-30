using Foundation;
using System;
using UIKit;

namespace TicTacToe
{
    public partial class AboutViewController : UIViewController
    {
        public AboutViewController(IntPtr handle) : base(handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            aboutLabel.Text += "Tic Tac Toe rules: " +
                "\nThe object of Tic Tac Toe is to get three in a row. You play on a three by three game board.The first player is known as O and the second, played by the application is O. Player places Xs on the game board followed automatically by the application placing Os until either oppent has three in a row or all nine squares are filled. Three in a row constitutes a win and adds a point to the player's score and reducing 1 from the losers score. No one gets any points during a tie, when all the squares are filled. The lowest score you can get is 0." +
                "\n \n App produced by Catherine Whitaker in Spring 2018";
        }
    }
}