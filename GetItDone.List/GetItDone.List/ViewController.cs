using System;
using System.IO;
using CoreGraphics;
using Foundation;
using GetItDone.List.Classes;
using UIKit;

namespace GetItDone.List
{
    public partial class ViewController : UIViewController
    {
        private string pathToDatabase;
        protected ViewController(IntPtr handle) : base(handle)
        {
            var documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            pathToDatabase = Path.Combine(documentsFolder, "happenings_db.db");
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            saveButton.Clicked += SaveButton_Clicked;
            // Perform any additional setup after loading the view, typically from a nib.
            UIPickerView pickerView = new UIPickerView(
                            new CGRect(
                                UIScreen.MainScreen.Bounds.X - UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height - 230,
                                UIScreen.MainScreen.Bounds.Width,
                                180));
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.     
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            //create connection
            using (var connection = new SQLite.SQLiteConnection(pathToDatabase))
            {
                connection.Insert(new Happening()
                {
                    Title = titleTextField.Text,
                    //TODO this needs to be a picker
                    Date = (System.DateTime)datePickerView.Date
                });
                NavigationController.PopToRootViewController(true);
            }
        }

        public override bool ShouldAutorotateToInterfaceOrientation(UIInterfaceOrientation toInterfaceOrientation)
        {
            // Return true for supported orientations
            return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
        }

        partial void DateTimeChanged(UIDatePicker sender)
        {
            //Formatting for Date and Time
            NSDateFormatter dateTimeformat = new NSDateFormatter();
            dateTimeformat.DateStyle = NSDateFormatterStyle.Long;
            dateTimeformat.TimeStyle = NSDateFormatterStyle.Medium;

            var currentDate = NSDate.Now;
            datePickerView.MinimumDate = NSDate.Now;
            dateLabel.Text = dateTimeformat.ToString(datePickerView.Date);
        }

        //This gets rid of the text when you are done editing
        partial void OnTapGestureRecognized(UITapGestureRecognizer sender)
        {
            titleTextField.ResignFirstResponder();
            commentTextView.ResignFirstResponder();
            locationTextView.ResignFirstResponder();
        }

        //switch to add a comment
        partial void partialvoidcommentSwitch_ValueChanged(UISwitch sender)
        {
            bool setting = sender.On;
            if (setting) //switch on
            {
                commentTextView.UserInteractionEnabled = true; //Makes the tax percent text view editable
            }
            if (!setting) //switch off 
            {
                //changes total amount back to what it would be without tax
                commentTextView.UserInteractionEnabled = false;
            }

        }

        /*
        //Event to make sure you want to add tax when the switch is toggled on, and to confirm you dont want tax when toggled off
        partial void commentSwitch_ActionSheet(UISwitch sender)
        {
            var controller = UIAlertController.Create("Are You Sure You Want to Add a Comment?", null, UIAlertControllerStyle.ActionSheet);
            var yesAction = UIAlertAction.Create("Yes, I'm Sure!", UIAlertActionStyle.Destructive,
                (action) =>
                {
                    string msg = commentTextView.Text == ""
                      ? "You can now enter your comment"
                      : "You have already entered a comment";

                    // Controller within a controller
                    var cancelAction = UIAlertAction.Create("Enter1", UIAlertActionStyle.Cancel, null);

                    var controller2 = UIAlertController.Create(String.Format("Enter 2"), msg, UIAlertControllerStyle.Alert);
                    controller2.AddAction(cancelAction);
                    this.PresentViewController(controller2, true, null);
                });

            var noAction = UIAlertAction.Create("No thank you!", UIAlertActionStyle.Cancel,//Cancel, null);
                (action) =>
                {
                    taxSwitch.On = false;
                });

            controller.AddAction(noAction);
            if (taxSwitch.On)
            {
                controller.AddAction(yesAction);
            }

            var ppc = controller.PopoverPresentationController;
            if (ppc != null)
            {
                ppc.SourceView = sender;
                ppc.SourceRect = sender.Bounds;
            }

            PresentViewController(controller, true, null);
        }
        */
    }
}
