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

        public string Date
        {
            get;
            set;
        }
    }
}
