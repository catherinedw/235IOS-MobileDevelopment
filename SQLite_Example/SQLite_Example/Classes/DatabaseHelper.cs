using System;
namespace SQLite_Example.Classes
{
    public class DatabaseHelper
    {
        public DatabaseHelper()
        {
        }

        //Generics method
        public static bool Insert<T>(ref T data, string db_path)
        {
            //create connection
            using (var conn = new SQLite.SQLiteConnection(db_path))
            {
                conn.CreateTable<T>();

                if (conn.Insert(data) != 0) // if something was inserted
                    return true;
            }

            return false;
        }
    }
}
