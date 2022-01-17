using System;
using System.Collections.Generic;
using System.Text;

namespace Product_ReviewManagement
{
    public class ProductDetails
    {
        // Encapsualtion
        public int productId { get; set; }
        public int userId { get; set; }
        public int rating { get; set; }
        public string review { get; set; }
        public bool isLike { get; set; }
    }
}
