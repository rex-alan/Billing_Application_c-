using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baba
{
    class Calculate_Stats
    {
        float _gst;
        public float Gst
        {
            get { return _gst; }
            set { _gst = value; }
        }

        float _discount;
        public float Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }
        

        float _total;
        public float Total
        {
            get { return _total; }
            set { _total = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}",this.Total +"\n");
        }
    }
}
