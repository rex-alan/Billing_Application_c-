using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baba
{
    class Service_centere
    {
        public string Name;     //we can declare a variable in public without encapsulate
        public string Address;

        public override string ToString()
        {
            return string.Format(" \t Service centere name : {0} | Address : {1}",Name,Address);
        }
    }
}
