using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProj
{
    public class MorgageCalculation
    {
        private MorgageCalculation()
        { }
        public static decimal MonthlyPayments(
          decimal rate,
            decimal price,
            int years)
        {
            decimal monthpay = price+ (rate * price * (years)/12);
            return monthpay;
        }

        static void Main(string[] args)
        {
            decimal mPay = MorgageCalculation.MonthlyPayments(1, 5000, 3);
            Console.WriteLine("Monthly Pay is {0}", mPay.ToString());
            Console.ReadKey();
        
        }

    }
}
