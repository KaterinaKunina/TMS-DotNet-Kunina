using System;
using System.Collections.Generic;
using System.Linq;

namespace TMS.Kunina.Homework8
{
    class Ui
    {
        static void Main(string[] args)
        {
            bool info = true;

            while (info)
            {
                Console.WriteLine("Can you find product by ID or Name of product");
                Console.WriteLine("Select 1 -- find product by ID");
                Console.WriteLine("Select 2 -- find product by Name");
                Console.WriteLine("Select 3 -- exit search");

                string infoIdOrName = Console.ReadLine();
                while (!infoIdOrName.Equals("1") && !infoIdOrName.Equals("2") && !infoIdOrName.Equals("3"))
                {
                    Console.WriteLine("Nothing found! Please enter a valid value. Enter 1, 2 or 3");
                    infoIdOrName = Console.ReadLine();
                }

                switch (infoIdOrName)
                {
                    case "1":
                        string idLine;
                        int id = -1;

                        while (id <= 0 || id > Store.Article_ToDictionary().Count)
                        {
                            Console.WriteLine("Please enter to key from 1 to {0}: ", Store.Article_ToDictionary().Count);
                            idLine = Console.ReadLine();

                            try
                            {
                                id = (int)Convert.ToUInt32(idLine);

                                if (Store.Article_ToDictionary().ContainsKey(id))
                                {
                                    Console.WriteLine("Value for " + id + " is: ProductName = " + Store.Article_ToDictionary()[id].ProductName +
                                        " StoreName = " + Store.Article_ToDictionary()[id].StoreName + " Price = " + Store.Article_ToDictionary()[id].Price + "\n\n");
                                }
                                else
                                {
                                    Console.WriteLine("Not found data by key {0}", id);
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("{0} is not an integer", idLine);
                            }
                        }

                        info = Question(info);
                        break;

                    case "2":
                        /*
                         * 
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
                         * 
                        */

                        string productName;

                        Console.WriteLine("Select Product Name:");
                        productName = Console.ReadLine();
                        bool groupKeyOnlyFalse = false;

                        var result = Store.Article_ToDictionary().GroupBy(v=> v.Value.ProductName == productName);

                        foreach (var group in result)
                        {
                            if (group.Key == true)
                            {
                                Console.WriteLine("Group by {0}:", productName);
                                foreach (var str in group)
                                {
                                    Console.WriteLine("ID = {0}, Store = {1}, Price = {2}", str.Value.ID, str.Value.StoreName, str.Value.Price);
                                }
                                Console.WriteLine("\n");
                                groupKeyOnlyFalse = true;
                            }
                            if (groupKeyOnlyFalse == false)
                            {
                                Console.WriteLine("No product with name = {0}", productName);
                            }
                        }
;
                        info = Question(info);
                        break;

                    case "3":
                        info = false;
                        break;
                }
            }
        }

        public static bool Question(bool info)
        {
            Console.WriteLine("Do you want to continue?");
            Console.WriteLine("Select 1 -- Yes or 2 -- Exit Search");

            string line = Console.ReadLine();
            try
            {
                if ((int)Convert.ToInt32(line) == 1)
                    info = true;
                else
                    info = false;
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is not an integer", line);
            }

            return info;
        }
    }
}
