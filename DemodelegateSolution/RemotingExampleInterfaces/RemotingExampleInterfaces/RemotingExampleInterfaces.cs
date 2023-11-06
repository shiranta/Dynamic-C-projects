using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemotingExampleInterfaces
{
    public interface IResume
    {
        String GetFormattedResume();
        String GetFormattedName();
    }
    public interface IRemotingExampleService
    {
        IResume GetResume();
        String GetFormattedResume();
    }
}
