using System;
using System.Collections.Generic;
using System.Text;

namespace Product_ReviewManagement
{
   public class Management
    {
        public static void Display(List<ProductDetails> list)
        {
            foreach (ProductDetails product in list)
            {
                Console.WriteLine("ProductId:" + product.productId + " " + "UserId:" + product.userId + " " + "Rating:" + product.rating 
                    + " " + "Review:" + product.review + " " + "isLike:" + product.isLike);
            }
        }
    }
}
