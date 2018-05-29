using Foundation;
using GetItDone.List.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using UIKit;

namespace GetItDone.List
{
    public partial class HappeningTableViewController : UITableViewController
    {
        private string pathToDatabase;
        private List<Happening> happenings;
        public HappeningTableViewController(IntPtr handle) : base(handle)
        {
            happenings = new List<Happening>();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            happenings = new List<Happening>();

            var documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            pathToDatabase = Path.Combine(documentsFolder, "happenings_db.db");

            //create connection
            using (var connection = new SQLite.SQLiteConnection(pathToDatabase))
            {
                connection.CreateTable<Happening>();
            }

        }
        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

            using (var connection = new SQLite.SQLiteConnection(pathToDatabase))
            {
                var query = connection.Table<Happening>();

                foreach (Happening happening in query)
                {
                    happenings.Add(happening);
                    happenings.Sort((x, y) => { return x.Date.CompareTo(y.Date); });
                    TableView.ReloadData();

//TODO              There is a duplicate.
                    TableView.Source = new HappeningTableViewSource(happenings, this);
                }
            }
        }
        /*
        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return happenings.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell("happening");
            var data = happenings[indexPath.Row];
            cell.TextLabel.Text = data.Title;
            cell.DetailTextLabel.Text = data.Date;

            return cell;
        }
        */
    }
}