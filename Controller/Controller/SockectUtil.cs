using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading;

namespace Controller
{
    class SockectUtil
    {
        public void Send(string ip, int port, int index, int state)
        {
            byte[] msg = new byte[2];
            //msg[0] = 0xAA;
            //msg[1] = (byte)index;
            //msg[2] = (byte)state;
            //msg[3] = 0xFF;
            msg[0] = (byte)(0xA0 | index);
            msg[1] = (byte)(0x0F | state << 4);



            Thread th = new Thread(new ParameterizedThreadStart(StartReceive));
            th.Start(new Host(ip, port, msg));
        }

        public void StartReceive(object host)
        {
            Host h = (Host)host;
            TcpClient client = new TcpClient(h.getIP(), h.getPort());
            NetworkStream ns = client.GetStream();
            ns.Write(h.getMsg(), 0, h.getMsg().Length);
            Thread.Sleep(1000);
            ns.Close();
            client.Close();
        }
    }
}
