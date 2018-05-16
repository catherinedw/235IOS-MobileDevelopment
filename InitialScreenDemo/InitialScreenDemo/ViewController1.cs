using Foundation;
using System;
using UIKit;

namespace InitialScreenDemo
{
    public partial class ViewController1 : UIViewController
    {
        //This hides the button after it is clicked
        partial void InitialActionCompleted(UIButton sender)
        {
            aButton.Hidden = true;  
        }

        public ViewController1 (IntPtr handle) : base (handle)
        {
            
        }
        //This makes sure that the button stays hidden if there is no parent
        public override void ViewDidLoad()
        {
            if (ParentViewController != null)
            {
                aButton.Hidden = true;
            }

        }
    }
}