using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHelloremotingService
{
    public interface IHelloRemotingServices
    {
        string GetMessage(string name); 
    }
}
