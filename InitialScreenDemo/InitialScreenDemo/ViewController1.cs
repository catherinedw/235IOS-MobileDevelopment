using Foundation;
using System;
using UIKit;

namespace InitialScreenDemo
{
    public partial class ViewController1 : UIViewController
    {
        partial void InitialActionCompleted(UIButton sender)
        {
            aButton.Hidden = true;  
        }

        public ViewController1 (IntPtr handle) : base (handle)
        {
            
        }
    }
}