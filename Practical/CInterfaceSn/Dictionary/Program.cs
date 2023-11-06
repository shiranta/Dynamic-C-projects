using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.ID = 101;
            c1.Name = "Srilal";
            c1.Salary = 18000;

            Customer c2 = new Customer();
            c2.ID = 102;
            c2.Name = "Chandani";
            c2.Salary = 15000;

            Customer c3 = new Customer();
            c3.ID = 103;
            c3.Name = "Shirantha";
            c3.Salary = 14000;

            Customer c4 = new Customer();
            c4.ID = 104;
            c4.Name = "Anne";
            c4.Salary = 13000;

            Dictionary<int, Customer> DicCust = new Dictionary<int, Customer>();
            DicCust.Add(c1.ID, c1);
            DicCust.Add(c2.ID, c2);
            DicCust.Add(c3.ID, c3);
            DicCust.Add(c4.ID, c4);

            //Need to access valie ID of 101

            Customer c101 = DicCust[101];

            Console.WriteLine("Id={0},Name={1},Salary={2}", c101.ID, c101.Name, c101.Salary);
            Console.ReadLine();
            foreach (KeyValuePair<int, Customer> CustomerkeyPair in (DicCust))
            {
                Console.WriteLine("Key={0}", CustomerkeyPair.Key);
                Customer ct = CustomerkeyPair.Value;
                Console.WriteLine("ID={0}, Name={1}, Salary={2}", ct.ID, ct.Name, ct.Salary);
                Console.WriteLine("-----------------------------------");
                   

                 
            }
            Console.ReadLine();



        }
    }

    public class Customer
    { 
        public int ID { get; set; }
        public string Name { get; set; }

        public int Salary { get; set; }
    }
}
