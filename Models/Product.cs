using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetCoreAssignment.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ImageUrl { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string ProductOwnerID { get; set; }

    }
}
