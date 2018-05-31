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
        public string segmentValue = "!";

        protected ViewController(IntPtr handle) : base(handle)
        {
            var documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            pathToDatabase = Path.Combine(documentsFolder, "happenings_db.db");
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            commentSwitch.On = false; //default of switch is off
            commentTextView.UserInteractionEnabled = false;
            // Perform any additional setup after loading the view, typically from a nib.
            saveButton.Clicked += SaveButton_Clicked;
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
                    Date = (System.DateTime)datePickerView.Date,
                    Importance = segmentValue,
                    Comment = commentTextView.Text,
                    Location = locationTextView.Text
                });
                NavigationController.PopToRootViewController(true);
            }
        }

//TODO rotation
        public override bool ShouldAutorotateToInterfaceOrientation(UIInterfaceOrientation toInterfaceOrientation)
        {
            // Return true for supported orientations
            return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
        }

        //picker 
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
                commentTextView.UserInteractionEnabled = true; //Makes the comment text view editable
            }
            if (!setting) //switch off 
            {
                //Makes the comment text view NON editable
                commentTextView.UserInteractionEnabled = false;
            }
        }

        //switch warning
        partial void commentSwitch_ActionSheet(UISwitch sender)
        {
            var controller = UIAlertController.Create("Are You Sure You Want to Add a Comment?", null, UIAlertControllerStyle.ActionSheet);
            var controllerOff = UIAlertController.Create("Your comment will be delete?", null, UIAlertControllerStyle.ActionSheet);

            var yesAction = UIAlertAction.Create("Yes, I'm Sure!", UIAlertActionStyle.Destructive, null);
            var noAction = UIAlertAction.Create("No thank you!", UIAlertActionStyle.Cancel,
                (action) =>
                {
                    string msg = commentTextView.Text == ""
                    ? "No comment was entered"
                    : "Your comment will be deleted";

                    // Controller within a controller
                    var cancelAction = UIAlertAction.Create("Delete", UIAlertActionStyle.Cancel, null);

                        var controller2 = UIAlertController.Create(String.Format("Warning"), msg, UIAlertControllerStyle.Alert);
                        controller2.AddAction(cancelAction);
                        this.PresentViewController(controller2, true, null);
                    
                    commentSwitch.On = false;
                    commentTextView.UserInteractionEnabled = false;
                    commentTextView.Text = "";     
                });

            controller.AddAction(yesAction);
            controller.AddAction(noAction);
           
            var ppc = controller.PopoverPresentationController;
            if (ppc != null)
            {
                ppc.SourceView = sender;
                ppc.SourceRect = sender.Bounds;
            }

            PresentViewController(controller, true, null);
        }

        partial void ImportanceChanged_SegmentedController(UISegmentedControl sender)
        {
            // Take action based on the number of players selected
            switch (segmentedControl.SelectedSegment)
            {
                case 0:
                    // Do something if the segment "!" is selected
                    segmentValue = segmentedControl.TitleAt(0);
                    //segmentedControl.TitleAt(0);
                    break;

                case 1:
                    // Do something if the segment "!" is selected
                    segmentValue = segmentedControl.TitleAt(1);
                    break;

                case 2:
                    // Do something if the segment "!" is selected
                    segmentValue = segmentedControl.TitleAt(2);
                    break;
            }
        }
    }
}
