using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;


namespace HelloRemotingServiceClient
{
    public partial class Form1 : Form
    {
        IHelloremotingService.IHelloRemotingServices clt;

        public Form1()
        {
            InitializeComponent();
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel,false);

            clt = (IHelloremotingService.IHelloRemotingServices)Activator.GetObject
                (typeof(IHelloremotingService.IHelloRemotingServices), "tcp://localhost:8080/GetMessage");


        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            lblDisplay.Text=clt.GetMessage(textbox.Text);
        }
    }
}
