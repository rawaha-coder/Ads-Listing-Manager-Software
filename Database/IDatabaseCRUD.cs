using System.Collections.Generic;

namespace Ads_Listing_Manager_Software.Database
{
    internal interface IDatabaseCRUD<T>
    {
        public void AddData(T t);
        public void UpdateData(T t);
        public void DeleteData(T t);
        public List<T> GetData();
    }
}