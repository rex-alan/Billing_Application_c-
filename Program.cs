using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biling_Application1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Header header = new Header();
            header.Bill_No = 221227;
            header.Date = "27-12-2022";
            //Console.WriteLine(header);

            //2
            Company company = new Company();
            company.Name = "BABA ENTERPRISE";
            company.Address = "No:7, TVS Tolgate, Trichy-620004 ";
            //Console.WriteLine(company);

            //3
            Service_Centere service = new Service_Centere();
            service.Name = "BABA SERVICES";
            service.Address = "No:12, Bharadhidasan Salai, Contonment, Trichy-620008";
            //Console.WriteLine(service);

            //4
            Product product = new Product();
            product.S_No = 001;
            product.Name = "Grainder";
            product.Model_No = 202299;
            product.Warenty_period = "2 years";
            product.Price = 50000f;
            product.Quantity = 1;
            product.GST = 10f;
            product.Discount = 5f;
            //Console.WriteLine(product);

            //5
            Customer customer = new Customer();
            customer.Name = "Rex Alan";
            customer.Billing_Address = "No 37, Rohini appartments, Tennur, Trichy-620018";
            customer.Shipping_Address = "No 37, Rohini appartments, Tennur, Trichy-620018";
            //Console.WriteLine(customer);

            Bill_Output d = new Bill_Output();
            d.Bill_disp = header;
            d.Company_disp = company;
            d.Service_disp = service;
            d.Product_disp = product;
            d.AddProduct(product);
            d.Customer_disp = customer;

            Console.WriteLine(d);
        }
    }
}
