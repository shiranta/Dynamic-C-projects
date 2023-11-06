using System;
using PATA=ProjectA.TeamA;
using PBTA=ProjectB.TeamA;

namespace ProgectCtesting
{
    class Program
    {
        static void Main(string[] args)
        {
            PATA.TeamA A = new PATA.TeamA();
            A.Print();
            PBTA.TeamA B = new PBTA.TeamA();
            B.Print();

            

         }
    }
}

