using Bank_Application.Services;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Serialization;


namespace Bank_Application
{
    class Remote_Server
    {
        [Obsolete]
        public static void Main(string[] args)
        {
           // TcpServerChannel channel = new TcpServerChannel(9988);
           // //TcpChannel channel = new TcpChannel(9988);
           // ChannelServices.RegisterChannel(channel,false);
           // //RemotingConfiguration.RegisterWellKnownServiceType(typeof (Bank), "BankApp", WellKnownObjectMode.SingleCall);
           //RemotingConfiguration.RegisterWellKnownServiceType(typeof(BankDB.UserAccessInterface), "BankApp", WellKnownObjectMode.Singleton);
           // System.Console.WriteLine("Press Any Key");
           // System.Console.ReadLine();

            TcpServerChannel channel = new TcpServerChannel(9988);
            
            ChannelServices.RegisterChannel(channel, false);
            
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(AccountService), "AccountApp", WellKnownObjectMode.Singleton);
            System.Console.WriteLine("Account service started");
            System.Console.WriteLine("Press Any Key");

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(UserService), "UserApp", WellKnownObjectMode.Singleton);
            System.Console.WriteLine("User service started");
            System.Console.WriteLine("Press Any Key");
            System.Console.ReadLine();



        }
    }
  
    public class User {
        public string Firstname;
        public string Lastname;
        public uint UID;

        public User()
        {
        }

        public User(string fname, string lname) {
            Firstname = fname;
            Lastname = lname;
        }
        public uint uid=100;
        public uint userid() {
            return uid++;
           
        }

       
    }

  
}

