using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biling_Application1
{
    class Service_Centere
    {
        public string Name;     //we can declare a variable in public without encapsulate
        public string Address;

        public override string ToString()
        {
            return string.Format(" \t Service centere name : {0} | Address : {1}", Name, Address);
        }
    }
}
