using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using RemotingExampleInterfaces;

namespace RemotingExampleClient
{
    class RemotingExampleClient
    {
        [Obsolete]
        static void Main(string[] args)
        {
            ChannelServices.RegisterChannel(new TcpClientChannel());
            IRemotingExampleService resService = (IRemotingExampleService)Activator.GetObject(typeof(IRemotingExampleService), "tcp://localhost:9988/RemotingExampleService");
            Console.WriteLine("RESUME:\n" + resService.GetFormattedResume());
            IResume aResume = resService.GetResume();
            Console.WriteLine("NAME:" + aResume.GetFormattedName());
            Console.WriteLine("RESUME:" + aResume.GetFormattedResume());
            Console.WriteLine("Press any key to continue...");
            Console.Read();
        } //END OF MAIN METHOD  
    } //END OF RemotingExampleClient class  
}//END OF THE NAMESPACE
