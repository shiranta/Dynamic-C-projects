using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Client
{
    class HelloClient
    {
        public static void Main(string[] args)
        {
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel, false);

            // Get an instance of the remote object
            ServerRem.Hello obj = (ServerRem.Hello)Activator.GetObject(
                typeof(ServerRem.Hello),
                "tcp://localhost:9999/Hello"
            );

            // Use the object
            Console.WriteLine(obj.GetMessage());
            Console.ReadKey();
        }
    }
}
