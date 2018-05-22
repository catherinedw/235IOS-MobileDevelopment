using System;
using UIKit;
using Foundation; // needed for dataSource inheritance


namespace ProgramLanguages
{
    public class TableViewDataSource: UITableViewDataSource
    {
        // there is NO database or storage of Tasks in this example, just an in-memory array
        string[] tableItems;
        string cellIdentifier = "LanguagesCell"; // set in the Storyboard

        public TableViewDataSource(string[] items)
        {
            tableItems = items;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return tableItems.Length;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            // in a Storyboard, Dequeue will ALWAYS return a cell,
            UITableViewCell cell = tableView.DequeueReusableCell (cellIdentifier);
            // now set the text 
            //cell.TextLabel.Text = tableItems[indexPath.Row];
            string item = tableItems[indexPath.Row];

            // Add images to the cell
            //cell.ImageView.Image = UIImage.FromFile("Images/star");
            //cell.ImageView.HighlightedImage = UIImage.FromFile("Images/star2");

            // Cell style should be set to "Subtitle" or "RightDetial" in the storyboard
            // Add detail information
            /*
            const int NUM_DISNEY_DWARVES = 7;
            if (cell.DetailTextLabel != null)
            {
                if (indexPath.Row < NUM_DISNEY_DWARVES)
                {
                    cell.DetailTextLabel.Text = "Mr Disney";
                }
                else
                {
                    cell.DetailTextLabel.Text = "Mr Tolkien";
                }
            }
            
            */
            //---- if there are no cells to reuse, create a new one
            if (cell == null)
            { cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier); }

            cell.TextLabel.Text = item;
            return cell;
        }

        public string GetItem(int id)
        {
            return tableItems[id];
        }
    }
}
