using Foundation;
using System;
using UIKit;

namespace TicTacToe
{
    public partial class scoreViewController : UIViewController
    {
        public string Score { get; set; }
        public scoreViewController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            scoreLabel.Text += Score;
        }
    }
}