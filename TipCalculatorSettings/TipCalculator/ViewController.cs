using System;
using UIKit;
using Foundation;

namespace TipCalculator
{
    public partial class ViewController : UIViewController
    {

        /***variables***/
        decimal tipAmount, taxAmount, total;
        int tipPercent, taxPercent = 0;
        string currency = "$", defaultColor = "UIColor.Yellow.CGColor";

        NSObject observer = null;

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewWillAppear (bool animated)
        {
            base.ViewWillAppear (animated);
            // Update the values shown in view 1 from the StandardUserDefaults
            RefreshFields ();

            // Subscribe to the applicationWillEnterForeground notification
            var app = UIApplication.SharedApplication;
            // NSNotificationCenter.DefaultCenter.AddObserver (this, UIApplication.WillEnterForegroundNotification, "ApplicationWillEnterForeground", app);
            // NSNotificationCenter.DefaultCenter.AddObserver (UIApplication.WillEnterForegroundNotification, ApplicationWillEnterForeground);
            observer = NSNotificationCenter.DefaultCenter.AddObserver (aName: UIApplication.WillEnterForegroundNotification, notify: ApplicationWillEnterForeground, fromObject: app);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle
        public override void ViewDidLoad()
        {
            this.View.Layer.BackgroundColor = defaultColor;
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            taxSwitch.On = false; //default of switch is off
            taxPercentageTextView.Text = taxPercent.ToString();
            //View.BackgroundColor = UIColor.FromName(color);


            //When the meal amount gets edited
            amountTextView.EditingDidEnd += (sender, e) => {
                try //to validate number input
                {
                    tipAmount = CalculateTipAmount(amountTextView.Text, (int)serviceSlider.Value);//Convert.ToDecimal(serviceSlider.Value));
                    taxAmount = CalculateTaxAmount(amountTextView.Text, taxPercent);
                    total = CalculateTotalAmount(amountTextView.Text, tipAmount, taxAmount);
                    tipAmountTextView.Text = currency + tipAmount.ToString();
                    taxAmountTextView.Text = currency + taxAmount.ToString();
                    totalTextView.Text = currency + total.ToString();
                }
                //This catches values outside of the scope
                catch (Exception ex)
                {
                    Console.WriteLine("Error");
                }
                ((UITextField)sender).ResignFirstResponder();
            };

            //When the tip percentage amount gets edited
            tipPercentageTextView.EditingDidEnd += (sender, e) => {
                tipPercent = Int32.Parse(tipPercentageTextView.Text);
                serviceSlider.Value = tipPercent; //this changes the slider value to match the input
                tipAmount = CalculateTipAmount(amountTextView.Text, tipPercent);
                total = CalculateTotalAmount(amountTextView.Text, tipAmount, taxAmount);
                tipAmountTextView.Text = currency + tipAmount.ToString();
                totalTextView.Text = currency + total.ToString();
                ((UITextField)sender).ResignFirstResponder();
            };

            //When the tax percentage gets edited
            taxPercentageTextView.EditingDidEnd += (sender, e) => {
                //disable till switch on
                if (taxPercentageTextView.UserInteractionEnabled)
                {
                    taxAmount = CalculateTaxAmount(amountTextView.Text, Convert.ToDecimal(taxPercentageTextView.Text));
                    total = CalculateTotalAmount(amountTextView.Text, tipAmount, taxAmount);
                    taxAmountTextView.Text = currency + taxAmount.ToString();
                    totalTextView.Text = currency + total.ToString();
                }
                    ((UITextField)sender).ResignFirstResponder();
            };
        }

        //This gets rid of the text when you are done editing
        partial void OnTapGestureRecognized(UITapGestureRecognizer sender)
        {
            amountTextView.ResignFirstResponder();             tipPercentageTextView.ResignFirstResponder();             taxPercentageTextView.ResignFirstResponder();
        }

        //slide the slider
        partial void serviceSlider_ValueChanged(UISlider sender)
        {   
            int progress = (int)sender.Value;
            tipPercentageTextView.Text = progress.ToString();
            tipAmount = CalculateTipAmount(amountTextView.Text, Convert.ToDecimal(progress));
            total = CalculateTotalAmount(amountTextView.Text, tipAmount, taxAmount);
            tipAmountTextView.Text = currency + tipAmount.ToString();
            totalTextView.Text = currency + total.ToString();
        }

        //switch change of value Event
        partial void taxSwitch_ValueChanged(UISwitch sender)
        {
            bool setting = sender.On;
            if (setting) //switch on
            {
                taxPercentageTextView.UserInteractionEnabled = true; //Makes the tax percent text view editable
            }
            if (!setting) //switch off 
            {
                //changes total amount back to what it would be without tax
                taxPercentageTextView.UserInteractionEnabled = false;
                taxPercent = 0;
                taxPercentageTextView.Text = taxPercent.ToString();
                taxAmount = CalculateTaxAmount(amountTextView.Text, taxPercent);
                total = CalculateTotalAmount(amountTextView.Text, tipAmount, taxAmount);
                taxAmountTextView.Text = currency + taxAmount.ToString();
                totalTextView.Text = currency + total.ToString();
            }

        }

        //Event to make sure you want to add tax when the switch is toggled on, and to confirm you dont want tax when toggled off
        partial void taxSwitch_ActionSheet(UISwitch sender)
        {
            var controller = UIAlertController.Create("Are You Sure You Want to Add a Tax?", null, UIAlertControllerStyle.ActionSheet);
            var yesAction = UIAlertAction.Create("Yes, I'm Sure!", UIAlertActionStyle.Destructive,
                (action) =>
                {
                string msg = taxPercent == 0
                  ? "You can breath easy, you live in Oregon"
                  : "Sorry you live in a State with state tax";

                    // Controller within a controller
                    var cancelAction = UIAlertAction.Create("Phew, You Can Still Change Your Tax Percentage!", UIAlertActionStyle.Cancel, null);

                    var controller2 = UIAlertController.Create(String.Format("Tax Amount: {0}", taxAmount), msg, UIAlertControllerStyle.Alert);
                    controller2.AddAction(cancelAction);
                    this.PresentViewController(controller2, true, null);
                });

            var noAction = UIAlertAction.Create("No way!", UIAlertActionStyle.Cancel,//Cancel, null);
                (action) =>
                {
                    taxSwitch.On = false;
                });

            controller.AddAction(noAction);
            if (taxSwitch.On)
            {
                controller.AddAction(yesAction);
            }

            var ppc = controller.PopoverPresentationController;
            if (ppc != null)
            {
                ppc.SourceView = sender;
                ppc.SourceRect = sender.Bounds;
            }

            PresentViewController(controller, true, null);
        }

        //Calculates tip
        private decimal CalculateTipAmount(string totalA, decimal tipP)
        {
            return Math.Round(Convert.ToDecimal(totalA) * tipP / 100, 2);
        }
        //Calculates tax
        private decimal CalculateTaxAmount(string totalA, decimal taxP)
        {
            return Math.Round(Convert.ToDecimal(totalA) * taxP / 100, 2);
        }
        //Calculates tax
        private decimal CalculateTotalAmount(string totalA, decimal tipA, decimal taxA)
        {
            return Math.Round(Convert.ToDecimal(totalA) + tipA + taxA, 2);
        }

        #endregion

        #region Settings
        private void RefreshFields()
        {
            NSUserDefaults defaults = NSUserDefaults.StandardUserDefaults;

            taxPercentageTextView.Text = defaults.IntForKey (Constants.TAX_PERCENTAGE).ToString();
            serviceSlider.Value = defaults.IntForKey (Constants.TIP_PERCENTAGE); //slider    //.FloatForKey
            tipPercentageTextView.Text = serviceSlider.Value.ToString();
            currency = defaults.StringForKey(Constants.CURRENCY_TYPE);
        //public const string CURRENCY_TYPE = "currencyType"; //make this into an array
        //public const string BACKGROUND_COLOR = "backgroundColor";
        }


        // We will subscribe to the applicationWillEnterForeground notification
        // so that this method is called when that notification occurs
        private void ApplicationWillEnterForeground(NSNotification notification)
        {
            var defaults = NSUserDefaults.StandardUserDefaults;
            defaults.Synchronize();
            RefreshFields();            
        }

        partial void settingsButton_TouchUpInside(UIButton sender)
        {
            UIApplication.SharedApplication.OpenUrl(new NSUrl(UIApplication.OpenSettingsUrlString));
        }

        partial void resetButton_TouchUpInside(UIButton sender)
        {
            NSUserDefaults.StandardUserDefaults.RemoveObject(Constants.TAX_PERCENTAGE);
            NSUserDefaults.StandardUserDefaults.RemoveObject(Constants.TIP_PERCENTAGE);
            NSUserDefaults.StandardUserDefaults.RemoveObject(Constants.CURRENCY_TYPE);
            RefreshFields();
        }
        #endregion



    }
}
