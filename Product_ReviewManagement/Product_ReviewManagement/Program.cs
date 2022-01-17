using System;
using System.Collections.Generic;

namespace Product_ReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management Problems Statement! \n ");
            ProductDetails product = new ProductDetails();
            List<ProductDetails> list = new List<ProductDetails>()

            {
                new ProductDetails(){productId=1, userId=1, rating=5, review="Good", isLike=true},
                new ProductDetails(){productId=2, userId=2, rating=4, review="Nice", isLike=true},
                new ProductDetails(){productId=3, userId=3, rating=3, review="Average", isLike=true},
                new ProductDetails(){productId=4, userId=4, rating=5, review="Good", isLike=true},
                new ProductDetails(){productId=5, userId=5, rating=3, review="Average", isLike=true},
                new ProductDetails(){productId=6, userId=6, rating=1, review="Poor", isLike=true},
                new ProductDetails(){productId=7, userId=7, rating=5, review="Good", isLike=true},
                new ProductDetails(){productId=8, userId=8, rating=2, review="Average", isLike=true},
                new ProductDetails(){productId=9, userId=9, rating=5, review="Good", isLike=true},
                new ProductDetails(){productId=10, userId=10, rating=4, review="Nice", isLike=true},
                new ProductDetails(){productId=11, userId=11, rating=2, review="Bad", isLike=false},
                new ProductDetails(){productId=12, userId=12, rating=3, review="Average", isLike=true},
                new ProductDetails(){productId=13, userId=13, rating=5, review="Good", isLike=true},
                new ProductDetails(){productId=14, userId=14, rating=2, review="Average", isLike=true},
                new ProductDetails(){productId=15, userId=15, rating=1, review="Poor", isLike=true},
                new ProductDetails(){productId=16, userId=16, rating=4, review="Nice", isLike=true},
                new ProductDetails(){productId=17, userId=17, rating=5, review="Good", isLike=true},
                new ProductDetails(){productId=18, userId=18, rating=4, review="Nice", isLike=true},
                new ProductDetails(){productId=19, userId=19, rating=5, review="Good", isLike=true},
                new ProductDetails(){productId=20, userId=20, rating=2, review="Average", isLike=true},
                new ProductDetails(){productId=21, userId=21, rating=5, review="Good", isLike=true},
                new ProductDetails(){productId=22, userId=22, rating=4, review="Nice", isLike=true},
                new ProductDetails(){productId=23, userId=23, rating=1, review="Poor", isLike=true},
                new ProductDetails(){productId=24, userId=24, rating=3, review="bad", isLike=true},
                new ProductDetails(){productId=25, userId=25, rating=5, review="Good", isLike=true}
            };
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your Choice Number to Execute the Program Press:\n 1.Display Data\n 2.Retrive Data\n 3.Display Data Based on Product Id\n 4.Count Product Id\n 5.Retreive by ProductId and Review\n 6.Skip top 5 record\n 7.Data Table\n 8.Retrieve records from DataTable who's islike value TRUE\n 9.Average of Records\n 10.Retreive records from the list who’s review message contain 'nice'\n 11.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Management.Display(list);
                        break;
                    case 2:
                        Management.SelectTopRatingsRecords(list);
                        break;
                    case 3:
                        Management.SelectRecordsBasedOnProductId(list);
                        break;
                    case 4:
                        Management.CountingProductId(list);
                        break;
                    case 5:
                        Management.RetriveProductIdAndReviw(list);
                        break;
                    case 6:
                        Management.SkipTopRatingsRecords(list);
                        break;
                    case 7:
                        Management Operation = new Management();
                        Operation.ProductReviewDataTable(list);
                        break;
                    case 8:
                        Management retrive = new Management();
                        retrive.RetriveRecordsFromDataTable();
                        break;
                    case 9:
                        Management.AveragePerProductId(list);
                        break;
                    case 10:
                        Management.RetreiveProductIdAndReview(list, "nice");
                        break;
                    case 11:
                        flag = false;
                        break;
                }
            }
        }
    }
}
