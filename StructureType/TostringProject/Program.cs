using System;

namespace TostringProject
{
    class Program
    {
        private static object Main(string[] args)
        {
                        int Number = 10;
            Console.WriteLine(Number.ToString());
            Console.ReadLine();
            Customer c1 = new Customer();
            c1.FirstName = "Lal";
            c1.LastName = "Sri";
            Console.WriteLine(c1.ToString());

            Console.ReadLine();




        }
    }

    public class Customer
    { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return this.LastName+this.FirstName;
        }


    }
}
