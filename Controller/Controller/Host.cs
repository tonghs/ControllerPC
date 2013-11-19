using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller
{
    class Host
    {
        private string ip;
        private int port;
        private byte[] msg;
        public Host(string ip, int port, byte[] msg)
        {
            this.ip = ip;
            this.port = port;
            this.msg = msg;
        }

        public string getIP()
        {
            return this.ip;
        }

        public int getPort()
        {
            return this.port;
        }

        public byte[] getMsg()
        {
            return this.msg;
        }
    }
}
