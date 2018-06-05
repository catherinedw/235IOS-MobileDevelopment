using Foundation;
using GetItDone.List.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UIKit;

namespace GetItDone.List
{
    public partial class HappeningTableViewController : UITableViewController
    {
        private string pathToDatabase;
        private List<Happening> happenings;
        public HappeningTableViewController(IntPtr handle) : base(handle)
        {
            //happenings = new List<Happening>();
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
                //Uncomment to delete table
                //connection.DropTable<Happening>();
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
                    happenings = happenings.OrderBy(x => x.Date).ThenBy(x => x.Importance).ThenBy(x => x.Title).ToList();

                    //TableView.AlwaysBounceVertical = false;
//TODO              There is a duplicate when you dont enter anything and return to table
                    TableView.Source = new HappeningTableViewSource(happenings, this);
                    TableView.RowHeight = UITableView.AutomaticDimension;
                    TableView.EstimatedRowHeight = 40f;
                    TableView.ReloadData();
                }
            }
        }
    }
}