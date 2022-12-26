using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baba
{
    class Customer
    {
        string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        string _billing_Address;
        public string Billing_Address
        {
            get { return _billing_Address; }
            set { _billing_Address = value; }
        }

        string _shipping_Address;
        public string Shipping_Address
        {
            get { return _shipping_Address; }
            set { _shipping_Address = value; }
        } 

        public override string ToString()
        {
            string display = "";
            display += "Customer Detials :\n";
            display += "Customer Name : " + this.Name + "\n";
            display += "Billing Address : " + this.Billing_Address + "\n";
            display += "Shipping Address : " + this.Shipping_Address ;
            return display;
        }
    }
}
