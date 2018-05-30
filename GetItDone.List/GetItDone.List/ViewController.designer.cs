// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace GetItDone.List
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch commentSwitch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField commentTextView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField dateLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIDatePicker datePickerView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField locationTextView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem saveButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISegmentedControl segmentedControl { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField titleTextField { get; set; }

        [Action ("commentSwitch_ActionSheet:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void commentSwitch_ActionSheet (UIKit.UISwitch sender);

        [Action ("DateTimeChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void DateTimeChanged (UIKit.UIDatePicker sender);

        [Action ("OnTapGestureRecognized:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void OnTapGestureRecognized (UIKit.UITapGestureRecognizer sender);

        [Action ("partialvoidcommentSwitch_ValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void partialvoidcommentSwitch_ValueChanged (UIKit.UISwitch sender);

        void ReleaseDesignerOutlets ()
        {
            if (commentSwitch != null) {
                commentSwitch.Dispose ();
                commentSwitch = null;
            }

            if (commentTextView != null) {
                commentTextView.Dispose ();
                commentTextView = null;
            }

            if (dateLabel != null) {
                dateLabel.Dispose ();
                dateLabel = null;
            }

            if (datePickerView != null) {
                datePickerView.Dispose ();
                datePickerView = null;
            }

            if (locationTextView != null) {
                locationTextView.Dispose ();
                locationTextView = null;
            }

            if (saveButton != null) {
                saveButton.Dispose ();
                saveButton = null;
            }

            if (segmentedControl != null) {
                segmentedControl.Dispose ();
                segmentedControl = null;
            }

            if (titleTextField != null) {
                titleTextField.Dispose ();
                titleTextField = null;
            }
        }
    }
}