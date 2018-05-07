using System;
using UIKit;
using System.Collections.Generic;  
using Foundation;  //this lets you inherit the UITableViewSource


namespace GetItDone
{
    public class TableViewSource: UITableViewSource
    {
        List < string > TableData;  
        string CellIdentifier = "TableCell";
        //In TableSource method insert a list of string parameter.
        public TableViewSource(List < string > items) {  
            TableData = items;  
        } 
        //in RowInSection -
        public override nint RowsInSection(UITableView tableview, nint section) {  
            return TableData.Count;  
        }  
        //In GetCell method -
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath) {  
            UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);  
            //---- if there are no cells to reuse, create a new one
            if (cell == null) {  
                cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier);  
            }  
            cell.TextLabel.Text = TableData[indexPath.Row];  
            return cell;  
        } 
    }
}
