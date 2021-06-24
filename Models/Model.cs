using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ads_Listing_Manager_Software.Models
{
    class Model
    {
        int id;
        string name;
        double price;
        int quantity;
        string description;
        string grade;
        Brand brand = new Brand();

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public string Description { get => description; set => description = value; }
        public Brand Brand { get => brand; }
        public string Grade { get => grade; set => grade = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
