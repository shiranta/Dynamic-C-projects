using System;

namespace ConvertProjecct
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 10;
            //int j = 10;

            //Console.WriteLine(i == j);
            //Console.WriteLine(i.Equals(j));

            //Direction dir1 = Direction.East;
            //Direction dir2 = Direction.East;

            

            Customer c1 = new Customer();
            c1.FirstName = "Srilal";
            c1.LastName = "Fonseka";

            Customer c2 = new Customer();
            c2.FirstName = "Srilal";
            c2.LastName = "Fonseka";

            
            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1.Equals(c2));





            Console.ReadKey();

        }
        public enum Direction
        {
            East=1,
            West=2,
            North=3,
            South=4

        }
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override bool Equals(object obj)
        {
            if(obj==null)
            {
                return false;
            }

            if(!( obj is Customer))
            {
                return false;
            }
            return this.FirstName == ((Customer)obj).FirstName &&
                this.LastName == ((Customer)obj).LastName;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();

        }

    }
}
