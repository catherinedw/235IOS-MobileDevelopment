using System;

using UIKit;

namespace TicTacToe
{
    public partial class PlayViewController : UIViewController
    {
        //Create an instance of the game
        private GameLogic game = new GameLogic();

        protected PlayViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            // set our picker class to our newly created picker model
            namePicker.Model = new NameModel(this);
            namePicker.ShowSelectionIndicator = true;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void NewGameButton_TouchUpInside(UIButton sender)
        {
            game.NewGame();
            //reset communication label
            communicationLabel.Text = "Please pick a button";

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
            sender.SetTitle("O", UIControlState.Normal);
            sender.SetTitle("O", UIControlState.Disabled);
            sender.Enabled = false;

            switch (compResult)
            {
                case 1:
                    a1Button.SetTitle("X", UIControlState.Normal);
                    a1Button.SetTitle("X", UIControlState.Disabled);
                    a1Button.Enabled = false;
                    break;
                case 2:
                    a2Button.SetTitle("X", UIControlState.Normal);
                    a2Button.SetTitle("X", UIControlState.Disabled);
                    a2Button.Enabled = false;
                    break;
                case 3:
                    a3Button.SetTitle("X", UIControlState.Normal);
                    a3Button.SetTitle("X", UIControlState.Disabled);
                    a3Button.Enabled = false;
                    break;
                case 4:
                    b1Button.SetTitle("X", UIControlState.Normal);
                    b1Button.SetTitle("X", UIControlState.Disabled);
                    b1Button.Enabled = false;
                    break;
                case 5:
                    b2Button.SetTitle("X", UIControlState.Normal);
                    b2Button.SetTitle("X", UIControlState.Disabled);
                    b2Button.Enabled = false;
                    break;
                case 6:
                    b3Button.SetTitle("X", UIControlState.Normal);
                    b3Button.SetTitle("X", UIControlState.Disabled);
                    b3Button.Enabled = false;
                    break;
                case 7:
                    c1Button.SetTitle("X", UIControlState.Normal);
                    c1Button.SetTitle("X", UIControlState.Disabled);
                    c1Button.Enabled = false;
                    break;
                case 8:
                    c2Button.SetTitle("X", UIControlState.Normal);
                    c2Button.SetTitle("X", UIControlState.Disabled);
                    c2Button.Enabled = false;
                    break;
                case 9:
                    c3Button.SetTitle("X", UIControlState.Normal);
                    c3Button.SetTitle("X", UIControlState.Disabled);
                    c3Button.Enabled = false;
                    break;
                default:
                    break;
            }

            if (game.CheckForWin())
            {
                communicationLabel.Text = String.Format("{0} won!", game.Player);
                if (a1Button.Enabled){
                    a1Button.Enabled = false;
                }
                if (a2Button.Enabled)
                {
                    a2Button.Enabled = false;
                }
                if (a3Button.Enabled)
                {
                    a3Button.Enabled = false;
                }
                if (b1Button.Enabled)
                {
                    b1Button.Enabled = false;
                }
                if (b2Button.Enabled)
                {
                    b2Button.Enabled = false;
                }
                if (b3Button.Enabled)
                {
                    b3Button.Enabled = false;
                }
                if (c1Button.Enabled)
                {
                    c1Button.Enabled = false;
                }
                if (c2Button.Enabled)
                {
                    c2Button.Enabled = false;
                }
                if (c3Button.Enabled)
                {
                    c3Button.Enabled = false;
                }

                ((AppDelegate)UIApplication.SharedApplication.Delegate).PlayerScore = game.playerScore;
                ((AppDelegate)UIApplication.SharedApplication.Delegate).ComputerScore = game.computerScore;     
            }
            else if (game.playerTurn == 10)
            {
                communicationLabel.Text = "It's a draw!";
            }
        }

        public void DisplayName(string name)
        {
            ((AppDelegate)UIApplication.SharedApplication.Delegate).ComputerName = name;
        }

    }
}

