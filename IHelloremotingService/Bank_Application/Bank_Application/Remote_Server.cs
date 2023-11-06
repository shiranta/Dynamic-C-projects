using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using BankDB;

namespace Bank_Application
{
    class Remote_Server
    {
        [Obsolete]
        public static void Main(string[] args)
        {
            TcpServerChannel channel = new TcpServerChannel(9988);
            ChannelServices.RegisterChannel(channel);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof (Bank), "BankApp", WellKnownObjectMode.SingleCall);
            System.Console.WriteLine("Press Any Key");
            System.Console.ReadLine();
        }
    }

    class Bank : MarshalByRefObject, BankDB.UserAccessInterface
    {
        //BankDB.BankDB db = new BankDB.BankDB();

        public uint CreateUser()
        {
            //throw new NotImplementedException();
            User u = new User();
            uint a=u.userid();
            return a;
        }

        public void GetUserName(out string fname, out string lname)
        {
            throw new NotImplementedException();
            //User u = new User();
            
        }

        public List<uint> GetUsers()
        {
            User u = new User();
            List<uint> lst = new List<uint>();
            lst.Add(u.userid());

            //throw new NotImplementedException();
            return lst;
        }

        public void SelectUser(uint userID)
        {
            throw new NotImplementedException();
        }

        public void SetUserName(string fname, string lname)
        {
            //throw new NotImplementedException();
            User u = new User();
            u.Firstname = fname;
            u.Lastname = lname;
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

