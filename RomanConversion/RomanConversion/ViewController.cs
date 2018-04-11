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
            // Button to convert from decimal(int) to roman(string)
            toRomanButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                try                 {
                    string resultR = convertMe.ToRoman(Int32.Parse(usrTextView.Text));
                    if (resultR == "-1")
                    {
                        resultLabel.Text = "Please enter a valid decimal number";
                    }
                    else
                    {
                        resultLabel.Text = string.Format("The roman numeral conversion of {0} is {1}", usrTextView.Text, resultR);
                        // Dismiss the keyboard if text field was tapped
                        usrTextView.ResignFirstResponder();
                        //clear user input
                        usrTextView.Text = ""; 
                    }
                }                 catch (Exception ex)
                {
                    Console.WriteLine("Error");                 }
            };
            // Button to convert from roman(string) to decimal(int)
            toDecimalButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                try 
                {
                    //this catches if the 
                    int resultD = convertMe.ToDecimal(usrTextView.Text);
                    if (resultD == -1){
                        resultLabel.Text = "Please enter a valid roman numeral";
                    }
                    else
                    {   
                        
                        resultLabel.Text = string.Format("{0} in decimal is {1}", usrTextView.Text, resultD);
                        // Dismiss the keyboard if text field was tapped
                        usrTextView.ResignFirstResponder();
                        //clear user input
                        usrTextView.Text = "";
                    }
                }
                //This catches values outside of the scope
                catch (Exception ex)
                {
                    Console.WriteLine("Error");
                }
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
 