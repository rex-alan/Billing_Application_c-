using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biling_Application1
{
    class Product
    {
        int _s_No;
        public int S_No
        {
            get { return _s_No; }
            set { _s_No = value; }
        }

        string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        int _model_No;
        public int Model_No
        {
            get { return _model_No; }
            set { _model_No = value; }
        }

        string _warenty_period;
        public string Warenty_period
        {
            get { return _warenty_period; }
            set { _warenty_period = value; }
        }

        float _price;
        public float Price
        {
            get { return _price; }
            set { _price = value; }
        }

        int _quantity;
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        float _GST;
        public float GST
        {
            get { return _GST; }
            set { _GST = value; }
        }

        float _discount;
        public float Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }

        public override string ToString()
        {
            string display = "\n";
            display += "S.No \t Product Name \t Model Number \t Warenty Period \t Price \t Quantity \t GST \t Discount \t Total \n\n";
            display += S_No + "\t   " + Name + "\t    " + Model_No + "\t     " + Warenty_period + "\t\t " + Price + "\t     " + Quantity + "\t\t " + GST + "%\t    " + Discount + "%\t\t";
            return display;
        }
    }
}
