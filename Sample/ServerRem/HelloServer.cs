using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace ServerRem
{
    class HelloServer
    {
        static void Main(string[] args)
        {
            TcpChannel channel = new TcpChannel(9999);  // port no. 9999

            // Register channel 
            ChannelServices.RegisterChannel(channel, false);

            // Register as an available service with the name hello
            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(Hello),
                "hello",
                WellKnownObjectMode.SingleCall
            );
            System.Console.WriteLine("Server started!");
            System.Console.WriteLine("Press the enter key to exit...");
            System.Console.ReadLine();
        }  // end of main
    } // end of class
}
