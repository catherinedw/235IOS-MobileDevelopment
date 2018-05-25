using System;
using System.IO;
using UIKit;

namespace SQLite_Example.iOS
{
    public partial class ViewController : UIViewController
    {
        private string pathToDatabase;
        protected ViewController(IntPtr handle) : base(handle)
        {
            var documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            pathToDatabase = Path.Combine(documentsFolder, "books_db.db");
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            saveButton.Clicked += SaveButton_Clicked;
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
                connection.Insert(new Book()
                {
                    Author = authorTextField.Text,
                    Name = nameTextField.Text
                });
                NavigationController.PopToRootViewController(true);
            }
        }
    }
}
