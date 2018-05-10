using Foundation;
using System;
using UIKit;

namespace TicTacToe
{
    public partial class scoreViewController : UIViewController
    {
        public string PlayerScore { get; set; }
        public string ComputerScore { get; set; }
        public scoreViewController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            scoreLabel.Text += "Player score: " + PlayerScore + "/n Computer score: " + ComputerScore;
        }
    }
}