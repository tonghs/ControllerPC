using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller
{
    class Host
    {
        private string ip;
        public string Ip
        {
            get { return ip; }
            set { ip = value; }
        }

        private int port;
        public int Port
        {
            get { return port; }
            set { port = value; }
        }

        private byte[] msg;
        public byte[] Msg
        {
            get { return msg; }
            set { msg = value; }
        }

        private int moduleIndex;
        public int ModuleIndex
        {
            get { return moduleIndex; }
            set { moduleIndex = value; }
        }

        //private int switchIndex;
        //public int SwitchIndex
        //{
        //    get { return switchIndex; }
        //    set { switchIndex = value; }
        //}

        public Host(string ip, int port, byte[] msg, int moduleIndex)
        {
            this.ip = ip;
            this.port = port;
            this.msg = msg;
            this.moduleIndex = moduleIndex;
            //this.switchIndex = switchIndex;
        }

    }
}
