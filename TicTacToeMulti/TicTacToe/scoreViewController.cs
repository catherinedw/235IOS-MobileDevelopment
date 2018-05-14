using Foundation;
using System;
using UIKit;

namespace TicTacToe
{
    public partial class scoreViewController : UIViewController
    {
        public int PlayerScore { get; set; }
        public int ComputerScore { get; set; }
        public scoreViewController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            scoreLabel.Text = "Player score: " + PlayerScore + "\nComputer score: " + ComputerScore;
        }
    }
}