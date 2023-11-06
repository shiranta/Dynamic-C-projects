using System;

namespace ConceptCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Fname = "Gesus";
            emp.Fname = "Blessed Me";
            emp.FullName();
            Console.ReadLine();

            Parttime pt = new Parttime();
            pt.Fname = "Lal";
            pt.Lname = "Fonseka";
            pt.FullName();
            Console.ReadLine();

            Employee pte = new Parttime();
            pte.Fname = "Shirantha";
            pte.Lname = "Anton";
            pte.FullName();
            Console.ReadLine();


        }
    }

    public class Employee
    { 

        public string Fname;
        public string Lname;

        public void FullName()
        {
         Console.WriteLine(Fname + "  " + Lname);

        }
    }

    public class Permanet : Employee
    {
        public float AnnualSalary;



    }

    public class Parttime: Employee
    {
        public float HourlySalary;
        public new void FullName()
        {
            // Console.WriteLine(Fname + "  " + Lname+" "+"Part Timers");
            base.FullName();
        }



    }


}
