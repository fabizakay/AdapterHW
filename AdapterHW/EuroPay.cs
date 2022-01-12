using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterHW
{
    public class EuroPay : IEuro1
    {
        public double Pay(double x)
        {
            return x;
        }
    }
}
