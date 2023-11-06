using System;

namespace Stbproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            Console.WriteLine(c1.ToString());

            string str = c1.ToString();

            Console.WriteLine(str);

            Customer c2 = null;
            //Console.WriteLine(c2.ToString());
            Console.WriteLine(Convert.ToString(c2));




            Console.ReadLine();

            
        }
    }

    public class Customer
    {
        public string FirstNmae {get;set;}
    }
}
