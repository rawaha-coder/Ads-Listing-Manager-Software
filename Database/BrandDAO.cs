using Ads_Listing_Manager_Software.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ads_Listing_Manager_Software.Database
{
    class BrandDAO:DAO
    {
        public const string TABLE_BRAND = "Brands";
        public const string COLUMN_BRAND_ID = "BrandId";
        public const string COLUMN_BRAND_NAME = "BrandName";
        public const string COLUMN_BRAND_DESCRIPTION = "BrandDescription";

        private static BrandDAO instance = null;

        private BrandDAO() : base(){}

        public static BrandDAO getInstance()
        {
            if (instance == null)
                instance = new BrandDAO();
            return instance;
        }

        public void AddData(Brand brand)
        {
            string insertStmt = "INSERT INTO " + TABLE_BRAND + " ("
                    + COLUMN_BRAND_NAME + ", "
                    + COLUMN_BRAND_DESCRIPTION
                    + ") VALUES ("
                    + "@" + COLUMN_BRAND_NAME + ", "
                    + "@" + COLUMN_BRAND_DESCRIPTION
                    + ")";
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(insertStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.AddWithValue(COLUMN_BRAND_NAME, brand.Name);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_BRAND_DESCRIPTION, brand.Description);
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


        public List<Brand> GetData()
        {
            List<Brand> list = new List<Brand>();
            var selectStmt = "SELECT * FROM " + TABLE_BRAND + " ORDER BY " + COLUMN_BRAND_NAME + " ASC;";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        Brand item = new Brand
                        {
                            Id = result.GetInt32(result.GetOrdinal(COLUMN_BRAND_ID)),
                            Name = result.GetString(result.GetOrdinal(COLUMN_BRAND_NAME)),
                            Description = result.GetString(result.GetOrdinal(COLUMN_BRAND_DESCRIPTION)),
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

        public Dictionary<string, Brand> ProductDictionary(int type)
        {
            Dictionary<string, Brand> dictionary = new Dictionary<string, Brand>();

            var selectStmt = "SELECT * FROM " + TABLE_BRAND + " ORDER BY " + COLUMN_BRAND_NAME + " ASC;";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        Brand item = new Brand
                        {
                            Id = result.GetInt32(result.GetOrdinal(COLUMN_BRAND_ID)),
                            Name = result.GetString(result.GetOrdinal(COLUMN_BRAND_NAME)),
                            Description = result.GetString(result.GetOrdinal(COLUMN_BRAND_DESCRIPTION)),
                        };
                        dictionary.Add(item.Name, item);
                    }
                }
                return dictionary;
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

        public void UpdateData(Brand item)
        {
            var updateStmt = "UPDATE " + TABLE_BRAND + " SET "
                 + COLUMN_BRAND_NAME + " =@" + COLUMN_BRAND_NAME + ", "
                 + COLUMN_BRAND_DESCRIPTION + " =@" + COLUMN_BRAND_DESCRIPTION + " "
                + " WHERE " + COLUMN_BRAND_ID + " = " + item.Id + " ";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(updateStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_BRAND_NAME, item.Name));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_BRAND_DESCRIPTION, item.Description));
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

        public void DeleteData(Brand item)
        {
            var deleteStmt = "DELETE FROM " + TABLE_BRAND + " WHERE " + COLUMN_BRAND_ID + " = " + item.Id + " ";

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
            string createStmt = "CREATE TABLE " + TABLE_BRAND 
                    + "(" + COLUMN_BRAND_ID + " INTEGER PRIMARY KEY, "
                    + COLUMN_BRAND_NAME + " TEXT UNIQUE NOT NULL, "
                    + COLUMN_BRAND_DESCRIPTION + " TEXT DEFAULT '')";

            SQLiteCommand sQLiteCommand = new SQLiteCommand(createStmt, mSQLiteConnection);
            OpenConnection();
            sQLiteCommand.ExecuteNonQuery();
            CloseConnection();
        }

    }
}
