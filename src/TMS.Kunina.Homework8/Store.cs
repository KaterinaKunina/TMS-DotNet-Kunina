using System;
using System.Linq;
using System.Collections.Generic;

namespace TMS.Kunina.Homework8
{
    public class Store
    {
        private static Article[] GetAllArticle()
        {
            Article[] article = {
                new Article() { ID = 1, ProductName = "iPhone8", StoreName = "i-Store", Price = 1450 },
                new Article() { ID = 2, ProductName = "iPhone8", StoreName = "MTS", Price = 1400 },
                new Article() { ID = 3, ProductName = "iPgone11", StoreName = "Mobile", Price = 1750 },
                new Article() { ID = 4, ProductName = "iPgone11", StoreName = "7435", Price = 1744.58 },
                new Article() { ID = 5, ProductName = "iPhone12", StoreName = "TTH", Price = 2380 },
                new Article() { ID = 6, ProductName = "iPgone11", StoreName = "RDK", Price = 1700 },
                new Article() { ID = 7, ProductName = "iPhone8", StoreName = "A1", Price = 1400 },
                new Article() { ID = 8, ProductName = "iPhoneXR", StoreName = "Online", Price = 1470 },
                new Article() { ID = 9, ProductName = "iPhoneXR", StoreName = "i-Store", Price = 1799 },
                new Article() { ID = 10, ProductName = "iPhoneXR", StoreName = "Mobile", Price = 1470 },
                new Article() { ID = 11, ProductName = "iPhone12", StoreName = "Online", Price = 2500 },
                new Article() { ID = 12, ProductName = "iPhone12", StoreName = "Agroup.by", Price = 2478.66 },
                new Article() { ID = 13, ProductName = "iPhone12", StoreName = "i-Store", Price = 2899 },
                new Article() { ID = 14, ProductName = "iPhone13", StoreName = "TTH", Price = 2765 },
                new Article() { ID = 15, ProductName = "iPhone13", StoreName = "Mobile", Price = 2765 },
                new Article() { ID = 16, ProductName = "iPhone13", StoreName = "RDK", Price = 3150 }
            };
            return article;
        }


        public static Dictionary<int, Article> Article_ToDictionary()
        {
            var result = GetAllArticle().ToDictionary(k => k.ID);
            return result;
        }

    }
}
