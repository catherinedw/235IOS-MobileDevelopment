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

            a1Button.Enabled = true;
            a2Button.Enabled = true;
            a3Button.Enabled = true;
            b1Button.Enabled = true;
            b2Button.Enabled = true;
            b3Button.Enabled = true;
            c1Button.Enabled = true;
            c2Button.Enabled = true;
            c3Button.Enabled = true;

            a1Button.SetTitle(" ", UIControlState.Normal);
            a2Button.SetTitle(" ", UIControlState.Normal);
            a3Button.SetTitle(" ", UIControlState.Normal);
            b1Button.SetTitle(" ", UIControlState.Normal);
            b2Button.SetTitle(" ", UIControlState.Normal);
            b3Button.SetTitle(" ", UIControlState.Normal);
            c1Button.SetTitle(" ", UIControlState.Normal);
            c2Button.SetTitle(" ", UIControlState.Normal);
            c3Button.SetTitle(" ", UIControlState.Normal);

        }

        partial void A1Button_TouchUpInside(UIButton sender)
        {
            if (game.playerTurn == 1)
            {
                game.NewGame();
            }
            int compResult = game.PlayerChoice((int)sender.Tag);
            sender.SetTitle("X", UIControlState.Normal);
            sender.SetTitle("X", UIControlState.Disabled);
            sender.Enabled = false;

            switch (compResult)
            {
                case 1:
                    a1Button.SetTitle("O", UIControlState.Normal);
                    a1Button.SetTitle("", UIControlState.Disabled);
                    a1Button.Enabled = false;
                    break;
                case 2:
                    a2Button.SetTitle("O", UIControlState.Normal);
                    a2Button.SetTitle("", UIControlState.Disabled);
                    a2Button.Enabled = false;
                    break;
                case 3:
                    a3Button.SetTitle("O", UIControlState.Normal);
                    a3Button.SetTitle("", UIControlState.Disabled);
                    a3Button.Enabled = false;
                    break;
                case 4:
                    b1Button.SetTitle("O", UIControlState.Normal);
                    b1Button.SetTitle("", UIControlState.Disabled);
                    b1Button.Enabled = false;
                    break;
                case 5:
                    b2Button.SetTitle("O", UIControlState.Normal);
                    b2Button.SetTitle("", UIControlState.Disabled);
                    b2Button.Enabled = false;
                    break;
                case 6:
                    b3Button.SetTitle("O", UIControlState.Normal);
                    b3Button.SetTitle("", UIControlState.Disabled);
                    b3Button.Enabled = false;
                    break;
                case 7:
                    c1Button.SetTitle("O", UIControlState.Normal);
                    c1Button.SetTitle("", UIControlState.Disabled);
                    c1Button.Enabled = false;
                    break;
                case 8:
                    c2Button.SetTitle("O", UIControlState.Normal);
                    c2Button.SetTitle("", UIControlState.Disabled);
                    c2Button.Enabled = false;
                    break;
                case 9:
                    c3Button.SetTitle("O", UIControlState.Normal);
                    c3Button.SetTitle("", UIControlState.Disabled);
                    c3Button.Enabled = false;
                    break;
            /*
            bool result = game.CheckForWin();
            if (result)
            {
               //communicationLabel.Text = ("{0} win!", game.player);
            }
            else
            {
                if (game.playerTurn == 9)
                {
                    communicationLabel.Text = "Draw";
                }
                */
            }
        }
    }
}
