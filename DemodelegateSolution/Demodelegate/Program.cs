using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Demodelegate
{
    public delegate void HelloFunctionDelegate(string Message);

    class Program
    {
        static void Main(string[] args)
        {
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("This is the String by delegate");

        }
        public static void  Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
            Console.ReadKey();
        }

    }
}
