using System;

namespace Polynorphiism
{
    class Program
    {
        static void Main(string[] args)
        {
            Employeebase[] emp = new Employeebase[4];

            emp[0] = new Employeebase() {Fname="Lal",Lname="Fonseka" };
            emp[1] = new Permanet() { Fname = "Shirantha", Lname = "Anton" };
            emp[2] = new Tempory() { Fname = "Anne", Lname = "Shivoli" };
            emp[3] = new Parttime() { Fname = "Chandani", Lname = "Perera" };

            foreach (Employeebase e in (emp))
            {
                e.FullName();
            
            }
            Console.ReadLine();
        }
    }

    public class Employeebase
    {
        public string Fname;
        public string Lname;

        public virtual void FullName()
        {
            Console.WriteLine(Fname + Lname);
        }
    }

    public class Permanet:Employeebase
        {
        public override void FullName()
        {
            Console.WriteLine(Fname + " " + Lname + " -Permanet");
        }
    }


    public class Tempory : Employeebase
    {
        public override void FullName()
        {
            Console.WriteLine(Fname + " " + Lname + " -Tempory");
        }
    }

    public class Parttime : Employeebase
    {
        public override void FullName()
        {
            Console.WriteLine(Fname + " " + Lname + " -PartTime");
        }
    }
}
