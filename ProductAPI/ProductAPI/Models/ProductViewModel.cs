using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductAPI.Models
{
    public class ProductViewModel
    {
        public ProductViewModel() { }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }
}