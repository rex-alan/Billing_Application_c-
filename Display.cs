using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baba
{
    class Display
    {
        Bill1 bill_disp = new Bill1();
        internal Bill1 Bill_disp
        {
            get { return bill_disp; }
            set { bill_disp = value; }
        }

        Company company_disp = new Company();
        internal Company Company_disp
        {
            get { return company_disp; }
            set { company_disp = value; }
        }

        Service_centere service_disp = new Service_centere();
        internal Service_centere Service_disp
        {
            get { return service_disp; }
            set { service_disp = value; }
        }

        Product product_disp = new Product();
        internal Product Product_disp
        {
            get { return product_disp; }
            set { product_disp = value; }
        }

        Customer customer_disp = new Customer();
        internal Customer Customer_disp
        {
            get { return customer_disp; }
            set { customer_disp = value; }
        }

        List<Product> product_list = new List<Product>();
        public void AddProduct(Product p)
        {
            product_list.Add(p);
        }

        public Calculate_Stats Stats
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
                    GST = price * p.GST/100;
                }
                price = price + GST;
                foreach (Product p in product_list)
                {
                    discount = price * p.Discount/100;
                }
                price = price-discount;

                Calculate_Stats stats = new Calculate_Stats();
                stats.Gst = GST;
                stats.Discount = discount;
                stats.Total = price;
                return stats;
            }
        }

        public override string ToString()
        {
            string show = "";
            show += bill_disp +"\n"+ company_disp +"\n"+ service_disp +"\n"+ product_disp +" "+Stats +"\n" +customer_disp+"\n";
            return show;                                                                        
        }
    }
}
