namespace UI_proftaak
{
    partial class fromStart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fromStart));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.btnHideInfo = new System.Windows.Forms.Button();
            this.btnStartRobot = new System.Windows.Forms.Button();
            this.btnStopRobot = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtCom = new System.Windows.Forms.TextBox();
            this.lblCom = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timerCheck = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(1538, 178);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(352, 151);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(1538, 335);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(352, 155);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1493, 740);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowInfo.Location = new System.Drawing.Point(1538, 588);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(352, 74);
            this.btnShowInfo.TabIndex = 4;
            this.btnShowInfo.Text = "Show Info";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // btnHideInfo
            // 
            this.btnHideInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideInfo.Location = new System.Drawing.Point(1538, 678);
            this.btnHideInfo.Name = "btnHideInfo";
            this.btnHideInfo.Size = new System.Drawing.Size(352, 74);
            this.btnHideInfo.TabIndex = 5;
            this.btnHideInfo.Text = "Hide Info";
            this.btnHideInfo.UseVisualStyleBackColor = true;
            this.btnHideInfo.Click += new System.EventHandler(this.btnHideInfo_Click);
            // 
            // btnStartRobot
            // 
            this.btnStartRobot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartRobot.Location = new System.Drawing.Point(1526, 770);
            this.btnStartRobot.Name = "btnStartRobot";
            this.btnStartRobot.Size = new System.Drawing.Size(364, 97);
            this.btnStartRobot.TabIndex = 6;
            this.btnStartRobot.Text = "Start Robot";
            this.btnStartRobot.UseVisualStyleBackColor = true;
            this.btnStartRobot.Click += new System.EventHandler(this.btnStartRobot_Click);
            // 
            // btnStopRobot
            // 
            this.btnStopRobot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopRobot.Location = new System.Drawing.Point(1526, 892);
            this.btnStopRobot.Name = "btnStopRobot";
            this.btnStopRobot.Size = new System.Drawing.Size(364, 96);
            this.btnStopRobot.TabIndex = 7;
            this.btnStopRobot.Text = "Stop Robot";
            this.btnStopRobot.UseVisualStyleBackColor = true;
            this.btnStopRobot.Click += new System.EventHandler(this.btnStopRobot_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.Location = new System.Drawing.Point(12, 770);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(1493, 218);
            this.txtInfo.TabIndex = 8;
            // 
            // txtCom
            // 
            this.txtCom.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCom.Location = new System.Drawing.Point(1538, 94);
            this.txtCom.Name = "txtCom";
            this.txtCom.Size = new System.Drawing.Size(352, 22);
            this.txtCom.TabIndex = 9;
            this.txtCom.Text = "11";
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCom.Location = new System.Drawing.Point(1538, 53);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(294, 36);
            this.lblCom.TabIndex = 10;
            this.lblCom.Text = "Enter your COM-Port";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1544, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1602, 525);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 42);
            this.button2.TabIndex = 12;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1660, 525);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 42);
            this.button3.TabIndex = 13;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1718, 525);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 42);
            this.button4.TabIndex = 14;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // fromStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCom);
            this.Controls.Add(this.txtCom);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnStopRobot);
            this.Controls.Add(this.btnStartRobot);
            this.Controls.Add(this.btnHideInfo);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fromStart";
            this.Text = "UI Robot Cipier";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.Button btnHideInfo;
        private System.Windows.Forms.Button btnStartRobot;
        private System.Windows.Forms.Button btnStopRobot;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtCom;
        private System.Windows.Forms.Label lblCom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timerCheck;
    }
}

