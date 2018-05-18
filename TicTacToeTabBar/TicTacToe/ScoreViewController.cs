using Foundation;
using System;
using UIKit;

namespace TicTacToe
{
    public partial class ScoreViewController : UIViewController
    {

        public ScoreViewController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            ((AppDelegate)UIApplication.SharedApplication.Delegate).PlayerScore = game.playerScore;
            ((AppDelegate)UIApplication.SharedApplication.Delegate).ComputerScore = game.computerScore;
            scoreLabel.Text = "Player score: " + PlayerScore + "\nComputer score: " + ComputerScore;
        }
    }
}