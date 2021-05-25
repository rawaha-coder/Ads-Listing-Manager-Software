﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;

namespace Ads_Listing_Manager_Software.Database
{
    class DAO
    {
        public SQLiteConnection mSQLiteConnection;
        static String DB_NAME = "it_workstation_app_database.sqlite3";
        static String CONNECTION_URL = "Data Source=" + DB_NAME;

        public DAO()
        {
            mSQLiteConnection = new SQLiteConnection(CONNECTION_URL);
            if (!File.Exists("./" + DB_NAME))
            {
                SQLiteConnection.CreateFile(DB_NAME);
                Console.WriteLine(DB_NAME + " created");
            }

        }

        public SQLiteConnection getCon()
        {
            return mSQLiteConnection;
        }

        public void OpenConnection()
        {
            if (mSQLiteConnection.State != System.Data.ConnectionState.Open)
            {
                mSQLiteConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (mSQLiteConnection.State != System.Data.ConnectionState.Closed)
            {
                mSQLiteConnection.Close();
            }
        }
    }
}
