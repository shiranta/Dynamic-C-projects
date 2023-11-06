using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloRemotingService
{
    public class HelloRemotingServices:MarshalByRefObject,
        IHelloremotingService.IHelloRemotingServices

    {
        public string GetMessage(string name)
        {
            return "Hello  " + name;
                    
        }
    }
}
