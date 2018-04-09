// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace RomanConversion
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel instructionsLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel resultLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton toDecimalButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton toRomanButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField usrTextView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (instructionsLabel != null) {
                instructionsLabel.Dispose ();
                instructionsLabel = null;
            }

            if (resultLabel != null) {
                resultLabel.Dispose ();
                resultLabel = null;
            }

            if (toDecimalButton != null) {
                toDecimalButton.Dispose ();
                toDecimalButton = null;
            }

            if (toRomanButton != null) {
                toRomanButton.Dispose ();
                toRomanButton = null;
            }

            if (usrTextView != null) {
                usrTextView.Dispose ();
                usrTextView = null;
            }
        }
    }
}