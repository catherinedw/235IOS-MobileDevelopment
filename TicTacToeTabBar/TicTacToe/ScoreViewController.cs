using Foundation;
using System;
using UIKit;

namespace TicTacToe
{
    public partial class ScoreViewController : UIViewController
    {
        //public int ComputerName { get; set; }
        //UIViewController controller;
        string cName = "Computer";

        public ScoreViewController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            int pScore =((AppDelegate)UIApplication.SharedApplication.Delegate).PlayerScore;
            int cScore =((AppDelegate)UIApplication.SharedApplication.Delegate).ComputerScore;
            if (cName != null) 
            {
                cName =((AppDelegate)UIApplication.SharedApplication.Delegate).ComputerName;
            }
            scoreLabel.Text = "Player score: " + pScore + "\n" + cName + " score: " + cScore;
        }
    }
}