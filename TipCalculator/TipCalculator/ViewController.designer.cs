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
        UIKit.UILabel serviceLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider serviceSlider { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField taxAmount { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel taxLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField taxPercentageText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch taxSwitch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField tipAmountText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel tipLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField tipPercentageText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel totalLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField totalText { get; set; }

        [Action ("TaxSwitch_ActionSheet:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void TaxSwitch_ActionSheet (UIKit.UISwitch sender);

        [Action ("valueChanged_serviceslider:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void valueChanged_serviceslider (UIKit.UISlider sender);

        [Action ("valueChanged_taxSwitch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void valueChanged_taxSwitch (UIKit.UISwitch sender);

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

            if (serviceLabel != null) {
                serviceLabel.Dispose ();
                serviceLabel = null;
            }

            if (serviceSlider != null) {
                serviceSlider.Dispose ();
                serviceSlider = null;
            }

            if (taxAmount != null) {
                taxAmount.Dispose ();
                taxAmount = null;
            }

            if (taxLabel != null) {
                taxLabel.Dispose ();
                taxLabel = null;
            }

            if (taxPercentageText != null) {
                taxPercentageText.Dispose ();
                taxPercentageText = null;
            }

            if (taxSwitch != null) {
                taxSwitch.Dispose ();
                taxSwitch = null;
            }

            if (tipAmountText != null) {
                tipAmountText.Dispose ();
                tipAmountText = null;
            }

            if (tipLabel != null) {
                tipLabel.Dispose ();
                tipLabel = null;
            }

            if (tipPercentageText != null) {
                tipPercentageText.Dispose ();
                tipPercentageText = null;
            }

            if (totalLabel != null) {
                totalLabel.Dispose ();
                totalLabel = null;
            }

            if (totalText != null) {
                totalText.Dispose ();
                totalText = null;
            }
        }
    }
}