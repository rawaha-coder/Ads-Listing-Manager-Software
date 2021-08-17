using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ads_Listing_Manager_Software.Models
{
    class Profit
    {
        double minPrice;
        double maxPrice;
        double profitRate;

        public double MinPrice { get => minPrice; set => minPrice = value; }
        public double MaxPrice { get => maxPrice; set => maxPrice = value; }
        public double ProfitRate { get => profitRate; set => profitRate = value; }
    }
}
