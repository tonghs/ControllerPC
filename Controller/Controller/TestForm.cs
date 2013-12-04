using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controller
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] msg = new byte[15];
            //协议头
            msg[0] = 0xAA;
            msg[1] = 0x55;
            //包长
            msg[2] = 0x00;
            msg[3] = 0x00;
            //命令字
            msg[4] = 0x00;
            //板类型
            msg[5] = 0x00;
            //功能
            msg[6] = 0x00;
            //设备号
            msg[7] = 0x00;
            //继电器号
            msg[8] = 0x00;
            msg[9] = 0x00;            
            msg[10] = 0x00;
            msg[11] = 0xFF;

            msg[12] = 0x00;
            msg[13] = 0xcc;
            msg[14] = 0xdd;

            uint a = 0x01;
            uint b = 0xFFFFFFFF | a;
            uint c = a | 0xFFFFFFFF;

            //this.label1.Text = new Message().GetStatus(msg, int.Parse(this.textBox1.Text)).ToString();
        }
    }
}
