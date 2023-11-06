using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegateincludingList
{
    //public delegate bool IsPromotable(Employee em);
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> lst = new List<Employee>();
            lst.Add(new Employee() { ID = 101, Name = "srilal", salary = 3000, Experience = 3 });
            lst.Add(new Employee() { ID = 102, Name = "sanath", salary = 7000, Experience = 6 });
            lst.Add(new Employee() { ID = 103, Name = "shiran", salary = 9000, Experience = 7 });
            lst.Add(new Employee() { ID = 104, Name = "priyani", salary = 13000, Experience = 9 });

            //IsPromotable pble = new IsPromotable(GetPromotion);
            
            
            //Employee.PromoteEmployee(lst,pble);
            Employee.PromoteEmployee(lst, Employee=>Employee.Experience>=5);

        }

        //public delegate bool IsPromotable(Employee em);
        /*public static bool GetPromotion(Employee ep)
        {
            if (ep.Experience >= 5)
            //if(ep.salary>12000)

            {
                return true;
            }
            else
            {
                return false;
            }

        }*/
    }
       

}
public delegate bool IsPromotable(Employee em);
public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int salary { get; set; }

    public int Experience { get; set; }


    public static void PromoteEmployee(List<Employee> emplist, IsPromotable isPromotable )
        {
        foreach (Employee epl in emplist)
        {
            //if(epl.Experience>=5)
            if (isPromotable(epl))
            {
                Console.WriteLine(epl.Name + "  Promoted");
            }
        }

        Console.ReadKey();

    }

}
