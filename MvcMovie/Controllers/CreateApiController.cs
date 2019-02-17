using MvcMovie.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class CreateApiController : Controller
    {

        private Product product;
        // GET: Sample

        public CreateApiController()
        {
            this.product = new Product();
        }
        public CreateApiController(Product prd)
        {
            this.product = prd;
        }

        public string Index()
        {
            product.Name = "Apple";
            product.ExpiryDate = new DateTime(2008, 12, 28);
            product.Price = 56;
            product.Sizes = new string[] { "Small", "Medium", "Large" };

            string output = JsonConvert.SerializeObject(product);

            return output;
        }


    }

}