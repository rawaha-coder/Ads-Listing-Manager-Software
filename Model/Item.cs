using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ads_Listing_Manager_Software.Model
{
    class Item
    {
        int id;
        string name;
        double price;
        Type type;
        Model model;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        internal Type Type { get => type; set => type = value; }
        internal Model Model { get => model; set => model = value; }
    }
}
