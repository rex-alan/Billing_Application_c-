using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biling_Application1
{
    class Calculate_Stats
    {
        List<Product> product_list = new List<Product>();
        public void AddProduct(Product p)
        {
            product_list.Add(p);
        }   

        public Bill_Stats Stats
        {
            get
            {
                float price = 0;
                float GST = 0;
                float discount = 0;
                foreach (Product p in product_list)
                {
                    price = p.Price * p.Quantity;
                }
                foreach (Product p in product_list)
                {
                    GST = price * p.GST / 100;
                }
                price = price + GST;
                foreach (Product p in product_list)
                {
                    discount = price * p.Discount / 100;
                }
                price = price - discount;

                Bill_Stats stats = new Bill_Stats();
                stats.Gst = GST;
                stats.Discount = discount;
                stats.Total = price;
                return stats;
            }
        }
        public override string ToString()
        {
            string show = "";
            show += Stats;
            return show;
        }
    }
}