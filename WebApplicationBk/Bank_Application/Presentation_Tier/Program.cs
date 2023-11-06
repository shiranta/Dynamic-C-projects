using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using BankDB;
using RemotingExampleInterfaces;

namespace Presentation_Tier
{
    class Program
    {
        [Obsolete]
        static void Main(string[] args)
        {
            ChannelServices.RegisterChannel(new TcpClientChannel());
            BankDB.UserAccessInterface resService = (BankDB.UserAccessInterface)Activator.GetObject(typeof(BankDB.UserAccessInterface), "tcp://localhost:9988/RemotingExampleService");
            Console.WriteLine("Client start!");
            Console.ReadLine();
        }
    }
}
