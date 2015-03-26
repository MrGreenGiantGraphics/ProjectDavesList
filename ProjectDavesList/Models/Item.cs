using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectDavesList.Models
{
    public class Item : Details
    {             

        public int Id { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public itemTypes Type { get; set; }
    }

    public enum itemTypes
    {
        Housing,
        Furniture,
        Automobiles,
        Toys,
        Electronics,
        Services 
    }
}