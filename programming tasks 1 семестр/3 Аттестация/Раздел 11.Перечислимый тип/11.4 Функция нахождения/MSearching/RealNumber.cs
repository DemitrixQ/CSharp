using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsSearching
{
    class RealNumber
    {
        public double mantissa;
        public int order;
        public bool a;

        public string ConvertToString()
        {
            return ((a) ? "-" : "+") + mantissa.ToString() + "E" + order.ToString();
        }

        public override string ToString()
        {
            return ConvertToString();
        }

    }
}
