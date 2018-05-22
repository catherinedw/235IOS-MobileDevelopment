using System;
using UIKit;
using Foundation; // needed for dataSource inheritance
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgramLanguages
{
    public class TableViewDataSource: UITableViewDataSource
    {
        // there is NO database or storage of Tasks in this example, just an in-memory array
        string[] tableItems;//, detailItems;
        Dictionary<string, List<string>> indexedTableItems;
        string[] keys;

        string cellIdentifier = "LanguagesCell"; // set in the Storyboard

        public TableViewDataSource(string[] items)
        {
            ///tableItems = items;
            indexedTableItems = new Dictionary<string, List<string>>();
            foreach (var t in items)
            {
                if (indexedTableItems.ContainsKey(t[0].ToString()))
                {
                    indexedTableItems[t[0].ToString()].Add(t);
                }
                else
                {
                    indexedTableItems.Add(t[0].ToString(), new List<string>() { t });
                }
            }
            keys = indexedTableItems.Keys.ToArray();
        }


        /// <summary> </summary>Called by the TableView to determine how many sections(groups) there are.
        public override nint NumberOfSections(UITableView tableView)
        {
            return keys.Length;
        }

        /// <summary> Called by the TableView to determine how many cells to create for that particular section.
        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return indexedTableItems[keys[section]].Count;
            ///return tableItems.Length;
        }

        /// <summary> Sections the index titles.
        public override String[] SectionIndexTitles(UITableView tableView)
        {
            return indexedTableItems.Keys.ToArray();
        }

        /*
        /// <summary>
        /// Called when a row is touched
        /// </summary>
        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            UIAlertController okAlertController = UIAlertController.Create("Row Selected", tableItems[indexPath.Row], UIAlertControllerStyle.Alert);
            okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
            owner.PresentViewController(okAlertController, true, null);

            tableView.DeselectRow(indexPath, true);
        }
        */

        /// <summary> Called by the TableView to get the actual UITableViewCell to render for the particular row
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            // in a Storyboard, Dequeue will ALWAYS return a cell,
            UITableViewCell cell = tableView.DequeueReusableCell (cellIdentifier);
            // now set the text 
            if (cell == null) //---- if there are no cells to reuse, create a new one
            {
                cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);
                cell = new UITableViewCell(UITableViewCellStyle.Subtitle, cellIdentifier);
            }
            cell.TextLabel.Text = indexedTableItems[keys[indexPath.Section]][indexPath.Row];//tableItems[indexPath.Row];

            // Add images to the cell
            //cell.ImageView.Image = UIImage.FromFile("Images/star");
            //cell.ImageView.HighlightedImage = UIImage.FromFile("Images/star2");
            /*
            //Cell style should be set to "Subtitle" or "RightDetial" in the storyboard
            //Add detail information

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

            return cell;
        }

        public string GetItem(int id)
        {
            return tableItems[id];
        }
    }
}
