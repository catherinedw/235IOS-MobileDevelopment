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
        UIKit.UIButton aboutButton { get; set; }

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
        UIKit.UILabel communicationLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel headerLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton newGameButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton scroreButton { get; set; }

        [Action ("A1Button_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void A1Button_TouchUpInside (UIKit.UIButton sender);

        [Action ("ActionButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ActionButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("NewGameButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void NewGameButton_TouchUpInside (UIKit.UIButton sender);

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

            if (aboutButton != null) {
                aboutButton.Dispose ();
                aboutButton = null;
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

            if (communicationLabel != null) {
                communicationLabel.Dispose ();
                communicationLabel = null;
            }

            if (headerLabel != null) {
                headerLabel.Dispose ();
                headerLabel = null;
            }

            if (newGameButton != null) {
                newGameButton.Dispose ();
                newGameButton = null;
            }

            if (scroreButton != null) {
                scroreButton.Dispose ();
                scroreButton = null;
            }
        }
    }
}