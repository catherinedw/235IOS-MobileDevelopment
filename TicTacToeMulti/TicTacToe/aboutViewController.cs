using Foundation;
using System;
using UIKit;

namespace TicTacToe
{
    public partial class aboutViewController : UIViewController
    {
        public aboutViewController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            aboutLabel.Text += "Tic Tac Toe rules:" +
                "App produced by Catherine Whitaker in Spring 2018";
        }
    }
}