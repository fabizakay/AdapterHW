using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterHW
{
    public class Adapterpay : IDollar1
    {
        private IEuro1 euroPay = new EuroPay();
        public double Pay(double x)
        {
            return euroPay.Pay(x * 0.88) ;
        }
    }
}
