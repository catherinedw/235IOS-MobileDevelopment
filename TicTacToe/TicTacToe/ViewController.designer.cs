// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace TicTacToe
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton a1Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton a2Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton a3Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton b1Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton b2Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton b3Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton c1Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton c2Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton c3Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel instructorLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton startButton { get; set; }

        [Action ("UIButton402_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton402_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (a1Button != null) {
                a1Button.Dispose ();
                a1Button = null;
            }

            if (a2Button != null) {
                a2Button.Dispose ();
                a2Button = null;
            }

            if (a3Button != null) {
                a3Button.Dispose ();
                a3Button = null;
            }

            if (b1Button != null) {
                b1Button.Dispose ();
                b1Button = null;
            }

            if (b2Button != null) {
                b2Button.Dispose ();
                b2Button = null;
            }

            if (b3Button != null) {
                b3Button.Dispose ();
                b3Button = null;
            }

            if (c1Button != null) {
                c1Button.Dispose ();
                c1Button = null;
            }

            if (c2Button != null) {
                c2Button.Dispose ();
                c2Button = null;
            }

            if (c3Button != null) {
                c3Button.Dispose ();
                c3Button = null;
            }

            if (instructorLabel != null) {
                instructorLabel.Dispose ();
                instructorLabel = null;
            }

            if (startButton != null) {
                startButton.Dispose ();
                startButton = null;
            }
        }
    }
}