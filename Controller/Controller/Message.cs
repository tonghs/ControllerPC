using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Controller
{
    class Message
    {
        private UInt32 main = 0xFFFFFFFF;
        private byte[] requestMsg;
        private byte[] controlMsg;
        
        public static Hashtable currentState;

        public static Hashtable CurrentState
        {
            get 
            {
                if (currentState == null)
                {
                    currentState = new Hashtable();
                }
                return currentState; 
            }
            set { currentState = value; }
        }

        public byte[] RequestMsg
        {
            get 
            {
                requestMsg = new byte[17];
                //协议头
                requestMsg[0] = 0xAA;
                requestMsg[1] = 0x55;
                //包长
                requestMsg[2] = 0x00;
                requestMsg[3] = 0x00;
                //命令字
                requestMsg[4] = 0x00;
                //板类型
                requestMsg[5] = 0x00;
                //功能(控制/询问)
                requestMsg[6] = 0x01;
                //设备号
                requestMsg[7] = 0x00;
                //继电器及开关
                requestMsg[8] = 0x00;
                requestMsg[9] = 0x00;

                requestMsg[10] = 0x00;
                requestMsg[11] = 0x00;

                requestMsg[12] = 0x00;
                requestMsg[13] = 0xcc;
                requestMsg[14] = 0xdd;


                return requestMsg; 
            }
            set { requestMsg = value; }
        }

        public byte[] ControlMsg
        {
            get
            {
                controlMsg = new byte[15];
                //协议头
                controlMsg[0] = 0xAA;
                controlMsg[1] = 0x55;
                //包长
                controlMsg[2] = 0x00;
                controlMsg[3] = 0x00;
                //命令字
                controlMsg[4] = 0x00;
                //板类型
                controlMsg[5] = 0x00;
                //功能(控制/询问)
                controlMsg[6] = 0x00;
                //设备号
                controlMsg[7] = 0x00;
                //继电器及开关
                controlMsg[8] = 0x00;
                controlMsg[9] = 0x00;

                controlMsg[10] = 0x00;
                controlMsg[11] = 0x00;

                controlMsg[12] = 0x00;
                controlMsg[13] = 0xcc;
                controlMsg[14] = 0xdd;

                return controlMsg;
            }
            set { requestMsg = value; }
        }

        /// <summary>
        /// 根据报文获取继电器状态(根据索引）
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public uint GetStatus(byte[] msg, int index)
        {
            uint temp = (((main & msg[6]) << 24) | main) & (((main & msg[7]) << 16) | main) & (((main & msg[8]) << 8) | main) & msg[9];
            uint state = (temp << (32 - index - 1)) >> 31;

            return state;
        }

        /// <summary>
        /// 根据开关状态置位
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="moduleIndex"></param>
        /// <param name="switchIndex"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public byte[] GetRequestMsg(string ip, int moduleIndex, int switchIndex, int state)
        {
            byte[] msg = (byte[])Message.CurrentState[ip];
            if (msg == null)
            {
                msg = ControlMsg;
            }

            int index = 9 - switchIndex / 8;
            int offset = switchIndex % 8;

            BitArray bits = new BitArray(new byte[] { msg[index] });
            bits[offset] = state == 1;
            byte[] buffer = new byte[1];
            bits.CopyTo(buffer, 0);

            msg[index] = buffer[0];

            return msg;
        }
    }
}
