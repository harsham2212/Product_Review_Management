using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;

namespace Product_ReviewManagement
{
   public class Management
    {
        DataTable dataTable = new DataTable();
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

        // Retrieve all record from the list who’s rating are greater then 3 and productID is 1 or 4 or 9 using LINQ
        public static void SelectRecordsBasedOnProductId(List<ProductDetails> list)
        {
            var records = (list.Where(r => r.rating > 3 && (r.productId == 1 || r.productId == 4 || r.productId == 9))).ToList();
            foreach (ProductDetails product in records)
            {
                Console.WriteLine("ProductId : " + product.productId + " " + " UserId : " + product.userId + " " + " Rating : " + product.rating + " " + " Review : " + product.review + " " + " IsLike : " + product.isLike);
            }
        }

        // Retrieve count of review present for each productID
        public static void CountingProductId(List<ProductDetails> list)
        {
            var records = list.GroupBy(p => p.productId).Select(x => new { productId = x.Key, count = x.Count() });
            foreach (var item in records)
            {
                Console.WriteLine("ProductId : " + item.productId + " " + "Count:" + item.count);
            }
        }
        

        // Retrieve only productId and review from the list for all records
        public static void RetriveProductIdAndReviw(List<ProductDetails> list)
        {
            var record = list.Select(product => new { ProductId = product.productId, Review = product.review }).ToList();
            foreach (var item in record)
            {
                Console.WriteLine("ProductId : " + item.ProductId + " " + "Review:" + item.Review);
            }
        }

        //skip top 5 records from the list using LINQ and display other records
        public static void SkipTopRatingsRecords(List<ProductDetails> list)
        {
            var records = (from product in list orderby product.rating descending select product).Skip(5);
            foreach (ProductDetails product in records)
            {
                Console.WriteLine("ProductId : " + product.productId + " " + " UserId : " + product.userId + " " + " Rating : " + product.rating + " " + " Review : " + product.review + " " + " IsLike : " + product.isLike);
            }
        }

        //Create DataTable using C# and Add ProductID, UserID, Rating, Review and isLike fields in that.
        public void ProductReviewDataTable(List<ProductDetails> list)
        {
            dataTable.Columns.Add("ProductId").DataType = typeof(Int32);
            dataTable.Columns.Add("UserId").DataType = typeof(Int32);
            dataTable.Columns.Add("Rating").DataType = typeof(int);
            dataTable.Columns.Add("Review");
            dataTable.Columns.Add("IsLike").DataType = typeof(bool);
            foreach (var item in list)
            {
                dataTable.Rows.Add(item.productId, item.userId, item.rating, item.review, item.isLike);
            }
            var productTable = from products in dataTable.AsEnumerable() select products;
            foreach (DataRow product in productTable)
            {
                Console.WriteLine(product.Field<int>("ProductId") + " " + product.Field<int>("UserID") + " " +
                  product.Field<int>("Rating") + " " + product.Field<string>("Review") + " " + product.Field<bool>("IsLike"));
            }
        }

        //Retrieve all the records from the datatable variable who’s isLike value is true using LINQ
        public void RetriveRecordsFromDataTable()
        {
            var productTable = from products in this.dataTable.AsEnumerable()
                               where products.Field<bool>("IsLike").Equals(true)
                               select products;
            foreach (DataRow product in productTable)
            {
                Console.WriteLine(product.Field<int>("ProductId") + " " + product.Field<int>("UserID") + " " +
                  product.Field<int>("Rating") + " " + product.Field<string>("Review") + " " + product.Field<bool>("IsLike"));
            }
        }

        //Find average rating of the each productId using LINQ
        public static void AveragePerProductId(List<ProductDetails> review)
        {
            var recordData = review.GroupBy(x => x.productId).Select(x => new { productId = x.Key, AverageRating = x.Average(x => x.rating) });
            foreach (var list in recordData)
            {
                Console.WriteLine(list.productId + "-" + list.AverageRating);
            }
        }

        //Retreive all records from the list who’s review message contain “nice”.
        public static void RetreiveProductIdAndReview(List<ProductDetails> review, string reviewMessage)
        {
            var recordData = from productReviews in review where productReviews.review.Contains(reviewMessage) select productReviews;
        }
    }
}
