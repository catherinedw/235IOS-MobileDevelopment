using System;

using UIKit;

namespace TicTacToe
{
    public partial class ViewController : UIViewController
    {
        //Create an instance of the game
        private GameLogic game = new GameLogic();

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void NewGameButton_TouchUpInside(UIButton sender)
        {
            game.NewGame();

            a1Button.SetTitle("", UIControlState.Normal);
            a2Button.SetTitle("", UIControlState.Normal);
            a3Button.SetTitle("", UIControlState.Normal);
            b1Button.SetTitle("", UIControlState.Normal);
            b2Button.SetTitle("", UIControlState.Normal);
            b3Button.SetTitle("", UIControlState.Normal);
            c1Button.SetTitle("", UIControlState.Normal);
            c2Button.SetTitle("", UIControlState.Normal);
            c3Button.SetTitle("", UIControlState.Normal);
        }

        partial void A1Button_TouchUpInside(UIButton sender)
        {
            game.SetChoice((int)sender.Tag);
            //sender.SetTitle(game.NumberToPlace, UIControlState.Normal);
                
        }
    }
}
