using Ads_Listing_Manager_Software.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ads_Listing_Manager_Software.Database
{
    class ProfitDAO : DAO
    {
        public const string TABLE_PROFIT = "Profit";
        public const string COLUMN_PROFIT_MIN_PRICE = "MinPrice";
        public const string COLUMN_PROFIT_MAX_PRICE = "MaxPrice";
        public const string COLUMN_PROFIT_PROFIT = "ProfitRate";


        private static ProfitDAO instance = null;

        private ProfitDAO() : base() { }

        public static ProfitDAO getInstance()
        {
            if (instance == null)
                instance = new ProfitDAO();
            return instance;
        }

        public List<Profit> GetData()
        {
            List<Profit> list = new List<Profit>();
            var selectStmt = "SELECT * FROM " + TABLE_PROFIT + " ORDER BY " + COLUMN_PROFIT_MIN_PRICE + " ASC;";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        Profit item = new Profit
                        {
                            MinPrice = result.GetDouble(result.GetOrdinal(COLUMN_PROFIT_MIN_PRICE)),
                            MaxPrice = result.GetDouble(result.GetOrdinal(COLUMN_PROFIT_MAX_PRICE)),
                            ProfitRate = result.GetDouble(result.GetOrdinal(COLUMN_PROFIT_PROFIT)),
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
    }
}
