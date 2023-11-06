using System;

namespace CInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer c1 = new Customer();
            //c1.Printdata1();
            //c1.Printdata2();
            //ICustomer cust = new Customer();
            //cust.Printdata1();

            //Isales sale = new Customer();
            //sale.Printdata2();

            Program p = new Program();
            //(ICustomer)p.



        }
    }

    interface ICustomer
    {
        public void Printdata();

    }
    interface Isales
    {
        public void Printdata();
    }

    public class cutomer : ICustomer, Isales
    {
            void ICustomer.Printdata()
            {
            Console.WriteLine("Icustomer print data");
            Console.ReadLine();
            }

        void Isales.Printdata()
        {
            Console.WriteLine("Isales  print data");
            Console.ReadLine();
        }
    }

}
