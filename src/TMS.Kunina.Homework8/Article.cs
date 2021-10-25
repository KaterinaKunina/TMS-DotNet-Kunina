using System;
namespace TMS.Kunina.Homework8
{
    public class Article
    {
        private int id;
        private string productName;
        private string storeName;
        private double price;  // Price in BYN

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public string StoreName
        {
            get { return storeName; }
            set { storeName = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}


