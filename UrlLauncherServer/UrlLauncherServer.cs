using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace UrlLauncherServer
{
    class UrlLauncherServer
    {
        private TcpComServer mServer;
        private string mCmdStr;
        
        public UrlLauncherServer(string cmdStr)
        {
            mServer = new TcpComServer();
            mServer.ConnectionEvent += new TcpComServer.ConnectionEventHandler(mServer_ConnectionEvent);
            mServer.PacketReady += new TcpComServer.PacketReadyEventHandler(mServer_PacketReady);
            mCmdStr = cmdStr;
            mServer.ServerConnectionStateChange += new TcpComServer.ConnectionStateChangeEventHander(mServer_ServerConnectionStateChange);
        }

        void mServer_ServerConnectionStateChange(TcpComServer.ConnectionState connectionState, string description)
        {
            //throw new NotImplementedException();
        }

        public void UpdateCmdStr(string cmdStr)
        {
            mCmdStr = cmdStr;
        }

        void mServer_PacketReady(string packet)
        {
           // throw new NotImplementedException();

            //just assume the contents is ONLY a URL
            if ((packet != "hello") && (packet != "keepAlive"))
            {
                string cmd = mCmdStr.Replace("%u", packet);
                System.Diagnostics.Process.Start(cmd);
                Debug.Print("got past the launch");
            }
        }

        void mServer_ConnectionEvent(TcpComServer.ConnectionEventType connectionEvent, string data)
        {
            //throw new NotImplementedException();
        }

        public void Start()
        {
            mServer.Start(9877);
        }
    }
}
