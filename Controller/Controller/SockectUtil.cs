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
        //public void Send(string ip, int port, int index, int state)
        //{
        //    byte[] msg = new byte[15];
        //    //msg[0] = 0xAA;
        //    //msg[1] = (byte)index;
        //    //msg[2] = (byte)state;
        //    //msg[3] = 0xFF;
        //    //协议头
        //    msg[0] = 0xAA;
        //    msg[1] = 0x55;
        //    //包长
        //    msg[2] = 0x00;
        //    msg[3] = 0x00;
        //    //命令字
        //    msg[4] = 0x00;
        //    //板类型
        //    msg[5] = 0x00;
        //    //功能
        //    msg[6] = 0x00;
        //    //设备号
        //    msg[7] = 0x00;
        //    //继电器号
        //    msg[8] = (byte)(index - 1);
        //    msg[9] = (byte)state;

        //    //Payload
        //    msg[10] = 0x00;
        //    msg[11] = 0x00;
        //    msg[12] = 0x00;
        //    msg[13] = 0xcc;
        //    msg[14] = 0xdd;

        //    //msg[0] = (byte)(0xA0 | index);
        //    //msg[1] = (byte)(0x0F | state << 4);

        //    Thread th = new Thread(new ParameterizedThreadStart(StartReceive));
        //    th.Start(new Host(ip, port, msg));
        //}

        //public void StartReceive(object host)
        //{
        //    try
        //    {
        //        Host h = (Host)host;
        //        TcpClient client = new TcpClient(h.getIP(), h.getPort());
        //        NetworkStream ns = client.GetStream();
        //        ns.Write(h.getMsg(), 0, h.getMsg().Length);
        //        Thread.Sleep(1000);
        //        ns.Close();
        //        client.Close();
        //    }
        //    catch (Exception e)
        //    {
        //        e = e;
        //    }
        //}
    }
}
