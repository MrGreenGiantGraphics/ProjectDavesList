using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectDavesList.Models
{
    public static class ItemHolder
    {
        public static List<Item> GetItem()
        {
            List<Item> iList = new List<Item>()
            {
               new Item(){Type = itemTypes.Housing, Id = 100, Description = "House 2 bed room Apartment", Price = 1200, City = "Pearland", State = "Texas", CreatedBy = "Sue Smith", DateCreated=DateTime.Now.AddDays(-1),ImageSize = "/images/img01.jpg"},
                new Item(){Type = itemTypes.Housing, Id = 101, Description = "House 5 bed room House", Price = 250000, City = "Austin", State = "Texas", CreatedBy = "David Crooker", DateCreated=DateTime.Now.AddDays(-2),ImageSize = "/images/img02.jpg"},
                new Item(){Type = itemTypes.Housing, Id = 102, Description = "House 2 bed room Loft", Price = 1100, City = "Dallas", State = "Texas", CreatedBy = "Larry Holms", DateCreated=DateTime.Now.AddDays(-3),ImageSize = "/images/img03.jpg"},
                new Item(){Type = itemTypes.Housing, Id = 103, Description = "House 1 bed room Studio", Price = 800, City = "Atlanta", State = "Georgia", CreatedBy = "Tammy Love", DateCreated=DateTime.Now.AddDays(-2),ImageSize = "/images/img04.jpg"},
                new Item(){Type = itemTypes.Housing, Id = 104, Description = "House 2 bed room Apartment", Price = 1200, City = "Allentown", State = "Pennsylvania", CreatedBy = "Jimmy Candor", DateCreated=DateTime.Now.AddDays(-1),ImageSize = "/images/img05.jpg"},
                new Item(){Type = itemTypes.Furniture, Id = 200, Description = "Furniture Antique Chair", Price = 250, City = "Pearland", State = "Texas", CreatedBy = "Hank Williams", DateCreated=DateTime.Now.AddDays(-1),ImageSize = "/images/img06.jpg"},
                new Item(){Type = itemTypes.Furniture, Id = 201, Description = "Furniture Sofa Bed seats four", Price = 300, City = "Austin", State = "Texas", CreatedBy = "Kelly Davis", DateCreated=DateTime.Now.AddDays(-2),ImageSize = "/images/img07.jpg"},
                new Item(){Type = itemTypes.Furniture, Id = 202, Description = "Furniture Love seat", Price = 50, City = "Dallas", State = "Texas", CreatedBy = "Bill Thomas", DateCreated=DateTime.Now.AddDays(-3),ImageSize = "/images/img08.jpg"},
                new Item(){Type = itemTypes.Furniture, Id = 203, Description = "Furniture Antique Mahogany Chair", Price = 400, City = "Atlanta", State = "Georgia", CreatedBy = "Charles Love", DateCreated=DateTime.Now.AddDays(-2),ImageSize = "/images/img09.jpg"},
                new Item(){Type = itemTypes.Furniture, Id = 204, Description = "Furniture 4 table chairs plastic", Price = 25, City = "Allentown", State = "Pennsylvania", CreatedBy = "Nelly Vainly", DateCreated=DateTime.Now.AddDays(-1),ImageSize = "/images/img10.jpg"},    
                new Item(){Type = itemTypes.Toys, Id = 300, Description = "Toys Power Ranger Action Figures", Price = 20, City = "Pearland", State = "Texas", CreatedBy = "Sam Williams", DateCreated=DateTime.Now.AddDays(-1),ImageSize = "/images/img11.jpg"},
                new Item(){Type = itemTypes.Toys, Id = 301, Description = "Toys Transformers Collection", Price = 40, City = "Austin", State = "Texas", CreatedBy = "Chuck Davis", DateCreated=DateTime.Now.AddDays(-2),ImageSize = "/images/img12.jpg"},
                new Item(){Type = itemTypes.Toys, Id = 302, Description = "Toys Monopoly Board Game", Price = 25, City = "Memphis", State = "Tennessee", CreatedBy = "Bill Calm", DateCreated=DateTime.Now.AddDays(-3),ImageSize = "/images/img13.jpg"},
                new Item(){Type = itemTypes.Toys, Id = 303, Description = "Toys Rat Race Board Game", Price = 150, City = "Atlanta", State = "Georgia", CreatedBy = "Charles Love", DateCreated=DateTime.Now.AddDays(-2),ImageSize = "/images/img14.jpg"},
                new Item(){Type = itemTypes.Toys, Id = 304, Description = "Toys Wooden Chess Set", Price = 85, City = "Philadelphia", State = "Pennsylvania", CreatedBy = "Mike Jennings", DateCreated=DateTime.Now.AddDays(-1),ImageSize = "/images/img15.jpg"}, 
                new Item(){Type = itemTypes.Electronics, Id = 400, Description = "Electronics iPod 24G white", Price = 300, City = "Pearland", State = "Texas", CreatedBy = "Kato Williams", DateCreated=DateTime.Now.AddDays(-1),ImageSize = "/images/img16.jpg"},
                new Item(){Type = itemTypes.Electronics, Id = 401, Description = "Electronics iPod 32G Black", Price = 350, City = "Austin", State = "Texas", CreatedBy = "Chuck Winkled", DateCreated=DateTime.Now.AddDays(-2),ImageSize = "/images/img17.jpg"},
                new Item(){Type = itemTypes.Electronics, Id = 402, Description = "Electronics Laptop Asus i7 Windows 7", Price = 1500, City = "Memphis", State = "Tennessee", CreatedBy = "Bill Stew", DateCreated=DateTime.Now.AddDays(-3),ImageSize = "/images/img18.jpg"},
                new Item(){Type = itemTypes.Electronics, Id = 403, Description = "Electronics Laptop Asus i6 Windows 8", Price = 1300, City = "Atlanta", State = "Georgia", CreatedBy = "Professor Griff", DateCreated=DateTime.Now.AddDays(-2),ImageSize = "/images/img19.jpg"},
                new Item(){Type = itemTypes.Electronics, Id = 404, Description = "Electronics Laptop HP i5 Windows 7", Price = 1000, City = "East StroudsBurg", State = "Pennsylvania", CreatedBy = "Chuck D", DateCreated=DateTime.Now.AddDays(-1),ImageSize = "/images/img20.jpg"}, 
                new Item(){Type = itemTypes.Automobiles, Id = 500, Description = "Auto 2014 BRZ Blue", Price = 18000, City = "Pearland", State = "Texas", CreatedBy = "Tammy Williams", DateCreated=DateTime.Now.AddDays(-1),ImageSize ="/images/img21.jpg"},
                new Item(){Type = itemTypes.Automobiles, Id = 501, Description = "Auto 1999 Toyota Celica Silver", Price = 2500, City = "Austin", State = "Texas", CreatedBy = "Chuck Willis", DateCreated=DateTime.Now.AddDays(-2),ImageSize = "/images/img22.jpg"},
                new Item(){Type = itemTypes.Automobiles, Id = 502, Description = "Auto 2011 Toyota Celica Black", Price = 25000, City = "Memphis", State = "Tennessee", CreatedBy = "Hank Louis", DateCreated=DateTime.Now.AddDays(-3),ImageSize = "/images/img23.jpg"},
                new Item(){Type = itemTypes.Automobiles, Id = 503, Description = "Auto 2015 Honda Accord Green", Price = 22000, City = "Atlanta", State = "Georgia", CreatedBy = "Charles Barclay", DateCreated=DateTime.Now.AddDays(-2),ImageSize = "/images/img24.jpg"},
                new Item(){Type = itemTypes.Automobiles, Id = 504, Description = "Auto 1985 Honda Accord Blue", Price = 1300, City = "East StroudsBurg", State = "Pennsylvania", CreatedBy = "Willy Lynches", DateCreated=DateTime.Now.AddDays(-1),ImageSize = "/images/img25.jpg"}, 
                new Item(){Type = itemTypes.Services, Id = 600, Description = "Services House Cleaning", Price = 100, City = "Pearland", State = "Texas", CreatedBy = "Top Maids ", DateCreated=DateTime.Now.AddDays(-1),ImageSize = "/images/img26.jpg"},
                new Item(){Type = itemTypes.Services, Id = 601, Description = "Services Car Detailing", Price = 250, City = "Austin", State = "Texas", CreatedBy = "Fast and Furious", DateCreated=DateTime.Now.AddDays(-2),ImageSize = "/images/img27.jpg"},
                new Item(){Type = itemTypes.Services, Id = 602, Description = "Services Tax Prepare", Price = 150, City = "Memphis", State = "Tennessee", CreatedBy = "Hank Jimmy", DateCreated=DateTime.Now.AddDays(-3),ImageSize = "/images/img28.jpg"},
                new Item(){Type = itemTypes.Services, Id = 603, Description = "Services Taxi and Shuttle", Price = 5, City = "Atlanta", State = "Georgia", CreatedBy = "We Drive You", DateCreated=DateTime.Now.AddDays(-2),ImageSize = "/images/img29.jpg"},
                new Item(){Type = itemTypes.Services, Id = 604, Description = "Services Taxi and Shuttle", Price = 5, City = "Houston", State = "Texas", CreatedBy = "Downtown Taxi", DateCreated=DateTime.Now.AddDays(-1),ImageSize = "/images/img30.jpg"}, 

            };

            return iList;
        }
    }
}