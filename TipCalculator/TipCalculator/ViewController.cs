using System;

using UIKit;

namespace TipCalculator
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            /*
            nameField.EditingDidEndOnExit += (sender, e) => {
                sliderLabel.Text = "OK";
                ((UITextField)sender).ResignFirstResponder();
            };

            ((UIControl)View).TouchDown += (sender, e) => {
                nameField.ResignFirstResponder();
                numberField.ResignFirstResponder();
            };
            */
        }


        partial void serviceSlider_ValueChanged(UISlider sender)
        {
            int progress = (int)sender.Value;
            tipPercentageText.Text = progress.ToString();
        }

        partial void taxSwitch_ValueChanged(UISwitch sender)
        {
            bool setting = sender.On;
            //leftSwitch.SetState(setting, true);
            //rightSwitch.SetState(setting, true);
        }

        partial void taxSwitch_ActionSheet(UISwitch sender)
        {
            //Conroller
            //ActionSheet
            var controller = UIAlertController.Create(String.Format("Are You Sure You Want to Tip {0}?", tipPercentageText.Text), null, UIAlertControllerStyle.ActionSheet);

            var yesAction = UIAlertAction.Create("Yes, I'm Sure!", UIAlertActionStyle.Destructive,
                (action) =>
                {
                string msg = Int32.Parse(this.tipPercentageText.Text) > 15
                      ? "You can breath easy, you tipped correctly"
                      : "Sorry you had such bad service";

                    // Controller within a controller
                    var cancelAction = UIAlertAction.Create("Phew, You Can Still Change Your Tip!", UIAlertActionStyle.Cancel, null);

                //wha???????
                    var controller2 = UIAlertController.Create("Something Was Done", msg, UIAlertControllerStyle.Alert);
                    controller2.AddAction(cancelAction);
                    this.PresentViewController(controller2, true, null);
                });

            var noAction = UIAlertAction.Create("No way!", UIAlertActionStyle.Cancel, null);
            controller.AddAction(noAction);
            controller.AddAction(yesAction);

            var ppc = controller.PopoverPresentationController;
            if (ppc != null)
            {
                ppc.SourceView = sender;
                ppc.SourceRect = sender.Bounds;
            }

            PresentViewController(controller, true, null);

        }


        /*
        partial void choiceSegmentedControl_ValueChanged(UISegmentedControl sender)
        {
            if (sender.SelectedSegment == 0)    // Switches selected
            {
                leftSwitch.Hidden = false;
                rightSwitch.Hidden = false;
                doSomethingButton.Hidden = true;
            }
            else
            {
                leftSwitch.Hidden = true;           // Button selected
                rightSwitch.Hidden = true;
                doSomethingButton.Hidden = false;
            }

        }
        */

        #endregion
    }
}
