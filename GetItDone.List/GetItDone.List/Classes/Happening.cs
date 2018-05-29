using System;
using SQLite;

namespace GetItDone.List.Classes
{
    public class Happening
    {
        public Happening()
        {
        }

        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public DateTime Date
        {
            get;
            set;
        }

        public string Comment
        {
            get;
            set;
        }
        /****
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
****/
        public Happening(string title)
        { Title = title; }

    }
}
