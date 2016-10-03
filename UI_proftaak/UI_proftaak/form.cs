using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lego.Ev3.Core;
using Lego.Ev3.Desktop;

namespace UI_proftaak
{
    public partial class fromStart : Form
    {
        String holdText;
        Brick brick;
        String COMID;
        public fromStart()
        {
            InitializeComponent();

            //startup
            btnShowInfo.Enabled = false;
            btnStartRobot.Enabled = false;
            btnStopRobot.Enabled = false;
            btnHideInfo.Enabled = false;

            
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            //buttons
            txtInfo.AppendText("Program Started" + Environment.NewLine);
            btnStopRobot.Enabled = true;
            btnHideInfo.Enabled = true;

            if(!String.IsNullOrWhiteSpace(txtCom.Text)){
                COMID = String.Format("COM{0}", txtCom.Text);
            }

            //make connection
            try
            {

                //ERGNETJESENZO
                brick = new Brick(new BluetoothCommunication(COMID));
                brick.BrickChanged += Brick_BrickChanged;

                //connect, send and receive data
                await brick.ConnectAsync();

                //brick command
                await brick.DirectCommand.PlayToneAsync(100, 1000, 500);
                txtInfo.Text = "Connection Successful!";
            }
            catch
            {
                txtInfo.Text = "Connection Failed. \nMake sure your COM-port is correct!";
            }
        }

        //when brick changed state
        private void Brick_BrickChanged(object sender, BrickChangedEventArgs e)
        {
            txtInfo.Text = "Brick Changed!";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            txtInfo.AppendText("Program Stopped" + Environment.NewLine);
            this.Close();
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            txtInfo.Text = holdText;
            btnShowInfo.Enabled = false;
            btnHideInfo.Enabled = true;

        }

        private void btnHideInfo_Click(object sender, EventArgs e)
        {
            holdText = txtInfo.Text;
            btnShowInfo.Enabled = true;
            btnHideInfo.Enabled = false;
            txtInfo.Clear();
        }

        private void btnStartRobot_Click(object sender, EventArgs e)
        {
            txtInfo.AppendText("Robot Started" + Environment.NewLine);
            btnStartRobot.Enabled = false;
            btnStopRobot.Enabled = true;
        }

        private void btnStopRobot_Click(object sender, EventArgs e)
        {
            txtInfo.AppendText("Robot Stopped" + Environment.NewLine);
            btnStopRobot.Enabled = false;
            btnStartRobot.Enabled = true;
        }
    }

}
