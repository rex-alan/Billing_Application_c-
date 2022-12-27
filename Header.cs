using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biling_Application1
{
    class Header
    {
        int _bill_No;
        public int Bill_No
        {
            get { return _bill_No; }
            set { _bill_No = value; }
        }

        string _date;
        public string Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public override string ToString()
        {
            return string.Format("Bill No : {0} \t\t\t\t\t\t\t\t\t\t      Date : {1}", this.Bill_No, this.Date);
        }
    }
}
