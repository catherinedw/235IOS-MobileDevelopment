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
        NSObject observer = null;

        protected ViewController(IntPtr handle) : base(handle)
        {
            var documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            pathToDatabase = Path.Combine(documentsFolder, "happenings_db.db");
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            // Update the values shown in view 1 from the StandardUserDefaults
            RefreshFields();

            // Subscribe to the applicationWillEnterForeground notification
            var app = UIApplication.SharedApplication;
            // NSNotificationCenter.DefaultCenter.AddObserver (this, UIApplication.WillEnterForegroundNotification, "ApplicationWillEnterForeground", app);
            // NSNotificationCenter.DefaultCenter.AddObserver (UIApplication.WillEnterForegroundNotification, ApplicationWillEnterForeground);
            observer = NSNotificationCenter.DefaultCenter.AddObserver(aName: UIApplication.WillEnterForegroundNotification, notify: ApplicationWillEnterForeground, fromObject: app);
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

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
            NSNotificationCenter.DefaultCenter.RemoveObserver(observer);
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
            //sender.Locale = new NSLocale("NL");
            //Formatting for Date and Time
            NSDateFormatter dateTimeFormat = new NSDateFormatter();
            dateTimeFormat.DateStyle = NSDateFormatterStyle.Long;
            dateTimeFormat.TimeStyle = NSDateFormatterStyle.Short;
            dateTimeFormat.Locale = new NSLocale("NL");
            //[dateFormatter setLocale:[NSLocale currentLocale]];
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //dateTimePicker1.CustomFormat = "HH:mm:ss tt";
            var currentDate = NSDate.Now;
            datePickerView.MinimumDate = NSDate.Now;
            dateLabel.Text = dateTimeFormat.ToString(datePickerView.Date);
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

            var yesAction = UIAlertAction.Create("Yes, I'm Sure!", UIAlertActionStyle.Destructive, //null);
                (action) =>
                {
                    commentSwitch.On = true;
                });
            var noAction = UIAlertAction.Create("No, thank you!", UIAlertActionStyle.Cancel,
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

        private void RefreshFields()
        {
            NSUserDefaults defaults = NSUserDefaults.StandardUserDefaults;

            locationTextView.Text = defaults.StringForKey(Constants.LOCATION_KEY);
            string hoursPref = defaults.StringForKey(Constants.HOURS_KEY);
            commentTextView.Text = defaults.BoolForKey(Constants.COMMENT_SWITCH_KEY) ? "Enter Comment Here" : "Disabled";
        }

        // We will subscribe to the applicationWillEnterForeground notification
        // so that this method is called when that notification occurs
        private void ApplicationWillEnterForeground(NSNotification notification)
        {
            var defaults = NSUserDefaults.StandardUserDefaults;
            defaults.Synchronize();
            RefreshFields();
        }
    }
}
