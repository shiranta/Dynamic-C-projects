using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using RemotingExampleInterfaces;



namespace RemotingInterfaceServer
{
    public class EntryPoint
    {
        [Obsolete]
        public static void Main(string[] args)
        {
            TcpServerChannel channel = new TcpServerChannel(9988);
            ChannelServices.RegisterChannel(channel);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof (RemotingExampleService), "RemotingExampleService", WellKnownObjectMode.SingleCall);
            System.Console.WriteLine("Press Any Key");
            System.Console.ReadLine();
        }
    }
    public class RemotingExampleService : MarshalByRefObject, IRemotingExampleService
    {
       public RemotingExampleService() { }
        
        public IResume GetResume()
        {
            Resume resume = new Resume();
            resume.FirstName = "David";
            resume.LastName = "Talbot";
            resume.Title = "Senior Software Architect";
            resume.Body = "Did some cool stuff";
            return (IResume)resume;
        }
        public String GetFormattedResume()
        {
            return GetResume().GetFormattedResume();
        }
    }
    [Serializable]
    public class Resume : MarshalByRefObject, IResume
    {
        public String FirstName, LastName, Body, Title;
        public String GetFormattedResume()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("*" + GetFormattedName() + "*\n");
            sb.Append("--" + Title + "--\n");
            sb.Append("--------------------------\n");
            sb.Append(Body);
            return sb.ToString();
        }
        public String GetFormattedName()
        {
            return FirstName + " " + LastName;
        }
    }
    //END OF Resume Object  
}
