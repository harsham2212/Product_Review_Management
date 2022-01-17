using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;

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

        // Retriving Top 3 data
        public static void SelectTopRatingsRecords(List<ProductDetails> list)
        {
            var records = (from product in list orderby product.rating descending select product).Take(3);
            foreach (ProductDetails product in records)
            {
                Console.WriteLine("ProductId : " + product.productId + " UserId : " + product.userId + " Rating : " + product.rating + " Review : " + product.review + " IsLike : " + product.isLike);
            }
        }

        // Management - Retrieve all record from the list who’s rating are greater then 3 and productID is 1 or 4 or 9 using LINQ
        public static void SelectRecordsBasedOnProductId(List<ProductDetails> list)
        {
            var records = (list.Where(r => r.rating > 3 && (r.productId == 1 || r.productId == 4 || r.productId == 9))).ToList();
            foreach (ProductDetails product in records)
            {
                Console.WriteLine("ProductId : " + product.productId + " " + " UserId : " + product.userId + " " + " Rating : " + product.rating + " " + " Review : " + product.review + " " + " IsLike : " + product.isLike);
            }
        }
    }
}
