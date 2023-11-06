 using System;
using System.Threading;


namespace ThreadApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread thd1 = new Thread(Method1);
            Thread thd2 = new Thread(Method2);


            thd1.Start();
            thd2.Start();

            //Method()

            //for (int i=1; i<=10; i++)
            //for (int i = 1; ; i++)

            //    {
            //    Console.WriteLine("Main " + i);
            //}


            Console.WriteLine("End Program");


            Console.ReadKey();

        }

        static void Method1()
        {
            //for (int i = 1; i <= 10; i++)
            for (int i = 1; i<100 ; i++)
            {
                if (i == 50)

                    Thread.Sleep(3000);

                


                Console.WriteLine(string.Format("Method1 -No is {0}",i.ToString()));
                           
                }
        }
        static void Method2()
        {
            //for (int i = 1; i <= 10; i++)
            for (int i = 1; ; i++)
            {
                Console.WriteLine(string.Format("Method2 -No is {0}", i.ToString()));


            }
        }
    }

}
