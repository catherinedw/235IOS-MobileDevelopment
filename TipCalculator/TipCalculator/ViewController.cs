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
        //changename
        partial void valueChanged_serviceslider(UISlider sender)
        {
            throw new NotImplementedException();
        }
        //change name
        partial void valueChanged_taxSwitch(UISwitch sender)
        {
            throw new NotImplementedException();
        }

        partial void TaxSwitch_ActionSheet(UISwitch sender)
        {
            //Conroller
            //ActionSheet

        }
    }
}
