using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ads_Listing_Manager_Software.Model
{
    class Model
    {
        int id;
        string name;
        double price;
        Brand brand;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        internal Brand Brand { get => brand; set => brand = value; }
    }
}
