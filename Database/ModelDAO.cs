
using Ads_Listing_Manager_Software.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Ads_Listing_Manager_Software.Database
{
    class ModelDAO:DAO, DatabaseCRUD<Model>
    {
        public const string TABLE_MODEL = "Models";
        public const string COLUMN_MODEL_ID = "ModelId";
        public const string COLUMN_MODEL_NAME = "ModelName";
        public const string COLUMN_MODEL_PRICE = "ModelPrice";
        public const string COLUMN_MODEL_DESCRIPTION = "ModelDescription";
        public const string COLUMN_MODEL_BRAND_ID = "ModelBrandId";

        private static ModelDAO instance = null;

        private ModelDAO() : base(){}

        public static ModelDAO getInstance()
        {
            if (instance == null)
                instance = new ModelDAO();
            return instance;
        }

        public List<Model> SelectData()
        {
            var selectStmt = "SELECT * FROM " + TABLE_MODEL + " ORDER BY " + COLUMN_MODEL_NAME + " ASC;";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                return GetDataFromResult(result);
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

        private static List<Model> GetDataFromResult(SQLiteDataReader result)
        {
            List<Model> list = new List<Model>();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    Model item = new Model();
                    item.Id = result.GetInt32(result.GetOrdinal(COLUMN_MODEL_ID));
                    item.Name = result.GetString(result.GetOrdinal(COLUMN_MODEL_NAME));
                    item.Price = result.GetDouble(result.GetOrdinal(COLUMN_MODEL_PRICE));
                    item.Description = result.GetString(result.GetOrdinal(COLUMN_MODEL_DESCRIPTION));
                    item.Brand.Id = result.GetInt32(result.GetOrdinal(COLUMN_MODEL_BRAND_ID));
                    list.Add(item);
                }
            }
            return list;
        }

        public List<Model> getModelsByBrandId(int Id)
        {
            var selectStmt = "SELECT * FROM " + TABLE_MODEL + " WHERE  " + COLUMN_MODEL_BRAND_ID + " = " + Id + " ORDER BY " + COLUMN_MODEL_NAME + " ASC;";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                return GetDataFromResult(result);
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

        public List<Model> GetModelsById(int Id)
        {
            var selectStmt = "SELECT * FROM " + TABLE_MODEL + " WHERE  " + COLUMN_MODEL_BRAND_ID + " = " + Id;

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                return GetDataFromResult(result);
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

        public void AddData(Model item)
        {
            string insertStmt = "INSERT INTO " + TABLE_MODEL + " ("
                    + COLUMN_MODEL_NAME + ", "
                    + COLUMN_MODEL_PRICE + ", "
                    + COLUMN_MODEL_DESCRIPTION + ", "
                    + COLUMN_MODEL_BRAND_ID
                    + ") VALUES ("
                    + "@" + COLUMN_MODEL_NAME + ", "
                    + "@" + COLUMN_MODEL_PRICE + ", "
                    + "@" + COLUMN_MODEL_DESCRIPTION + ", "
                    + "@" + COLUMN_MODEL_BRAND_ID
                    + ")";
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(insertStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.AddWithValue(COLUMN_MODEL_NAME, item.Name);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_MODEL_PRICE, item.Price);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_MODEL_DESCRIPTION, item.Description);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_MODEL_BRAND_ID, item.Brand.Id);
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

        public void UpdateData(Model item)
        {
            var updateStmt = "UPDATE " + TABLE_MODEL + " SET "
                 + COLUMN_MODEL_NAME + " =@" + COLUMN_MODEL_NAME + ", "
                 + COLUMN_MODEL_PRICE + " =@" + COLUMN_MODEL_PRICE + ", "
                 + COLUMN_MODEL_DESCRIPTION + " =@" + COLUMN_MODEL_DESCRIPTION + ", "
                 + COLUMN_MODEL_BRAND_ID + " =@" + COLUMN_MODEL_BRAND_ID + " "
                + " WHERE " + COLUMN_MODEL_ID + " = " + item.Id + " ";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(updateStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_MODEL_NAME, item.Name));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_MODEL_PRICE, item.Price));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_MODEL_DESCRIPTION, item.Description));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_MODEL_BRAND_ID, item.Brand.Id));
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

        public void DeleteData(Model item)
        {
            var deleteStmt = "DELETE FROM " + TABLE_MODEL + " WHERE " + COLUMN_MODEL_ID + " = " + item.Id + " ";

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

        public void CreateTable()
        {
            string createStmt = "CREATE TABLE " + TABLE_MODEL + "(" 
                    + COLUMN_MODEL_ID + " INTEGER PRIMARY KEY, "
                    + COLUMN_MODEL_NAME + " TEXT UNIQUE NOT NULL, "
                    + COLUMN_MODEL_PRICE + " REAL NOT NULL, "
                    + COLUMN_MODEL_DESCRIPTION + " TEXT DEFAULT '', "
                    + COLUMN_MODEL_BRAND_ID + " INTEGER NOT NULL)";

            SQLiteCommand sQLiteCommand = new SQLiteCommand(createStmt, mSQLiteConnection);
            OpenConnection();
            sQLiteCommand.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
