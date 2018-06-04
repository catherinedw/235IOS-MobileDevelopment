// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace TipCalculator
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel amountLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField amountTextView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel excellentLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel headerLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel PercentageLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel poorLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton resetButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel serviceLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider serviceSlider { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton settingsButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField taxAmountTextView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel taxLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField taxPercentageTextView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch taxSwitch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField tipAmountTextView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel tipLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField tipPercentageTextView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel totalLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField totalTextView { get; set; }

        [Action ("OnTapGestureRecognized:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void OnTapGestureRecognized (UIKit.UITapGestureRecognizer sender);

        [Action ("resetButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void resetButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("serviceSlider_ValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void serviceSlider_ValueChanged (UIKit.UISlider sender);

        [Action ("settingsButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void settingsButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("taxSwitch_ActionSheet:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void taxSwitch_ActionSheet (UIKit.UISwitch sender);

        [Action ("taxSwitch_ValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void taxSwitch_ValueChanged (UIKit.UISwitch sender);

        void ReleaseDesignerOutlets ()
        {
            if (amountLabel != null) {
                amountLabel.Dispose ();
                amountLabel = null;
            }

            if (amountTextView != null) {
                amountTextView.Dispose ();
                amountTextView = null;
            }

            if (excellentLabel != null) {
                excellentLabel.Dispose ();
                excellentLabel = null;
            }

            if (headerLabel != null) {
                headerLabel.Dispose ();
                headerLabel = null;
            }

            if (PercentageLabel != null) {
                PercentageLabel.Dispose ();
                PercentageLabel = null;
            }

            if (poorLabel != null) {
                poorLabel.Dispose ();
                poorLabel = null;
            }

            if (resetButton != null) {
                resetButton.Dispose ();
                resetButton = null;
            }

            if (serviceLabel != null) {
                serviceLabel.Dispose ();
                serviceLabel = null;
            }

            if (serviceSlider != null) {
                serviceSlider.Dispose ();
                serviceSlider = null;
            }

            if (settingsButton != null) {
                settingsButton.Dispose ();
                settingsButton = null;
            }

            if (taxAmountTextView != null) {
                taxAmountTextView.Dispose ();
                taxAmountTextView = null;
            }

            if (taxLabel != null) {
                taxLabel.Dispose ();
                taxLabel = null;
            }

            if (taxPercentageTextView != null) {
                taxPercentageTextView.Dispose ();
                taxPercentageTextView = null;
            }

            if (taxSwitch != null) {
                taxSwitch.Dispose ();
                taxSwitch = null;
            }

            if (tipAmountTextView != null) {
                tipAmountTextView.Dispose ();
                tipAmountTextView = null;
            }

            if (tipLabel != null) {
                tipLabel.Dispose ();
                tipLabel = null;
            }

            if (tipPercentageTextView != null) {
                tipPercentageTextView.Dispose ();
                tipPercentageTextView = null;
            }

            if (totalLabel != null) {
                totalLabel.Dispose ();
                totalLabel = null;
            }

            if (totalTextView != null) {
                totalTextView.Dispose ();
                totalTextView = null;
            }
        }
    }
}