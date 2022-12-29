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

        int _warenty_period;
        public int Warenty_period
        {
            get { return _warenty_period; }
            set 
            {
                if (value >= 1 && value <= 10) _warenty_period = value;
                else throw new Exception("Invalid Warenty period");
            }
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
            set
            {
                if (value >= 0 && value <= 28) _GST = value;
                else throw new Exception("Invalid GST");
            }
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
            display += S_No + "\t   " + Name + "\t    " + Model_No + "\t     " + Warenty_period + " years\t\t " + Price + "\t     " + Quantity + "\t\t " + GST + "%\t    " + Discount + "%\t\t";
            return display;
        }
    }
}
