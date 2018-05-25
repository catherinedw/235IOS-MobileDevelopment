using Foundation;
using System;
using System.Collections.Generic;
using System.IO;
using UIKit;

namespace SQLite_Example.iOS
{
    public partial class BookTableViewController : UITableViewController
    {
        private string pathToDatabase;
        private List<Book> books;
        public BookTableViewController (IntPtr handle) : base (handle)
        {
            books = new List<Book>();
        }

		public override void ViewDidLoad()
		{
            base.ViewDidLoad();

            var documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            pathToDatabase = Path.Combine(documentsFolder, "books_db.db");

            //create connection
            using (var connection = new SQLite.SQLiteConnection(pathToDatabase))
            {
                connection.CreateTable<Book>();
            }

		}
		public override void ViewDidAppear(bool animated)
		{
            base.ViewDidAppear(animated);

            using (var connection = new SQLite.SQLiteConnection(pathToDatabase))
            {
                var query = connection.Table<Book>();

                foreach (Book book in query)
                {
                    books.Add(book);
                    TableView.ReloadData();

                }
            }
		}

		public override nint RowsInSection(UITableView tableView, nint section)
		{
            return books.Count;
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
            UITableViewCell cell = tableView.DequeueReusableCell("book");
            var data = books[indexPath.Row];
            cell.TextLabel.Text = data.Name;
            cell.DetailTextLabel.Text = data.Author;

            return cell;

		}
	}

}