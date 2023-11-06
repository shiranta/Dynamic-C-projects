using Bank_Application.Services;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Serialization;


namespace Bank_Application
{
    class RemoteService
    {
        [Obsolete]
        public static void Main(string[] args)
        {
          

            TcpServerChannel channel = new TcpServerChannel(9988);
            
            ChannelServices.RegisterChannel(channel, false);
            
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(AccountService), "AccountApp", WellKnownObjectMode.Singleton);
            System.Console.WriteLine("**--Account service started--**");
            System.Console.WriteLine("Press Any Key");

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(UserService), "UserApp", WellKnownObjectMode.Singleton);
            System.Console.WriteLine("**--User service started--**");
            System.Console.WriteLine("Press Any Key");
            System.Console.ReadLine();

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(TransactionService), "TranApp", WellKnownObjectMode.Singleton);
            System.Console.WriteLine("**--Transction Service--**");
            System.Console.WriteLine("Press Any Key");
            System.Console.ReadLine();



        }
    }
  
   

  
}

