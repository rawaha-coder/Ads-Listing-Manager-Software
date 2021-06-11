using Ads_Listing_Manager_Software.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ads_Listing_Manager_Software.Database
{
    class ProductDAO : DAO, IDatabaseCRUD<Product>
    {
        public const string TABLE_PRODUCT = "Products";
        public const string COLUMN_PRODUCT_ID = "ProductId";
        public const string COLUMN_PRODUCT_NAME = "ProductName";
        public const string COLUMN_PRODUCT_PRICE = "ProductPrice";
        public const string COLUMN_PRODUCT_MODEL = "ProductModel";
        public const string COLUMN_PRODUCT_TYPE = "ProductType";
        public const string COLUMN_PRODUCT_DESCRIPTION = "ProductDescription";

        private static ProductDAO instance = null;

        private ProductDAO() : base() { }

        public static ProductDAO getInstance()
        {
            if (instance == null)
                instance = new ProductDAO();
            return instance;
        }

        public List<Product> getProductsByModelComponentId(int ModelId, int ComponentId)
        {
            List<Product> list = new List<Product>();
            var selectStmt = "SELECT * FROM " + TABLE_PRODUCT 
                + " WHERE  " + COLUMN_PRODUCT_MODEL + " = " + ModelId 
                + " AND " + COLUMN_PRODUCT_TYPE + " = " + ComponentId 
                + " ORDER BY " + COLUMN_PRODUCT_NAME + " ASC;";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        Product item = new Product();
                        item.Id = result.GetInt32(result.GetOrdinal(COLUMN_PRODUCT_ID));
                        item.Name = result.GetString(result.GetOrdinal(COLUMN_PRODUCT_NAME));
                        item.Price = result.GetDouble(result.GetOrdinal(COLUMN_PRODUCT_PRICE));
                        item.Description = result.GetString(result.GetOrdinal(COLUMN_PRODUCT_DESCRIPTION));
                        item.Model.Id = result.GetInt32(result.GetOrdinal(COLUMN_PRODUCT_MODEL));
                        item.Type.Id = result.GetInt32(result.GetOrdinal(COLUMN_PRODUCT_TYPE));
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

        public void AddData(Product item)
        {
            string insertStmt = "INSERT INTO " + TABLE_PRODUCT + " ("
                                + COLUMN_PRODUCT_NAME + ", "
                                + COLUMN_PRODUCT_PRICE + ", "
                                + COLUMN_PRODUCT_MODEL + ", "
                                + COLUMN_PRODUCT_TYPE + ", "
                                + COLUMN_PRODUCT_DESCRIPTION
                                + ") VALUES ("
                                + "@" + COLUMN_PRODUCT_NAME + ", "
                                + "@" + COLUMN_PRODUCT_PRICE + ", "
                                + "@" + COLUMN_PRODUCT_MODEL + ", "
                                + "@" + COLUMN_PRODUCT_TYPE + ", "
                                + "@" + COLUMN_PRODUCT_DESCRIPTION
                                + ")";
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(insertStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.AddWithValue(COLUMN_PRODUCT_NAME, item.Name);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_PRODUCT_PRICE, item.Price);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_PRODUCT_MODEL, item.Model.Id);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_PRODUCT_TYPE, item.Type.Id);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_PRODUCT_DESCRIPTION, item.Description);
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

        public void DeleteData(Product item)
        {
            var deleteStmt = "DELETE FROM " + TABLE_PRODUCT + " WHERE " + COLUMN_PRODUCT_ID + " = " + item.Id + " ";

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

        public List<Product> GetData()
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Product item)
        {
            var updateStmt = "UPDATE " + TABLE_PRODUCT + " SET "
                            + COLUMN_PRODUCT_NAME + " =@" + COLUMN_PRODUCT_NAME + ", "
                            + COLUMN_PRODUCT_PRICE + " =@" + COLUMN_PRODUCT_PRICE + ", "
                            + COLUMN_PRODUCT_MODEL + " =@" + COLUMN_PRODUCT_MODEL + ", "
                            + COLUMN_PRODUCT_TYPE + " =@" + COLUMN_PRODUCT_TYPE + ", "
                            + COLUMN_PRODUCT_DESCRIPTION + " =@" + COLUMN_PRODUCT_DESCRIPTION + " "
                            + " WHERE " + COLUMN_PRODUCT_ID + " = " + item.Id + " ";
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(updateStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_PRODUCT_NAME, item.Name));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_PRODUCT_PRICE, item.Price));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_PRODUCT_MODEL, item.Model.Id));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_PRODUCT_TYPE, item.Type.Id));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_PRODUCT_DESCRIPTION, item.Description));

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
                    + COLUMN_PRODUCT_NAME + " TEXT UNIQUE NOT NULL, "
                    + COLUMN_PRODUCT_PRICE + " REAL NOT NULL, "
                    + COLUMN_PRODUCT_MODEL + " INTEGER NOT NULL, "
                    + COLUMN_PRODUCT_TYPE + " TINTEGER NOT NULL, "
                    + COLUMN_PRODUCT_DESCRIPTION + " TEXT DEFAULT '')";

            SQLiteCommand sQLiteCommand = new SQLiteCommand(createStmt, mSQLiteConnection);
            OpenConnection();
            sQLiteCommand.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
