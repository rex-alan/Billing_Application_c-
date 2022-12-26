using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baba
{
    class Company
    {
        string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _address;
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public override string ToString()
        {
            return string.Format("\t\t\t\t\t\t   {0} \n \t\t\t\t\t Address : {1}", this.Name, this.Address);
        }
    }
}
