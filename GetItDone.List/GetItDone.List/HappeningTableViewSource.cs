using System;
using UIKit;
using Foundation; // needed for dataSource inheritance
using System.Collections.Generic;
using System.IO;
using System.Linq;
using GetItDone.List.Classes;

namespace GetItDone.List
{
    public class HappeningTableViewSource: UITableViewSource
    {
        public HappeningTableViewSource()
        {
        }

        Dictionary<string, List<Happening>> indexedHappenings;
        string[] keys;
        HappeningTableViewController owner;
        string cellIdentifier = "HappeningCell"; // set in the Storyboard

        public HappeningTableViewSource(List<Happening> happening, HappeningTableViewController owner)
        {
            this.owner = owner;
            ///tableItems = items; //this is used when using an array
            indexedHappenings = new Dictionary<string, List<Happening>>();
            foreach (var t in happening)
            {
                if (indexedHappenings.ContainsKey(t.Title.Substring(0, 1)))
                {
                    indexedHappenings[t.Title.Substring(0, 1)].Add(t);
                }
                else
                {
                    indexedHappenings.Add(t.Title.Substring(0, 1), new List<Happening>() { t });
                }
            }
            keys = indexedHappenings.Keys.ToArray();
        }


        /// <summary> Called by the TableView to determine how many sections(groups) there are.
        public override nint NumberOfSections(UITableView tableView)
        {
            return keys.Length;
        }

        /// <summary> Called by the TableView to determine how many cells to create for that particular section.
        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return indexedHappenings[keys[section]].Count;
            ///return tableItems.Length;
        }

        /// <summary> Sections the index titles.
        public override String[] SectionIndexTitles(UITableView tableView)
        {
            return keys;
        }

        /// <summary> Called when a row is touched
        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            UIAlertController okAlertController = UIAlertController.Create("Chief Developers", indexedHappenings[keys[indexPath.Section]][indexPath.Row].Date, UIAlertControllerStyle.Alert);
            okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
            owner.PresentViewController(okAlertController, true, null);
            tableView.DeselectRow(indexPath, true);
        }


        /// <summary> Called by the TableView to get the actual UITableViewCell to render for the particular row
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            // in a Storyboard, Dequeue will ALWAYS return a cell,
            //---- declare vars
            UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);
            Happening item = indexedHappenings[keys[indexPath.Section]][indexPath.Row];
            // UNCOMMENT to use that subheader style
            var cellStyle = UITableViewCellStyle.Subtitle;

            // if there are no cells to reuse, create a new one
            if (cell == null)
            {
                // UNCOMMENT to use without the subheader style
                //cell = new UITableViewCell(item.CellStyle, cellIdentifier); 
                cell = new UITableViewCell(UITableViewCellStyle.Subtitle, cellIdentifier);
            }
            // UNCOMMENT one of these to detail button accessory
            //cell.Accessory = UITableViewCellAccessory.DetailButton;
            //---- set the accessory
//            cell.Accessory = item.CellAccessory;
//            cell.Accessory = UITableViewCellAccessory.None; // to clear the accessory
            //---- set the item text
            cell.TextLabel.Text = item.Title;

            if (cellStyle == UITableViewCellStyle.Subtitle
               || cellStyle == UITableViewCellStyle.Value1
               || cellStyle == UITableViewCellStyle.Value2)
            {
                cell.DetailTextLabel.Text = item.Date;
            }
            // Add images to the cell
            //cell.ImageView.Image = UIImage.FromFile("Images/star");
            //cell.ImageView.HighlightedImage = UIImage.FromFile("Images/star2");
            /*
             *          //---- if the item has a valid image, and it's not the contact style (doesn't support images)
            if(!string.IsNullOrEmpty(item.ImageName) && item.CellStyle != UITableViewCellStyle.Value2)
            {
                if(File.Exists(item.ImageName))
                { cell.ImageView.Image = UIImage.FromBundle(item.ImageName); }
            }
            */
            return cell;
        }

    }
}
