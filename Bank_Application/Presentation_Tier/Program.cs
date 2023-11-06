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
using Bank_Application.Services;

namespace Presentation_Tier
{
    [Serializable()]
    class Program
    {
        
        [Obsolete]
        static void Main(string[] args)
        {
            //ChannelServices.RegisterChannel(new TcpClientChannel());
            //BankDB.UserAccessInterface resService = (BankDB.UserAccessInterface)Activator.GetObject(typeof(BankDB.UserAccessInterface), "tcp://localhost:9988/BankApp");
            ////Bank resService = (Bank)Activator.GetObject(typeof(Bank), "tcp://localhost:9988/BankApp");
            //Console.WriteLine("Client start!");
            //Console.WriteLine("User added");
            //uint a=resService.CreateUser();
            //Console.WriteLine(a);
            //Console.ReadLine();

            ChannelServices.RegisterChannel(new TcpClientChannel());
            UserService resService = (UserService)Activator.GetObject(typeof(UserService), "tcp://localhost:9988/UserApp");
            Console.WriteLine("User Service Started !");

            AccountService accService = (AccountService)Activator.GetObject(typeof(AccountService), "tcp://localhost:9988/AccountApp");
            Console.WriteLine("Accounts Service Started!");


            ////int a = resService.sum(4, 5);
            ////Console.WriteLine(a);

            uint UserID = resService.CreateBankUser();
            Console.WriteLine(UserID);
            Console.ReadLine();

            //string FullNmae = resService.GetBankUser(162981433);
            //Console.WriteLine(FullNmae);


            //List<uint> UserIDs = resService.GetAllUsers();



            //UserIDs.ForEach(UserId => Console.WriteLine(UserId));
            ////Console.WriteLine(UserIDs.ToString());
            //Console.ReadLine();

            //uint AccID = accService.CreateBankAccount(162981433);
            //Console.WriteLine(AccID);
            //Console.ReadLine();

            //accService.DepositCash(2500, 2772231);
            //Console.WriteLine(AccID);
            //Console.ReadLine();




        }
    }
}
