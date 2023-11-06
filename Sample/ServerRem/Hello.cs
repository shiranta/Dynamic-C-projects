using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerRem
{
    // class that is accessible to remote clients
    public class Hello : MarshalByRefObject
    {
        public string GetMessage()
        {
            return "Hello srilal , God bless you!";
           
            //Console.ReadKey();
        }
    }
}
