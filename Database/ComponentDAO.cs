using Ads_Listing_Manager_Software.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ads_Listing_Manager_Software.Database
{
    class ComponentDAO:DAO, DatabaseCRUD<Component>
    {
        public const string TABLE_COMPONENT = "Components";
        public const string COLUMN_COMPONENT_ID = "ComponentId";
        public const string COLUMN_COMPONENT_NAME = "ComponentName";
        public const string COLUMN_COMPONENT_DESCRIPTION = "ComponentDescription";

        private static ComponentDAO instance = null;

        private ComponentDAO() : base() { }

        public static ComponentDAO getInstance()
        {
            if (instance == null)
                instance = new ComponentDAO();
            return instance;
        }

        public void AddData(Component component)
        {
            string insertStmt = "INSERT INTO " + TABLE_COMPONENT + " ("
                                + COLUMN_COMPONENT_ID + ", "
                                + COLUMN_COMPONENT_NAME + ", "
                                + COLUMN_COMPONENT_DESCRIPTION
                                + ") VALUES ("
                                + "@" + COLUMN_COMPONENT_ID + ", "
                                + "@" + COLUMN_COMPONENT_NAME + ", "
                                + "@" + COLUMN_COMPONENT_DESCRIPTION
                                + ")";
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(insertStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.AddWithValue(COLUMN_COMPONENT_ID, component.Id);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_COMPONENT_NAME, component.Name);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_COMPONENT_DESCRIPTION, component.Description);
                sQLiteCommand.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void DeleteData(Component component)
        {
            var deleteStmt = "DELETE FROM " + TABLE_COMPONENT 
                + " WHERE " + COLUMN_COMPONENT_ID + " = " + component.Id + " "
                + " AND " + COLUMN_COMPONENT_ID + " > 5 ";
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(deleteStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public List<Component> SelectData()
        {
            List<Component> list = new List<Component>();
            var selectStmt = "SELECT * FROM " + TABLE_COMPONENT + " ORDER BY " + COLUMN_COMPONENT_ID + " ASC;";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        Component item = new Component
                        {
                            Id = result.GetInt32(result.GetOrdinal(COLUMN_COMPONENT_ID)),
                            Name = result.GetString(result.GetOrdinal(COLUMN_COMPONENT_NAME)),
                            Description = result.GetString(result.GetOrdinal(COLUMN_COMPONENT_DESCRIPTION)),
                        };
                        list.Add(item);
                    }
                }
                return list;
            }
            catch (SQLiteException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void UpdateData(Component component)
        {
            var updateStmt = "UPDATE " + TABLE_COMPONENT + " SET "
                            + COLUMN_COMPONENT_ID + " =@" + COLUMN_COMPONENT_ID + ", "
                            + COLUMN_COMPONENT_NAME + " =@" + COLUMN_COMPONENT_NAME + ", "
                            + COLUMN_COMPONENT_DESCRIPTION + " =@" + COLUMN_COMPONENT_DESCRIPTION + " "
                            + " WHERE " + COLUMN_COMPONENT_ID + " = " + component.Id + " "
                            + " AND " + COLUMN_COMPONENT_ID + " > 5 ";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(updateStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_COMPONENT_ID, component.Id));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_COMPONENT_NAME, component.Name));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_COMPONENT_DESCRIPTION, component.Description));
                sQLiteCommand.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        
        }

        public void CreateTable()
        {
            string createStmt = "CREATE TABLE " + TABLE_COMPONENT
                    + "(" + COLUMN_COMPONENT_ID + " INTEGER UNIQUE NOT NULL, "
                    + COLUMN_COMPONENT_NAME + " TEXT UNIQUE NOT NULL, "
                    + COLUMN_COMPONENT_DESCRIPTION + " TEXT DEFAULT '')";

            SQLiteCommand sQLiteCommand = new SQLiteCommand(createStmt, mSQLiteConnection);
            OpenConnection();
            sQLiteCommand.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
