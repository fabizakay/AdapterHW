using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterHW
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IDollar1 payDollarToEuor = new Adapterpay();
            int x = 50;
            Pay(payDollarToEuor, x);
            
        }

        private static void Pay(IDollar1 payDollarToEuor, int x)
        {
            Console.WriteLine(payDollarToEuor.Pay(x));
        }
    }
   
}
