using Ads_Listing_Manager_Software.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Ads_Listing_Manager_Software.Database
{
    class ProductDAO : DAO
    {
        public const string TABLE_PRODUCT = "Products";
        public const string COLUMN_PRODUCT_ID = "Id";
        public const string COLUMN_PRODUCT_ITEM = "Item";
        public const string COLUMN_PRODUCT_MODEL = "Model";
        public const string COLUMN_PRODUCT_TYPE = "Type";

        private static ProductDAO instance = null;

        private ProductDAO() : base() { }

        public static ProductDAO getInstance()
        {
            if (instance == null)
                instance = new ProductDAO();
            return instance;
        }

        public List<Product> SelectData()
        {
            var selectStmt = "SELECT * FROM " + TABLE_PRODUCT + " ORDER BY " + COLUMN_PRODUCT_ITEM + " ASC;";
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                return GetProductDataFromResult(result);
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

        public List<Product> getProductsByModelAndType(int ModelId, int ComponentId)
        {
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectCommand(ModelId, ComponentId), mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                return GetProductDataFromResult(result);
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

        private static string selectCommand(int ModelId, int ComponentId)
        {
            return "SELECT "
                + TABLE_PRODUCT + "." + COLUMN_PRODUCT_ID + ", "
                + ItemDAO.TABLE_ITEM + "." + ItemDAO.COLUMN_ITEM_ID + ", "
                + ItemDAO.TABLE_ITEM + "." + ItemDAO.COLUMN_ITEM_NAME + ", "
                + ItemDAO.TABLE_ITEM + "." + ItemDAO.COLUMN_ITEM_CODE + ", "
                + ItemDAO.TABLE_ITEM + "." + ItemDAO.COLUMN_ITEM_PRICE + ", "
                + ItemDAO.TABLE_ITEM + "." + ItemDAO.COLUMN_ITEM_QUANTITY + ", "
                + ItemDAO.TABLE_ITEM + "." + ItemDAO.COLUMN_ITEM_DESCRIPTION + ", "
                + ModelDAO.TABLE_MODEL + "." + ModelDAO.COLUMN_MODEL_ID + ", "
                + ModelDAO.TABLE_MODEL + "." + ModelDAO.COLUMN_MODEL_NAME + ", "
                + ModelDAO.TABLE_MODEL + "." + ModelDAO.COLUMN_MODEL_PRICE + ", "
                + ModelDAO.TABLE_MODEL + "." + ModelDAO.COLUMN_MODEL_DESCRIPTION + ", "
                + ComponentDAO.TABLE_COMPONENT + "." + ComponentDAO.COLUMN_COMPONENT_ID + ", "
                + ComponentDAO.TABLE_COMPONENT + "." + ComponentDAO.COLUMN_COMPONENT_NAME + ", "
                + ComponentDAO.TABLE_COMPONENT + "." + ComponentDAO.COLUMN_COMPONENT_DESCRIPTION + " "
                + " FROM " + TABLE_PRODUCT
                + " LEFT JOIN " + ItemDAO.TABLE_ITEM + " "
                + " ON " + ItemDAO.TABLE_ITEM + "." + ItemDAO.COLUMN_ITEM_ID + " = " + TABLE_PRODUCT + "." + COLUMN_PRODUCT_ITEM
                + " LEFT JOIN " + ModelDAO.TABLE_MODEL + " "
                + " ON " + ModelDAO.TABLE_MODEL + "." + ModelDAO.COLUMN_MODEL_ID + " = " + TABLE_PRODUCT + "." + COLUMN_PRODUCT_MODEL
                + " LEFT JOIN " + ComponentDAO.TABLE_COMPONENT + " "
                + " ON " + ComponentDAO.TABLE_COMPONENT + "." + ComponentDAO.COLUMN_COMPONENT_ID + " = " + TABLE_PRODUCT + "." + COLUMN_PRODUCT_TYPE
                + " WHERE  " + COLUMN_PRODUCT_MODEL + " = " + ModelId
                + " AND " + TABLE_PRODUCT + "." + COLUMN_PRODUCT_TYPE + " = " + ComponentId
                + " ORDER BY " + COLUMN_PRODUCT_ITEM + " ASC;";
        }

        private List<Product> GetProductDataFromResult(SQLiteDataReader result)
        {
            List<Product> list = new List<Product>();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    Product item = new Product();
                    item.Id = result.GetInt32(result.GetOrdinal(COLUMN_PRODUCT_ID));
                    item.Item.Id = result.GetInt32(result.GetOrdinal(ItemDAO.COLUMN_ITEM_ID));
                    item.Item.Name = result.GetString(result.GetOrdinal(ItemDAO.COLUMN_ITEM_NAME));
                    item.Item.Code = result.GetString(result.GetOrdinal(ItemDAO.COLUMN_ITEM_CODE));
                    item.Item.Price = result.GetDouble(result.GetOrdinal(ItemDAO.COLUMN_ITEM_PRICE));
                    item.Item.Quantity = result.GetInt32(result.GetOrdinal(ItemDAO.COLUMN_ITEM_QUANTITY));
                    item.Item.Description = result.GetString(result.GetOrdinal(ItemDAO.COLUMN_ITEM_DESCRIPTION));
                    item.Model.Id = result.GetInt32(result.GetOrdinal(ModelDAO.COLUMN_MODEL_ID));
                    item.Model.Name = result.GetString(result.GetOrdinal(ModelDAO.COLUMN_MODEL_NAME));
                    item.Model.Price = result.GetDouble(result.GetOrdinal(ModelDAO.COLUMN_MODEL_PRICE));
                    item.Model.Description = result.GetString(result.GetOrdinal(ModelDAO.COLUMN_MODEL_DESCRIPTION));
                    item.Type.Id = result.GetInt32(result.GetOrdinal(ComponentDAO.COLUMN_COMPONENT_ID));
                    item.Type.Name = result.GetString(result.GetOrdinal(ComponentDAO.COLUMN_COMPONENT_NAME));
                    item.Type.Description = result.GetString(result.GetOrdinal(ComponentDAO.COLUMN_COMPONENT_DESCRIPTION));
                    list.Add(item);
                }
            }
            return list;
        }

        internal List<Product> getProductsByModel(int id)
        {
            var selectStmt = "SELECT "
                + TABLE_PRODUCT + "." + COLUMN_PRODUCT_ID + ", "
                + ItemDAO.TABLE_ITEM + "." + ItemDAO.COLUMN_ITEM_ID + ", "
                + ItemDAO.TABLE_ITEM + "." + ItemDAO.COLUMN_ITEM_NAME + ", "
                + ItemDAO.TABLE_ITEM + "." + ItemDAO.COLUMN_ITEM_CODE + ", "
                + ItemDAO.TABLE_ITEM + "." + ItemDAO.COLUMN_ITEM_PRICE + ", "
                + ItemDAO.TABLE_ITEM + "." + ItemDAO.COLUMN_ITEM_QUANTITY + ", "
                + ItemDAO.TABLE_ITEM + "." + ItemDAO.COLUMN_ITEM_DESCRIPTION + ", "
                + ModelDAO.TABLE_MODEL + "." + ModelDAO.COLUMN_MODEL_ID + ", "
                + ModelDAO.TABLE_MODEL + "." + ModelDAO.COLUMN_MODEL_NAME + ", "
                + ModelDAO.TABLE_MODEL + "." + ModelDAO.COLUMN_MODEL_PRICE + ", "
                + ModelDAO.TABLE_MODEL + "." + ModelDAO.COLUMN_MODEL_DESCRIPTION + ", "
                + ComponentDAO.TABLE_COMPONENT + "." + ComponentDAO.COLUMN_COMPONENT_ID + ", "
                + ComponentDAO.TABLE_COMPONENT + "." + ComponentDAO.COLUMN_COMPONENT_NAME + ", "
                + ComponentDAO.TABLE_COMPONENT + "." + ComponentDAO.COLUMN_COMPONENT_DESCRIPTION + " "
                + " FROM " + TABLE_PRODUCT
                + " LEFT JOIN " + ItemDAO.TABLE_ITEM + " "
                + " ON " + ItemDAO.TABLE_ITEM + "." + ItemDAO.COLUMN_ITEM_ID + " = " + TABLE_PRODUCT + "." + COLUMN_PRODUCT_ITEM
                + " LEFT JOIN " + ModelDAO.TABLE_MODEL + " "
                + " ON " + ModelDAO.TABLE_MODEL + "." + ModelDAO.COLUMN_MODEL_ID + " = " + TABLE_PRODUCT + "." + COLUMN_PRODUCT_MODEL
                + " LEFT JOIN " + ComponentDAO.TABLE_COMPONENT + " "
                + " ON " + ComponentDAO.TABLE_COMPONENT + "." + ComponentDAO.COLUMN_COMPONENT_ID + " = " + TABLE_PRODUCT + "." + COLUMN_PRODUCT_TYPE
                + " WHERE  " + COLUMN_PRODUCT_MODEL + " = " + id 
                + " ORDER BY " + COLUMN_PRODUCT_ITEM + " ASC";
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                return GetProductDataFromResult(result);
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

        internal List<Product> getProductsByType(int id)
        {
            var selectStmt = "SELECT "
                + TABLE_PRODUCT + "." + COLUMN_PRODUCT_ID + ", "
                + ItemDAO.TABLE_ITEM + "." + ItemDAO.COLUMN_ITEM_ID + ", "
                + ItemDAO.TABLE_ITEM + "." + ItemDAO.COLUMN_ITEM_NAME + ", "
                + ItemDAO.TABLE_ITEM + "." + ItemDAO.COLUMN_ITEM_CODE + ", "
                + ItemDAO.TABLE_ITEM + "." + ItemDAO.COLUMN_ITEM_PRICE + ", "
                + ItemDAO.TABLE_ITEM + "." + ItemDAO.COLUMN_ITEM_QUANTITY + ", "
                + ItemDAO.TABLE_ITEM + "." + ItemDAO.COLUMN_ITEM_DESCRIPTION + ", "
                + ModelDAO.TABLE_MODEL + "." + ModelDAO.COLUMN_MODEL_ID + ", "
                + ModelDAO.TABLE_MODEL + "." + ModelDAO.COLUMN_MODEL_NAME + ", "
                + ModelDAO.TABLE_MODEL + "." + ModelDAO.COLUMN_MODEL_PRICE + ", "
                + ModelDAO.TABLE_MODEL + "." + ModelDAO.COLUMN_MODEL_DESCRIPTION + ", "
                + ComponentDAO.TABLE_COMPONENT + "." + ComponentDAO.COLUMN_COMPONENT_ID + ", "
                + ComponentDAO.TABLE_COMPONENT + "." + ComponentDAO.COLUMN_COMPONENT_NAME + ", "
                + ComponentDAO.TABLE_COMPONENT + "." + ComponentDAO.COLUMN_COMPONENT_DESCRIPTION + " "
                + " FROM " + TABLE_PRODUCT
                + " LEFT JOIN " + ItemDAO.TABLE_ITEM + " "
                + " ON " + ItemDAO.TABLE_ITEM + "." + ItemDAO.COLUMN_ITEM_ID + " = " + TABLE_PRODUCT + "." + COLUMN_PRODUCT_ITEM
                + " LEFT JOIN " + ModelDAO.TABLE_MODEL + " "
                + " ON " + ModelDAO.TABLE_MODEL + "." + ModelDAO.COLUMN_MODEL_ID + " = " + TABLE_PRODUCT + "." + COLUMN_PRODUCT_MODEL
                + " LEFT JOIN " + ComponentDAO.TABLE_COMPONENT + " "
                + " ON " + ComponentDAO.TABLE_COMPONENT + "." + ComponentDAO.COLUMN_COMPONENT_ID + " = " + TABLE_PRODUCT + "." + COLUMN_PRODUCT_TYPE
                + " WHERE  " + TABLE_PRODUCT + "." + COLUMN_PRODUCT_TYPE + " = " + id
                + " ORDER BY " + COLUMN_PRODUCT_ITEM + " ASC";
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                return GetProductDataFromResult(result);
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

        public void AddData(Product item)
        {
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(insertCommand(), mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.AddWithValue(COLUMN_PRODUCT_ITEM, item.Item.Id);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_PRODUCT_MODEL, item.Model.Id);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_PRODUCT_TYPE, item.Type.Id);
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

        private string insertCommand()
        {
            return "INSERT INTO " + TABLE_PRODUCT + " ("
                                + COLUMN_PRODUCT_ITEM + ", "
                                + COLUMN_PRODUCT_MODEL + ", "
                                + COLUMN_PRODUCT_TYPE + " "
                                + ") VALUES ("
                                + "@" + COLUMN_PRODUCT_ITEM + ", "
                                + "@" + COLUMN_PRODUCT_MODEL + ", "
                                + "@" + COLUMN_PRODUCT_TYPE + " "
                                + ")";
        }

        public void AddProduct(int modelId, int itemId, int typeId)
        {
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(insertCommand(), mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.AddWithValue(COLUMN_PRODUCT_ITEM, itemId);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_PRODUCT_MODEL, modelId);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_PRODUCT_TYPE, typeId);
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

        public void UpdateData(Product item)
        {
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(updateCommad(item), mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_PRODUCT_ITEM, item.Item.Id));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_PRODUCT_MODEL, item.Model.Id));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_PRODUCT_TYPE, item.Type.Id));
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

        private string updateCommad(Product item)
        {
            return "UPDATE " + TABLE_PRODUCT + " SET "
                                        + COLUMN_PRODUCT_ITEM + " =@" + COLUMN_PRODUCT_ITEM + ", "
                                        + COLUMN_PRODUCT_MODEL + " =@" + COLUMN_PRODUCT_MODEL + ", "
                                        + COLUMN_PRODUCT_TYPE + " =@" + COLUMN_PRODUCT_TYPE + " "
                                        + " WHERE " + COLUMN_PRODUCT_ID + " = " + item.Id + " ";
        }

        public void DeleteData(int id)
        {
            var deleteStmt = "DELETE FROM " + TABLE_PRODUCT + " WHERE " + COLUMN_PRODUCT_ID + " = " + id + " ";

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
            string createStmt = "CREATE TABLE " + TABLE_PRODUCT
                    + "(" + COLUMN_PRODUCT_ID + " INTEGER PRIMARY KEY, "
                    + COLUMN_PRODUCT_ITEM + " INTEGER NOT NULL, "
                    + COLUMN_PRODUCT_MODEL + " INTEGER NOT NULL, "
                    + COLUMN_PRODUCT_TYPE + " TINTEGER NOT NULL, "
                    + " FOREIGN KEY (" + COLUMN_PRODUCT_ITEM + ") REFERENCES " + ItemDAO.TABLE_ITEM + " (" + ItemDAO.COLUMN_ITEM_ID + ")"
                    + " FOREIGN KEY (" + COLUMN_PRODUCT_MODEL + ") REFERENCES " + ModelDAO.TABLE_MODEL + " (" + ModelDAO.COLUMN_MODEL_ID + ")"
                    + " FOREIGN KEY (" + COLUMN_PRODUCT_TYPE + ") REFERENCES " + ComponentDAO.TABLE_COMPONENT + " (" + ComponentDAO.COLUMN_COMPONENT_ID + ")"
                    + ")";

            SQLiteCommand sQLiteCommand = new SQLiteCommand(createStmt, mSQLiteConnection);
            OpenConnection();
            sQLiteCommand.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
