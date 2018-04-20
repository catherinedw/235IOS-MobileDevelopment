using System;

using UIKit;

namespace TipCalculator
{
    public partial class ViewController : UIViewController
    {
        /***variables***/
        double amount = 0.00;
        double tipAmount, taxAmount, total;
        int tipPercent, taxPercent = 0;

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
            //default of switch is off
            taxSwitch.On = false;
            taxPercentageTextView.Text = taxPercent.ToString();

            //This gets rid of the text when you are done editing
            amountTextView.EditingDidEndOnExit += (sender, e) => {
                tipAmount = Double.Parse(amountTextView.Text) * serviceSlider.Value / 100;
                taxAmount = Double.Parse(amountTextView.Text) * taxPercent / 100;
                //should make this a method
                total = Double.Parse(amountTextView.Text) + tipAmount + taxAmount;
                //should make this a method
                tipAmountTextView.Text = tipAmount.ToString();
                taxAmountTextView.Text = taxAmount.ToString();
                totalTextView.Text = total.ToString();//(Double.Parse(amountTextView.Text) + Double.Parse(tipAmountTextView.Text) + Double.Parse(taxAmountTextView.Text)).ToString();
                ((UITextField)sender).ResignFirstResponder();
            };

            tipPercentageTextView.EditingDidEndOnExit += (sender, e) => {
                serviceSlider.Value = Int32.Parse(tipPercentageTextView.Text); //this changes the slider value to match the input
                tipAmount = Double.Parse(amountTextView.Text) * serviceSlider.Value / 100;
                tipAmountTextView.Text = tipAmount.ToString();//(Double.Parse(amountTextView.Text) * Double.Parse(tipPercentageTextView.Text) / 100).ToString();
                total = Double.Parse(amountTextView.Text) + tipAmount + taxAmount;
                totalTextView.Text = total.ToString();//(Double.Parse(amountTextView.Text) + Double.Parse(tipAmountTextView.Text) + Double.Parse(taxAmountTextView.Text)).ToString();
                ((UITextField)sender).ResignFirstResponder();
            };

            taxPercentageTextView.EditingDidEndOnExit += (sender, e) => {
                //TODO disable till switch on
                if (taxPercentageTextView.UserInteractionEnabled)
                {
                    taxAmount = Double.Parse(amountTextView.Text) * Double.Parse(taxPercentageTextView.Text) / 100;
                    taxAmountTextView.Text = taxAmount.ToString();//(Double.Parse(amountTextView.Text) * Double.Parse(tipPercentageTextView.Text) / 100).ToString();
                    total = Double.Parse(amountTextView.Text) + tipAmount + taxAmount;
                    totalTextView.Text = total.ToString();//(Double.Parse(amountTextView.Text) + Double.Parse(tipAmountTextView.Text) + Double.Parse(taxAmountTextView.Text)).ToString();
                }
                    ((UITextField)sender).ResignFirstResponder();
            };
            /*
            ((UIControl)View).TouchDown += (sender, e) => {
                nameField.ResignFirstResponder();
                numberField.ResignFirstResponder();
            };
            */
        }

        //Event 
        partial void serviceSlider_ValueChanged(UISlider sender)
        {
            int progress = (int)sender.Value;
            tipPercentageTextView.Text = progress.ToString();
            tipAmount = Double.Parse(amountTextView.Text) * progress / 100;
            tipAmountTextView.Text = tipAmount.ToString();
            total = Double.Parse(amountTextView.Text) + tipAmount + taxAmount;
            totalTextView.Text = total.ToString();
            //tipAmountTextView.Text = progress.ToString();
        }

        partial void taxSwitch_ValueChanged(UISwitch sender)
        {
            bool setting = sender.On;
            if (taxSwitch.On) {
                //TODO enable tax value edit
                taxPercentageTextView.UserInteractionEnabled = true; 
            }
            //rightSwitch.SetState(setting, true);
        }

        partial void taxSwitch_ActionSheet(UISwitch sender)
        {
            //Conroller
            //ActionSheet
            var controller = UIAlertController.Create(String.Format("Are You Sure You Want to Tip {0}?", tipPercentageTextView.Text), null, UIAlertControllerStyle.ActionSheet);

            var yesAction = UIAlertAction.Create("Yes, I'm Sure!", UIAlertActionStyle.Destructive,
                (action) =>
                {
                string msg = Int32.Parse(this.tipPercentageTextView.Text) > 15
                      ? "You can breath easy, you tipped correctly"
                      : "Sorry you had such bad service";

                    // Controller within a controller
                    var cancelAction = UIAlertAction.Create("Phew, You Can Still Change Your Tip!", UIAlertActionStyle.Cancel, null);

                //wha???????
                    var controller2 = UIAlertController.Create("You Picked Your Tip Amount", msg, UIAlertControllerStyle.Alert);
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
