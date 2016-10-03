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
using System.Threading;

namespace UI_proftaak
{
    /*
     * ports; One: Infrared. Two: Gyro. Three: Color. Four: Sonar
     */

    public partial class fromStart : Form
    {
        String holdText;
        Brick brick;
        String COMID;
        private bool connected;
        int speed_Forwards = 40, speed_Backwards = 20;
        ushort time_Drive = 1000, time_Wait = 500;
        bool programOn, brickConnected;

        public fromStart()
        {
            //init
            InitializeComponent();

            //startup
            btnShowInfo.Enabled = false;
            btnStartRobot.Enabled = false;
            btnStopRobot.Enabled = false;
            btnHideInfo.Enabled = false;

            timerCheck.Interval = 2 * 1000;
            timerCheck.Tick += TimerCheck_Tick;

            //fullscreen
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
          
        }

        //check for still connected
        private void TimerCheck_Tick(object sender, EventArgs e)
        {
            string[] comids = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string comid in comids)
            {
              //  txtInfo.AppendText(comid + Environment.NewLine);
            }
            if (!comids.Contains(COMID))
            {
               // txtInfo.AppendText(String.Format("Robot at {0} had disconnected." + Environment.NewLine, COMID));
            }

            
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
                txtInfo.AppendText("Connecting ..." + Environment.NewLine);
                brick = new Brick(new BluetoothCommunication(COMID));
                brick.BrickChanged += Brick_BrickChanged;

                //connect, send and receive data
                await brick.ConnectAsync();

                //check connection
                connected = true;
                timerCheck.Start();

                //connection completed
                txtInfo.AppendText("Connection Successful!" + Environment.NewLine);

                txtCom.Enabled = false;
                txtCom.Clear();

                //start program
                programOn = true;
                brickConnected = true;

                brick.DirectCommand.PlayToneAsync(10, 100, time_Wait);

                Program();
            }
            catch
            {
                txtInfo.AppendText("Connection Failed. \nMake sure your COM-port is correct!" + Environment.NewLine);
            }
        }

        //on changed
        private void Brick_BrickChanged(object sender, BrickChangedEventArgs e)
        {
            txtInfo.AppendText(e.Ports[InputPort.Four].SIValue.ToString() + Environment.NewLine);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            txtInfo.AppendText("Program Stopped" + Environment.NewLine);
            if (brickConnected == true)
            {
                brick.Disconnect();
            }
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

            //starting program
            programOn = true;
            Program();
        }

        private void btnStopRobot_Click(object sender, EventArgs e)
        {
            btnStopRobot.Enabled = false;
            btnStartRobot.Enabled = true;

            //stopping robot
            programOn = false;
            txtInfo.AppendText("Robot Stopped" + Environment.NewLine);
        }

        //MoveAround
        private async void button1_Click(object sender, EventArgs e)
        {
            await brick.DirectCommand.TurnMotorAtPowerForTimeAsync(OutputPort.B | OutputPort.C, 100, 500, false);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await brick.DirectCommand.TurnMotorAtPowerForTimeAsync(OutputPort.B | OutputPort.C, -100, 500, false);
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            await brick.DirectCommand.TurnMotorAtPowerForTimeAsync(OutputPort.B, -30, 500, false);
            await brick.DirectCommand.TurnMotorAtPowerForTimeAsync(OutputPort.C, 30, 500, false);
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            await brick.DirectCommand.TurnMotorAtPowerForTimeAsync(OutputPort.B, 30, 500, false);
            await brick.DirectCommand.TurnMotorAtPowerForTimeAsync(OutputPort.C, -30, 500, false);
        }

        //the running program
        public async void Program()
        {

        }
     }
}
