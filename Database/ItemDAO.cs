using Ads_Listing_Manager_Software.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ads_Listing_Manager_Software.Database
{
    class ItemDAO : DAO, DatabaseCRUD<Item>
    {
        public const string TABLE_ITEM = "Items";
        public const string COLUMN_ITEM_ID = "Id";
        public const string COLUMN_ITEM_NAME = "Name";
        public const string COLUMN_ITEM_CODE = "Code";
        public const string COLUMN_ITEM_PRICE = "Price";
        public const string COLUMN_ITEM_QUANTITY = "Quantity";
        public const string COLUMN_ITEM_TYPE = "Type";
        public const string COLUMN_ITEM_DESCRIPTION = "Description";

        private static ItemDAO instance = null;

        private ItemDAO() : base() { }

        internal static ItemDAO getInstance()
        {
            if (instance == null)
                instance = new ItemDAO();
            return instance;
        }
        public void AddData(Item item)
        {
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(insertCommand(), mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.AddWithValue(COLUMN_ITEM_NAME, item.Name);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_ITEM_CODE, item.Code);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_ITEM_PRICE, item.Price);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_ITEM_QUANTITY, item.Quantity);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_ITEM_TYPE, item.Type);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_ITEM_DESCRIPTION, item.Description);
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
            return "INSERT INTO " + TABLE_ITEM + " ("
                                + COLUMN_ITEM_NAME + ", "
                                + COLUMN_ITEM_CODE + ", "
                                + COLUMN_ITEM_PRICE + ", "
                                + COLUMN_ITEM_QUANTITY + ", "
                                + COLUMN_ITEM_TYPE + ", "
                                + COLUMN_ITEM_DESCRIPTION
                                + ") VALUES ("
                                + "@" + COLUMN_ITEM_NAME + ", "
                                + "@" + COLUMN_ITEM_CODE + ", "
                                + "@" + COLUMN_ITEM_PRICE + ", "
                                + "@" + COLUMN_ITEM_QUANTITY + ", "
                                + "@" + COLUMN_ITEM_TYPE + ", "
                                + "@" + COLUMN_ITEM_DESCRIPTION
                                + ")";
        }

        public void DeleteData(Item item)
        {
            var deleteItem = "DELETE FROM " + TABLE_ITEM + " WHERE " + COLUMN_ITEM_ID + " = " + item.Id + " ";
            var deleteProduct = "DELETE FROM " + ProductDAO.TABLE_PRODUCT + " WHERE " + ProductDAO.COLUMN_PRODUCT_ITEM + " = " + item.Id + " ";
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(deleteProduct + ";" + deleteItem, mSQLiteConnection);
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

        public List<Item> SelectData()
        {
            string selectStmt = "SELECT * FROM " + TABLE_ITEM + " ORDER BY " + COLUMN_ITEM_NAME + " ASC;";
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                return GetItemDataFromResult(result);
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



        public void UpdateData(Item item)
        {
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(updateCommad(item), mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_ITEM_NAME, item.Name));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_ITEM_CODE, item.Code));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_ITEM_PRICE, item.Price));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_ITEM_QUANTITY, item.Quantity));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_ITEM_TYPE, item.Type));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_ITEM_DESCRIPTION, item.Description));

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

        private string updateCommad(Item item)
        {
            return "UPDATE " + TABLE_ITEM + " SET "
                                        + COLUMN_ITEM_NAME + " =@" + COLUMN_ITEM_NAME + ", "
                                        + COLUMN_ITEM_CODE + " =@" + COLUMN_ITEM_CODE + ", "
                                        + COLUMN_ITEM_PRICE + " =@" + COLUMN_ITEM_PRICE + ", "
                                        + COLUMN_ITEM_QUANTITY + " =@" + COLUMN_ITEM_QUANTITY + ", "
                                        + COLUMN_ITEM_TYPE + " =@" + COLUMN_ITEM_TYPE + ", "
                                        + COLUMN_ITEM_DESCRIPTION + " =@" + COLUMN_ITEM_DESCRIPTION + " "
                                        + " WHERE " + COLUMN_ITEM_ID + " = " + item.Id + " ";
        }

        internal List<Item> getItemsByTypeSortedByName
            (int id)
        {
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectCommandSortedByName(id), mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                return GetItemDataFromResult(result);
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

        private static string selectCommandSortedByName(int ComponentId)
        {
            return "SELECT * FROM " + TABLE_ITEM + " WHERE  " + COLUMN_ITEM_TYPE + " = " + ComponentId + " ORDER BY " + COLUMN_ITEM_NAME + " ASC;";
        }

        internal List<Item> getItemsByType(int id)
        {
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectCommand(id), mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                return GetItemDataFromResult(result);
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

        private static string selectCommand(int ComponentId)
        {
            return "SELECT * FROM " + TABLE_ITEM + " WHERE  " + COLUMN_ITEM_TYPE + " = " + ComponentId + " ORDER BY " + COLUMN_ITEM_PRICE + " ASC;";
        }

        private static List<Item> GetItemDataFromResult(SQLiteDataReader result)
        {
            List<Item> list = new List<Item>();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    Item item = new Item();
                    item.Id = result.GetInt32(result.GetOrdinal(COLUMN_ITEM_ID));
                    item.Name = result.GetString(result.GetOrdinal(COLUMN_ITEM_NAME));
                    item.Code = result.GetString(result.GetOrdinal(COLUMN_ITEM_CODE));
                    item.Price = result.GetDouble(result.GetOrdinal(COLUMN_ITEM_PRICE));
                    item.Quantity = result.GetInt32(result.GetOrdinal(COLUMN_ITEM_QUANTITY));
                    item.Type = result.GetInt32(result.GetOrdinal(COLUMN_ITEM_TYPE));
                    item.Description = result.GetString(result.GetOrdinal(COLUMN_ITEM_DESCRIPTION));
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
