using System;

namespace ConsoInterface
{
    interface iCustomer1
    {
        void Print1();
    }

    interface iCustomer2:iCustomer1
    {
        void Print2();
    
    }

    public class Customer :  iCustomer2
    {
        public void Print1()
        {
            Console.WriteLine("Print interface one");
            Console.ReadKey();

        }

        public void Print2()
        {
            Console.WriteLine("Print interface Two");
            Console.ReadKey();

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Customer cust = new Customer();

            //cust.Print1();
            //cust.Print2();

            //iCustomer1 cus = new Customer();
            //cus.Print1();

            iCustomer2 ic2 = new Customer();

            ic2.Print1();
            ic2.Print2();



        }
    }
}
