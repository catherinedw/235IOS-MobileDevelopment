using System;

using UIKit;

namespace RomanConversion
{
    public partial class ViewController : UIViewController
    {
        private ConversionClass convertMe;
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            convertMe = new ConversionClass();
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            toRomanButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                // Convert the phone number with text to a number
                // using PhoneTranslator.cs
                resultLabel.Text = convertMe.ToRoman(Int32.Parse(usrTextView.Text));
                // Dismiss the keyboard if text field was tapped
                usrTextView.ResignFirstResponder();
            };
            toDecimalButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                // Convert the phone number with text to a number
                // using PhoneTranslator.cs
                resultLabel.Text = convertMe.ToDecimal(usrTextView.Text).ToString();
                // Dismiss the keyboard if text field was tapped
                usrTextView.ResignFirstResponder();
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}