using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baba
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Bill1 bill = new Bill1();
            bill.Bill_No = 202277;
            bill.Date = "19-12-2022";

            //2
            Company comp = new Company();
            comp.Name = "BABA ENTERPRISE";
            comp.Address = "No:7, TVS Tolgate, Trichy-620004 ";

            //3
            Service_centere service = new Service_centere();
            service.Name = "BABA SERVICES";
            service.Address = "No:12, Bharadhidasan Salai, Contonment, Trichy-620008";

            //4
            Product prod = new Product();
            prod.S_No = 001;
            prod.Name = "Grainder";
            prod.Model_No = 202299;
            prod.Warenty_period = "2 years";
            prod.Price = 50000f;
            prod.Quantity = 1;
            prod.GST = 10f;
            prod.Discount = 5f;

            //5
            Customer cust = new Customer();
            cust.Name = "Rex Alan";
            cust.Billing_Address = "No 37, Rohini appartments, Tennur, Trichy-620018";
            cust.Shipping_Address = "No 37, Rohini appartments, Tennur, Trichy-620018";

            Display d = new Display();
            d.Bill_disp = bill;
            d.Company_disp = comp;
            d.Service_disp = service;
            d.Product_disp = prod;
            d.AddProduct(prod);
            d.Customer_disp = cust;

            Console.WriteLine(d);
        }
    }
}
