using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ads_Listing_Manager_Software.Models
{
    class Item
    {
        int id;
        string name;
        string code;
        double price;
        int quantity;
        int type;
        string description;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Code { get => code; set => code = value; }
        public double Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Type { get => type; set => type = value; }
        public string Description { get => description; set => description = value; }
    }
}
