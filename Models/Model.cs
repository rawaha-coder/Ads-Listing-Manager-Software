﻿using System;
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
        double quantity;
        string description;
        char grade;
        Brand brand = new Brand();

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public string Description { get => description; set => description = value; }
        public Brand Brand { get => brand; }
        public char Grade { get => grade; set => grade = value; }
        public double Quantity { get => quantity; set => quantity = value; }
    }
}
