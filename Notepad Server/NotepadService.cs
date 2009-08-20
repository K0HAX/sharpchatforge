using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceProcess;
using System.Diagnostics;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Threading;

namespace Xcelor8.Chat
{
    class NotepadService : ServiceBase
    {
        private RemoteObject m_Chat;

        public NotepadService()
        {
            this.ServiceName = "Xcelor8 Chat Server";
            this.EventLog.Log = "Application";

            // These flags set whether or not to handle that specific
            // type of event. Set to true if you need it, false otherwise

            this.CanHandlePowerEvent = false;
            this.CanHandleSessionChangeEvent = false;
            this.CanPauseAndContinue = false;
            this.CanShutdown = true;
            this.CanStop = true;

            m_Chat = new RemoteObject();

            Start();
        }

        static void Main(string[] args)
        {
            RunService();
            RunDebug();
        }

        [Conditional("RELEASE")]
        private static void RunService()
        {
            ServiceBase.Run(new NotepadService());
        }

        [Conditional("DEBUG")]
        private static void RunDebug()
        {
            NotepadService server = new NotepadService();
        }

        public void Start()
        {
            // Create an instance of a channel

            TcpChannel channel = new TcpChannel(1233);
            ChannelServices.RegisterChannel(channel, false);

            // Register as an available service with the name HelloWorld     

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteObject), "NotepadString", WellKnownObjectMode.Singleton);

            while (true)
            {
                Thread.Sleep(10);
            }
        }
    }
}
