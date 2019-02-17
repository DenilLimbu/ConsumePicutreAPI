using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMovie.Models
{
    public class Product
    {
        public string Name { get; set; }
        public DateTime ExpiryDate { get; set;}
        public int Price { get; set; }

        public string[] Sizes { get; set; }
    }
}