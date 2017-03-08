﻿
namespace SalesDatabase.Models
{
    using System.Collections.Generic;
    public class StoreLocation
    {
        public StoreLocation()
        {
            SalesInStore = new HashSet<Sale>();
        }
        public int Id { get; set; }
        public string LocationName { get; set; }
        public ICollection<Sale> SalesInStore { get; set; }
    }
}
