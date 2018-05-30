using System;
using UIKit;

namespace ProgramLanguages
{
    public class TableItem : IComparable
    {
        public string Heading { get; set; }

        public string SubHeading { get; set; }

        public string Developer { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            TableItem otherTableItem = obj as TableItem;
            if (otherTableItem != null)
                return string.Compare(this.Heading, otherTableItem.Heading, StringComparison.Ordinal);
            else
                throw new ArgumentException("Object is not a TableItem");
        }


        public UITableViewCellStyle CellStyle
        {
            get { return cellStyle; }
            set { cellStyle = value; }
        }
        protected UITableViewCellStyle cellStyle = UITableViewCellStyle.Default;

        public UITableViewCellAccessory CellAccessory
        {
            get { return cellAccessory; }
            set { cellAccessory = value; }
        }
        protected UITableViewCellAccessory cellAccessory = UITableViewCellAccessory.None;

        public TableItem() { }

        public TableItem(string heading)
        { Heading = heading; }
    }
}
