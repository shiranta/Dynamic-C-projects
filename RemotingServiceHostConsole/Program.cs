using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace RemotingServiceHostConsole
{
    class Program
    {
        static void Main()
        {
            HelloRemotingService.HelloRemotingServices remService = new
                 HelloRemotingService.HelloRemotingServices();

            TcpChannel channel = new TcpChannel(8080);
            ChannelServices.RegisterChannel(channel);
            RemotingConfiguration.RegisterWellKnownServiceType
                (typeof(HelloRemotingService.HelloRemotingServices), "GetMessage", WellKnownObjectMode.Singleton);
            Console.WriteLine("Remote Service Started @" + DateTime.Now);
            Console.ReadLine();


        }
    }
}
