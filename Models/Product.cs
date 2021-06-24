using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ads_Listing_Manager_Software.Models
{
    class Product
    {
        int id;
        Item item;
        Component type;
        Model model;


        public Product()
        {
            Item = new Item();
            type = new Component();
            model = new Model();
        }

        public int Id { get => id; set => id = value; }
        internal Component Type { get => type; set => type = value; }
        internal Model Model { get => model; set => model = value; }
        internal Item Item { get => item; set => item = value; }
    }
}
