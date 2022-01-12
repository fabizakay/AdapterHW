using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterHW
{
    class DollarPay : IDollar1
    {
        public Double Pay(double x)
        {
            return x;
        }
    }
}
